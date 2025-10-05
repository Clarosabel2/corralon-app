using BDE;
using BLL;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCreateEmployee : Form
    {
        private bool flagValidation = false;
        bool isEdit = false;
        public FormEmployeesPhoto formPre { get; set; }
        public FormEmployeeDetails formEmpDatails { get; set; }

        BE_Employee empEdit = new BE_Employee();
        public FormCreateEmployee(BE_Employee emp = null)
        {
            InitializeComponent();
            ApplyModernEmployeeStyle();
            LoadData(emp);
            if (emp != null)
            {
                empEdit = emp;
                isEdit = true;
                btnSaveEmployee.Enabled = true;
                btnSaveEmployee.Text = "Modificar";
            }
        }

        private void ApplyModernEmployeeStyle()
        {
            // ===== Paleta
            Color Primary = ColorTranslator.FromHtml("#06406A");
            Color PrimaryMid = ColorTranslator.FromHtml("#0A5C99");
            Color BgForm = ColorTranslator.FromHtml("#F5F7FA");
            Color TextPrimary = ColorTranslator.FromHtml("#1F2937");
            Color TextMuted = ColorTranslator.FromHtml("#6B7280");
            Color LineColor = ColorTranslator.FromHtml("#D9E2EC");

            // ===== Form
            this.BackColor = BgForm;
            this.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);
            this.Text = "Nuevo empleado";
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // más limpio
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // ===== Labels
            Label[] labels = { lblDni, lblNombre, lblApellido, lblDomicilio, lblEmail, lblTelefono, lblAreas };
            foreach (var lb in labels)
            {
                lb.ForeColor = TextPrimary;
                lb.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);
            }

            // ===== Combo Areas
            cBAreas.FlatStyle = FlatStyle.Flat;
            cBAreas.BackColor = Color.White;
            cBAreas.ForeColor = TextPrimary;
            cBAreas.IntegralHeight = false;
            cBAreas.MaxDropDownItems = 8;

            // ===== TextBoxes con estilo subrayado
            TextBox[] tbs = { txtDni, txtNombre, txtApellido, txtDomicilio, txtEmail, txtTelefono };
            foreach (var tb in tbs)
            {
                tb.BorderStyle = BorderStyle.None;
                tb.BackColor = Color.White;
                tb.ForeColor = TextPrimary;
                tb.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);
                tb.Margin = new Padding(0);
                tb.Height = 24;

                var underline = new Panel { Height = 1, Dock = DockStyle.Bottom, BackColor = LineColor };
                tb.Parent.Controls.Add(underline);
                underline.BringToFront();
                tb.Enter += (s, e) => underline.BackColor = PrimaryMid;
                tb.Leave += (s, e) => underline.BackColor = LineColor;
            }

            // ===== Botón principal
            StylePrimaryButton(btnSaveEmployee, Primary, PrimaryMid);
            this.AcceptButton = btnSaveEmployee; // Enter = Guardar

            // ===== Botones secundarios (foto)
            StyleSecondaryButton(btnUploadPhoto, Primary, PrimaryMid);
            StyleSecondaryButton(btnTakePhoto, Primary, PrimaryMid);

            // ===== Foto redondeada y borde suave
            MakeRoundPicture(pictureBox1, 12, LineColor);

            // ===== OpenFileDialog
            openFileDialog1.Title = "Seleccionar foto…";
            openFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
        }

        // --- Helpers de estilo ---
        private void StylePrimaryButton(Button b, Color baseColor, Color hover)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = baseColor;
            b.ForeColor = Color.White;
            b.Font = new Font("Century Gothic", 10.5f, FontStyle.Bold);
            b.Height = 40;
            b.Cursor = Cursors.Hand;
            b.FlatAppearance.MouseOverBackColor = hover;
        }

        private void StyleSecondaryButton(Button b, Color baseColor, Color hover)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = baseColor;
            b.BackColor = Color.Transparent;
            b.ForeColor = baseColor;
            b.Cursor = Cursors.Hand;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, ColorTranslator.FromHtml("#06406A").R,
                                                                   ColorTranslator.FromHtml("#06406A").G,
                                                                   ColorTranslator.FromHtml("#06406A").B);
        }

        private void MakeRoundPicture(PictureBox pb, int radius, Color border)
        {
            pb.BackColor = Color.White;
            pb.Padding = new Padding(0);
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(pb.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(pb.Width - radius - 1, pb.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, pb.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();
                pb.Region = new Region(path);
            }
            pb.Paint += (s, e) =>
            {
                using (var p = new Pen(border, 1)) e.Graphics.DrawRectangle(p, 0, 0, pb.Width - 1, pb.Height - 1);
            };
        }

        private void LoadData(BE_Employee emp)
        {
            foreach (var item in Enum.GetValues(typeof(BE_Area)))
            {
                cBAreas.Items.Add(item);
            }
            if (emp != null)
            {
                txtDni.Text = emp.Dni.ToString();
                txtNombre.Text = emp.Name;
                txtApellido.Text = emp.Lastname;
                txtDomicilio.Text = emp.Address;
                txtEmail.Text = emp.Email;
                txtTelefono.Text = emp.NumPhone.ToString();
            }
        }
        #region "Validaciones"
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            string email = (sender as TextBox).Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if ((sender as TextBox).Text != "")
            {
                if (!Regex.IsMatch(email, pattern))
                {
                    MessageBox.Show("Correo electrónico no válido");
                    flagValidation = false;

                }
                else
                {
                    flagValidation = true;
                }
            }
            ValidFields();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidFields();
        }

        private void ValidFields()
        {
            if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || !flagValidation)
            {
                btnSaveEmployee.Enabled = false;
            }
            else
            {
                btnSaveEmployee.Enabled = true;
            }



        }
        #endregion

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            BE_Employee emp = new BE_Employee(
                isEdit ? empEdit.Id : 0,
                int.Parse(txtDni.Text),
                txtNombre.Text,
                txtApellido.Text,
                txtDomicilio.Text,
                txtEmail.Text,
                int.Parse(txtTelefono.Text),
                0.0,
                cBAreas.SelectedItem.ToString());

            if (!isEdit)
            {
                if (BLL_Employee.SaveEmployee(emp))
                {
                    DialogResult r = MessageBox.Show("Se guardó el nuevo empleado exitosamente", "Aviso");
                    if (r == DialogResult.OK)
                    {
                        formPre.ShowEmployees(BLL_Employee.GetAllEmployees());
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el empleado", "Aviso");
                }
            }
            else
            {
                if (BLL_Employee.UpdateEmployee(emp))
                {
                    DialogResult r = MessageBox.Show("Se modificaron los datos del empleado exitosamente", "Aviso");
                    if (r == DialogResult.OK)
                    {
                        formEmpDatails.Refresh();
                        formEmpDatails.LoadDataEmployee(emp);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al modificar el empleado", "Aviso");
                }
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {

        }
    }
}

using BDE;
using BLL;
using Guna.UI2.WinForms;
using SVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class FormEmployeesPhoto : Form
    {
        List<BE_Employee> employees = BLL_Employee.GetAllEmployees();
        public FormEmployeesPhoto()
        {
            InitializeComponent();
            LoadDataInForm();
        }
        public void ShowEmployees(List<BE_Employee> emps)
        {
            flowLayoutPanel1.Controls.Clear();
            emps.Remove(emps.FirstOrDefault(e => e.Id == SessionManager.GetInstance.user.Emp.Id));
            foreach (BE_Employee emp in emps)
            {
                var card = new Guna2Panel
                {
                    Width = 260,
                    Height = 150,
                    BorderRadius = 10,
                    BorderThickness = 1,
                    BorderColor = Color.LightGray,
                    FillColor = Color.Transparent,
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                    Tag = emp,
                    ShadowDecoration = {
                        Enabled = true,
                        Color = Color.LightGray,
                        Shadow = new Padding(3)
                    },
                    Margin = new Padding(10, 10, 10, 0)
                };
                var photoEmployee = new Guna2CirclePictureBox
                {
                    Image = Properties.Resources.user_photo_profile, // Tu imagen agregada en Resources
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(64, 64),
                    Location = new Point(10, 10)
                };
                var lblId = new Label
                {
                    Text = $"{emp.Id}",
                    Font = new Font("Century Gothic", 8),
                    Location = new Point(220, 18),
                    AutoSize = true
                };
                var lblName = new Label
                {
                    Text = $"{emp.Name} {emp.Lastname}",
                    Font = new Font("Century Gothic", 10, FontStyle.Bold),
                    Location = new Point(85, 15),
                    AutoSize = true
                };
                var lblDni = new Label
                {
                    Text = $"DNI: {emp.Dni}",
                    Font = new Font("Century Gothic", 10),
                    Location = new Point(85, 35),
                    AutoSize = true
                };
                var lblArea = new Label
                {
                    Text = $"Area: {emp.Area}",
                    Font = new Font("Century Gothic", 9),
                    Location = new Point(85, 55),
                    AutoSize = true
                };
                bool isUser = BLL_User.ExistUserById(emp.Id);
                var lblUser = new Label
                {
                    Text = isUser ? "Usuario del sistema" : "No es usuario",
                    Font = new Font("Century Gothic", 9),
                    Location = new Point(85, 75), // un poco más abajo que el lblArea
                    AutoSize = true
                };
                bool isBlock = false;
                if (isUser)
                {
                    isBlock = BLL_User.CheckStatusUser(emp.Id);
                    StringBuilder sb = new StringBuilder();

                    var lblStatus = new Label
                    {
                        Text = isBlock ? "✅ Tiene acceso al sistema" : "❌ Usuario Bloqueado",
                        ForeColor = isBlock ? Color.Green : Color.Red,
                        Font = new Font("Century Gothic", 9),
                        Location = new Point(20, 115),
                        AutoSize = true,
                    };
                    card.Controls.Add(lblStatus);
                }

                // Eventos opcionales
                card.Click += (s, e) =>
                {
                    if (e is MouseEventArgs me && card.GetChildAtPoint(me.Location) is Guna2Button) return;

                    var fm = new FormEmployeeDetails(emp);
                    fm.form = this;
                    fm.ShowDialog();
                };
                card.MouseEnter += (s, e) => card.FillColor = Color.WhiteSmoke;
                card.MouseLeave += (s, e) => card.FillColor = Color.Transparent;

                // Agregar controles a Card
                card.Controls.Add(lblId);
                card.Controls.Add(photoEmployee);
                card.Controls.Add(lblDni);
                card.Controls.Add(lblName);
                card.Controls.Add(lblArea);
                card.Controls.Add(lblUser);

                flowLayoutPanel1.Controls.Add(card);
            }
        }
        public void LoadDataInForm()
        {
            txtSearch.PlaceholderText = "DNI, nombre, apellido ...";
            txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            cbAreas.DataSource = Enum.GetValues(typeof(BE_Area));
            ShowEmployees(employees);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            var word = txtSearch.Text.Trim().ToLower();
            List<BE_Employee> empFiltered = employees.FindAll(x =>
                x.Name.ToLower().Contains(word) ||
                x.Lastname.ToLower().Contains(word) ||
                x.Dni.ToString().Contains(word));

            if (word != String.Empty)
            {
                ShowEmployees(empFiltered);
            }
            else
            {
                ShowEmployees(employees);
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            FormCreateEmployee fm = new FormCreateEmployee();
            fm.formPre = this;
            fm.StartPosition = FormStartPosition.CenterParent;
            fm.FormBorderStyle = FormBorderStyle.FixedSingle;
            fm.ShowDialog();
        }
    }
}

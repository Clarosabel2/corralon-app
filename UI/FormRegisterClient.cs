using BDE;
using BDE.Language;
using BLL;
using SVC.LanguageManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormRegisterClient : Form, IObserver
    {
        public FormRegisterClient()
        {
            InitializeComponent();
            LanguageManager.Attach(this);
        }

        private void FormRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            var client = new BE_Client
            {
                Dni = int.Parse(txtDni.Text),
                Name = txtNombre.Text,
                Lastname = txtApellido.Text,
                Address = txtDomicilio.Text,
                Email = txtEmail.Text,
                NumPhone = int.Parse(txtTelefono.Text)
            };
            try
            {
                if (BLL_Client.SaveClient(client))
                {
                    DialogResult r = MessageBox.Show($"El client: {client.Name}  {client.Lastname} se registro correctamente", "Aviso", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hubo un error al registrar al cliente: {client.Name} {client.Lastname} \nDetalles: {ex.Message}", "Error");
            }
        }

        public void Update(string language)
        {
            UITranslator.ApplyTranslations(this, LanguageManager.translations[language]);
        }

        private void FormRegisterClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            LanguageManager.Detach(this);
        }
    }
}

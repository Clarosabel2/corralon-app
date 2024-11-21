using BDE;
using BDE.Language;
using BLL;
using SVC;
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
    public partial class FormUserProfile : Form, IObserver
    {
        public static FormMain frmmain;
        public FormUserProfile()
        {
            InitializeComponent();
            LoadDataUser();
            LoadLanguages();
            LanguageManager.Attach(this);
            DisableControls();
            //ResxExporter.ExportControlsToResx(this, @"D:\Proyectos\UAI\3ER AÑO\IS\Proyecto Aplicacion\corralon-app\UI\Resources\ResourceControlsLanguage.resx");
        }

        private void DisableControls()
        {
            btnChangeLanguage.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtCurrentPassword.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
        }

        private void LoadLanguages()
        {
            BLL_Language.GetLanguages().ForEach(l => cBLanguages.Items.Add(l.Name));
            cBLanguages.SelectedIndex = cBLanguages.FindString(SessionManager.GetInstance.user.Language.Name);
        }

        private void LoadDataUser()
        {
            lblUser.Text = SessionManager.GetInstance.user.Username;
            lblFirstName.Text = SessionManager.GetInstance.user.Emp.Name;
            lblLastName.Text = SessionManager.GetInstance.user.Emp.Lastname;
            lblEmail.Text = SessionManager.GetInstance.user.Emp.Email;
            lblPosition.Text = SessionManager.GetInstance.user.Rol.ToString();
        }

        private void lnkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditProfile.Visible = true;
            txtFirstName.Text = SessionManager.GetInstance.user.Emp.Name;
            txtLastName.Text = SessionManager.GetInstance.user.Emp.Lastname;
            txtEmail.Text = SessionManager.GetInstance.user.Emp.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = false;
        }

        private void btnSaveMyData_Click(object sender, EventArgs e)
        {
            if (checkBoxChangeData.Checked)
            {
                var user = new BE_User(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                if (BLL_User.UpdateUserData(user))
                {
                    DialogResult r = MessageBox.Show("Se cambio los datos correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                        panelEditProfile.Visible = false;
                    LoadDataUser();
                    frmmain.LoadDataUser();
                }
            }
            if (checkBoxChangePassword.Checked)
            {
                if (EncodeManager.CompareHash(txtCurrentPassword.Text, SessionManager.GetInstance.user.Password))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        BLL_User.UpdateUserPassword(txtConfirmPassword.Text);
                    }
                    else { MessageBox.Show("Las contraseñas no coinciden"); }
                }
                else { MessageBox.Show("Contraseña actual incorrecta"); }
            }
        }

        private void checkBoxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangePassword.Checked)
            {
                txtPassword.Enabled = true;
                txtCurrentPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtConfirmPassword.Enabled = false;
                txtCurrentPassword.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void checkBoxEditData_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangeData.Checked)
            {
                txtEmail.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
            }
        }

        private void cBLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageManager.CurrentLanguage.Name != cBLanguages.SelectedItem.ToString()) btnChangeLanguage.Enabled = true; else { btnChangeLanguage.Enabled = false; }
        }

        public void Update(BE_Language language)
        {
            try
            {
                UITranslator.ApplyTranslations(this, SessionManager.translations[language][this.Name]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FormUserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            LanguageManager.Detach(this);
        }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desea cambiar el idioma?", "Corfirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) {
                LanguageManager.CurrentLanguage = SessionManager.translations.First(l => l.Key.Name == cBLanguages.SelectedItem.ToString().ToLower()).Key;
                BLL_User.ChangeLanguageUser(LanguageManager.CurrentLanguage);
                btnChangeLanguage.Enabled = false;
            }
        }
    }
}

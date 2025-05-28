using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDE.Language;
using BLL;
using SVC;
using SVC.LanguageManager;

namespace UI
{
    public partial class FormLogin : Form, IObserver
    {
        List<BE_Language> list = BLL_Language.GetLanguages();
        private static Dictionary<string, int> _failedLogins = new Dictionary<string, int>();
        public FormLogin()
        {
            InitializeComponent();
            btnChangeLenguage.Text = list[0].LanguageCode;
            lblErrorMessage.Visible = false;
            BLL_Language.LoadTranslations();
            LanguageManager.Attach(this);
        }
        #region "Funcionalidades Visuales"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            string txt = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name][txtUser.Name] ?? "username";
            if (txtUser.Text == txt)
            {
                txtUser.Text = "";
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name][txtUser.Name] ?? "username";
            }

        }

        private void txtPsswrd_Enter(object sender, EventArgs e)
        {
            var txt = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name][txtPsswrd.Name] ?? "password";
            if (txtPsswrd.Text == txt)
            {
                txtPsswrd.Text = "";
                txtPsswrd.PasswordChar = '*';
            }
        }

        private void txtPsswrd_Leave(object sender, EventArgs e)
        {
            if (txtPsswrd.Text == "")
            {
                txtPsswrd.PasswordChar = '\0';
                txtPsswrd.Text = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name][txtPsswrd.Name] ?? "password";
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            string txt = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name][txtPsswrd.Name] ?? "password";
            if (txtPsswrd.Text != txt)
            {
                if (checkBoxShowPassword.Checked)
                {
                    txtPsswrd.PasswordChar = '\0';
                }
                else
                {
                    txtPsswrd.PasswordChar = '*';
                }
            }

        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Por ahora 
            lblErrorMessage.Visible = false;
            if (BLL_User.ValidUser(txtUser.Text, txtPsswrd.Text))
            {
                if (!SessionManager.GetInstance.user.Status)
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name]["MsgBlockAccount"];
                    if (!_failedLogins.ContainsKey(txtUser.Text))
                    {
                        _failedLogins[SessionManager.GetInstance.user.Username] = -5;
                    }
                    SessionManager.Logout();
                }
                else
                {
                    FormMain frmMain = new FormMain();
                    frmMain.WindowState = FormWindowState.Maximized;
                    frmMain.Show();
                    this.Hide();
                }

            }
            else
            {
                bool flagBlock = false;

                if (_failedLogins.TryGetValue(txtUser.Text, out int _fails))
                {
                    _failedLogins[txtUser.Text]++;
                    if (_failedLogins[txtUser.Text] >= 3)
                    {
                        //bloquear cuenta
                        flagBlock = true;
                        BLL_User.BlockUserByUsername(txtUser.Text);
                        lblErrorMessage.Visible = true;
                        lblErrorMessage.Text = SessionManager.translations[LanguageManager.CurrentLanguage][this.Name]["MsgBlockAccount"];
                    }
                }
                else
                {
                    _failedLogins.Add(txtUser.Text, 1);
                }
                if (!flagBlock)
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = $"{SessionManager.translations[LanguageManager.CurrentLanguage][this.Name]["MsgErrorCredentials"]} {3 - _failedLogins[txtUser.Text]}";
                }
            }

        }
        private int iLen;
        private void btnChangeLenguage_Click(object sender, EventArgs e)
        {
            if (iLen != list.Count - 1)
            {
                iLen++;
            }
            else
            {
                iLen = 0;
            }
            btnChangeLenguage.Text = list[iLen].LanguageCode;
        }

        public void Update(BE_Language language)
        {
            UITranslator.ApplyTranslations(this, SessionManager.translations[language][this.Name]);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            LanguageManager.Detach(this);
        }
    }
}

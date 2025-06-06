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

namespace UI
{
    public partial class FormDatabaseMaintenance : Form
    {
        public FormDatabaseMaintenance()
        {
            InitializeComponent();
        }

        private void btnBrowseBackupPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccionar carpeta para guardar el backup";
                folderDialog.SelectedPath = txtBackupPath.Text; // Ruta actual como predeterminada

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBackupPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnBrowseRestoreFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup files (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRestoreFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnExecuteBackup_Click(object sender, EventArgs e)
        {
            DatabaseService ds = new DatabaseService();
            ds.DoBackup(txtBackupPath.Text);
        }

        private void btnCheckIntegrity_Click(object sender, EventArgs e)
        {

        }
    }
}

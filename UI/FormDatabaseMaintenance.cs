using BLL;
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
        public FormDatabaseMaintenance(BLL_DV_DB dv = null)
        {
            InitializeComponent();
            if (dv != null)
            {
                btnRecalculateDV.Visible = true;
                btnCheckIntegrity.Visible = false;
                tabControl1.SelectedIndex = 2;
                foreach (var m in dv.LastMismatches
                    .OrderBy(x => x.TableName)
                    .ThenBy(x => x.RowKey))
                {
                    txtIntegrityResults.Text = 
                        $"⚠️ Inconsistencias DVH encontradas: - {m.Kind} | Table: {m.TableName} | RowKey={m.RowKey}";
                }
            }
        }

        private void btnBrowseBackupPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Seleccionar carpeta para guardar el backup";
                folderDialog.SelectedPath = txtBackupPath.Text;

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

        private void btnRecalculateDV_Click(object sender, EventArgs e)
        {

        }
    }
}
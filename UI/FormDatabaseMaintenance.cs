using BLL;
using SVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UI
{
    public partial class FormDatabaseMaintenance : Form
    {
        private BLL_DV_DB _dbIntegrityService;
        public FormDatabaseMaintenance(BLL_DV_DB dv = null)
        {
            InitializeComponent();
            if (dv != null)
            {
                this._dbIntegrityService = dv;
                ConfigMsgIntegrity();
            }
            else
            {
                this._dbIntegrityService = new BLL_DV_DB();
            }
        }


        private void ConfigMsgIntegrity()
        {
            btnRecalculateDV.Visible = true;
            btnCheckIntegrity.Visible = false;
            tabControlFormDM.SelectedIndex = 2;
            listBoxIntegrityResults.Items.Clear();
            listBoxIntegrityResults.Items.Add("⚠️ Inconsistencias DVH encontradas:");
            listBoxIntegrityResults.Font = new Font("Consolas", 10);

            listBoxIntegrityResults.Items.Add("Tipo DV\tError\tTable\tRowKey");

            foreach (var m in _dbIntegrityService.LastMismatches)
            {
                listBoxIntegrityResults.Items.Add(
                    $"{m.DvKind}\t{m.KindError}\t{m.TableName}\t{m.RowKey}"
                );
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
                //openFileDialog.Filter = "Backup files (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                //openFileDialog.FilterIndex = 1;
                //openFileDialog.RestoreDirectory = true;

                //if (openFileDialog.ShowDialog() == DialogResult.OK)
                //{
                //    txtRestoreFile.Text = openFileDialog.FileName;
                //}
            }
        }

        private void btnExecuteBackup_Click(object sender, EventArgs e)
        {
            DatabaseService ds = new DatabaseService();
            ds.DoBackup();
        }

        private void btnCheckIntegrity_Click(object sender, EventArgs e)
        {
            ConfigMsgIntegrity();
        }

        private void btnRecalculateDV_Click(object sender, EventArgs e)
        {
            _dbIntegrityService.RecalculateDV();
        }

        private void btnExecuteRestore_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            // Buscar la fila donde el radiobutton/checkbox está marcado
            foreach (DataGridViewRow row in dgvFileBackups.Rows)
            {
                var cellValue = row.Cells["colRestore"].Value;
                if (cellValue != null && cellValue is bool && (bool)cellValue)
                {
                    selectedRow = row;
                    break;
                }
            }

            if (selectedRow == null)
            {
                MessageBox.Show("Debe seleccionar un backup para restaurar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string backupPath = selectedRow.Cells["FullPath"].Value.ToString();

            DialogResult dr = MessageBox.Show(
                $"¿Está seguro de restaurar este backup?\n\n{backupPath}",
                "Confirmar Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    DatabaseService ds = new DatabaseService();
                    ds.DoRestore(backupPath);
                    MessageBox.Show("Restauración realizada con éxito.",
                        "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al restaurar: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ConfigDGV()
        {
            dgvFileBackups.Columns.Clear();
            DataGridViewCheckBoxColumn colSelect = new DataGridViewCheckBoxColumn();
            colSelect.HeaderText = "Restore";
            colSelect.Name = "colRestore";
            colSelect.Width = 60;
            dgvFileBackups.Columns.Insert(0, colSelect);


            dgvFileBackups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFileBackups.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvFileBackups.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvFileBackups.Columns[0].Width = 80;

            dgvFileBackups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFileBackups.AllowUserToAddRows = false;
            dgvFileBackups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void tabControlFormDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigDGV();
            if (tabControlFormDM.SelectedIndex != 1) return;

            string appRoot = AppDomain.CurrentDomain.BaseDirectory;
            string backupFolder = Path.Combine(appRoot, "Backups");

            if (!Directory.Exists(backupFolder))
                Directory.CreateDirectory(backupFolder);

            var dt = new DataTable();
            dt.Columns.Add("File", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("IssueDate", typeof(string));
            dt.Columns.Add("FullPath", typeof(string));
            dt.Columns.Add("SortDate", typeof(DateTime));

            var files = Directory.GetFiles(backupFolder, "*.bak", SearchOption.TopDirectoryOnly);

            foreach (var path in files)
            {
                var fi = new FileInfo(path);
                DateTime fechaParsed;
                string fechaNombre = ExtraerFechaDeNombre(fi.Name, out fechaParsed);
                if (fechaParsed == default) fechaParsed = fi.LastWriteTime;

                var row = dt.NewRow();
                row["File"] = fi.Name;
                row["Size"] = HumanSize(fi.Length);
                row["IssueDate"] = fechaNombre.Length > 0 ? fechaNombre : fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
                row["FullPath"] = fi.FullName;
                row["SortDate"] = fechaParsed;
                dt.Rows.Add(row);
            }
            dt.DefaultView.Sort = "SortDate DESC";

            dgvFileBackups.DataSource = null;
            dgvFileBackups.AutoGenerateColumns = true;
            dgvFileBackups.DataSource = dt;

            if (dgvFileBackups.Columns["FullPath"] != null)
                dgvFileBackups.Columns["FullPath"].Visible = false;
            if (dgvFileBackups.Columns["SortDate"] != null)
                dgvFileBackups.Columns["SortDate"].Visible = false;

        }
        private string ExtraerFechaDeNombre(string fileName, out DateTime fecha)
        {
            fecha = default;

            // Esperado: corralondb_full_2025-10-03_15-55-12.bak
            string nameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
            var partes = nameWithoutExt.Split('_');

            if (partes.Length >= 4)
            {
                string fechaStr = partes[2]; // "2025-10-03"
                string horaStr = partes[3]; // "15-55-12" -> "15:55:12"
                string combinado = $"{fechaStr} {horaStr.Replace("-", ":")}";

                if (DateTime.TryParse(combinado, out fecha))
                    return fecha.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return string.Empty;
        }

        private string HumanSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024.0;
            }
            return $"{len:0.##} {sizes[order]}";
        }

        private void btnRecalculateAllDV_Click(object sender, EventArgs e)
        {
            _dbIntegrityService.CalculateDVHDatabase();
        }
    }
}
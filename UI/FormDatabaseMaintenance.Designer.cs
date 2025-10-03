using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDatabaseMaintenance
    {
        private System.ComponentModel.IContainer components = null;

        // Controles principales
        private TabControl tabControl1;
        private TabPage tabBackup;
        private TabPage tabRestore;
        private TabPage tabIntegrity;

        // Controles de Backup
        private TextBox txtBackupPath;
        private Button btnBrowseBackupPath;
        private CheckBox chkCompression;
        private CheckBox chkVerifyAfterBackup;
        private Button btnExecuteBackup;
        private ProgressBar progressBarBackup;
        private Label lblBackupStatus;

        // Controles de Restauración
        private TextBox txtRestoreFile;
        private Button btnBrowseRestoreFile;
        private CheckBox chkReplaceDatabase;
        private Button btnExecuteRestore;
        private ProgressBar progressBarRestore;
        private Label lblRestoreStatus;

        // Controles de Integridad
        private Button btnCheckIntegrity;
        private Label lblIntegrityStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowseBackupPath = new System.Windows.Forms.Button();
            this.chkCompression = new System.Windows.Forms.CheckBox();
            this.chkVerifyAfterBackup = new System.Windows.Forms.CheckBox();
            this.btnExecuteBackup = new System.Windows.Forms.Button();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.txtRestoreFile = new System.Windows.Forms.TextBox();
            this.btnBrowseRestoreFile = new System.Windows.Forms.Button();
            this.chkReplaceDatabase = new System.Windows.Forms.CheckBox();
            this.btnExecuteRestore = new System.Windows.Forms.Button();
            this.progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.lblRestoreStatus = new System.Windows.Forms.Label();
            this.tabIntegrity = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckIntegrity = new System.Windows.Forms.Button();
            this.btnRecalculateDV = new System.Windows.Forms.Button();
            this.lblIntegrityStatus = new System.Windows.Forms.Label();
            this.listBoxIntegrityResults = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.tabIntegrity.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBackup);
            this.tabControl1.Controls.Add(this.tabRestore);
            this.tabControl1.Controls.Add(this.tabIntegrity);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 810);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.txtBackupPath);
            this.tabBackup.Controls.Add(this.btnBrowseBackupPath);
            this.tabBackup.Controls.Add(this.chkCompression);
            this.tabBackup.Controls.Add(this.chkVerifyAfterBackup);
            this.tabBackup.Controls.Add(this.btnExecuteBackup);
            this.tabBackup.Controls.Add(this.progressBarBackup);
            this.tabBackup.Controls.Add(this.lblBackupStatus);
            this.tabBackup.Location = new System.Drawing.Point(4, 36);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(15);
            this.tabBackup.Size = new System.Drawing.Size(721, 635);
            this.tabBackup.TabIndex = 0;
            this.tabBackup.Text = "  BACKUP  ";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBackupPath.Location = new System.Drawing.Point(20, 20);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(550, 36);
            this.txtBackupPath.TabIndex = 0;
            this.txtBackupPath.Text = "C:\\Backups\\";
            // 
            // btnBrowseBackupPath
            // 
            this.btnBrowseBackupPath.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBrowseBackupPath.Location = new System.Drawing.Point(580, 20);
            this.btnBrowseBackupPath.Name = "btnBrowseBackupPath";
            this.btnBrowseBackupPath.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseBackupPath.TabIndex = 1;
            this.btnBrowseBackupPath.Text = "Examinar";
            this.btnBrowseBackupPath.Click += new System.EventHandler(this.btnBrowseBackupPath_Click);
            // 
            // chkCompression
            // 
            this.chkCompression.Checked = true;
            this.chkCompression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompression.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkCompression.Location = new System.Drawing.Point(20, 70);
            this.chkCompression.Name = "chkCompression";
            this.chkCompression.Size = new System.Drawing.Size(104, 24);
            this.chkCompression.TabIndex = 2;
            this.chkCompression.Text = "Usar compresión";
            // 
            // chkVerifyAfterBackup
            // 
            this.chkVerifyAfterBackup.Checked = true;
            this.chkVerifyAfterBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVerifyAfterBackup.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkVerifyAfterBackup.Location = new System.Drawing.Point(20, 110);
            this.chkVerifyAfterBackup.Name = "chkVerifyAfterBackup";
            this.chkVerifyAfterBackup.Size = new System.Drawing.Size(104, 24);
            this.chkVerifyAfterBackup.TabIndex = 3;
            this.chkVerifyAfterBackup.Text = "Verificar integridad después del backup";
            // 
            // btnExecuteBackup
            // 
            this.btnExecuteBackup.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExecuteBackup.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExecuteBackup.Location = new System.Drawing.Point(20, 150);
            this.btnExecuteBackup.Name = "btnExecuteBackup";
            this.btnExecuteBackup.Size = new System.Drawing.Size(200, 45);
            this.btnExecuteBackup.TabIndex = 4;
            this.btnExecuteBackup.Text = "REALIZAR BACKUP";
            this.btnExecuteBackup.Click += new System.EventHandler(this.btnExecuteBackup_Click);
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(20, 210);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(660, 30);
            this.progressBarBackup.TabIndex = 5;
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblBackupStatus.Location = new System.Drawing.Point(20, 250);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(660, 40);
            this.lblBackupStatus.TabIndex = 6;
            this.lblBackupStatus.Text = "Listo para realizar backup de la base de datos";
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.txtRestoreFile);
            this.tabRestore.Controls.Add(this.btnBrowseRestoreFile);
            this.tabRestore.Controls.Add(this.chkReplaceDatabase);
            this.tabRestore.Controls.Add(this.btnExecuteRestore);
            this.tabRestore.Controls.Add(this.progressBarRestore);
            this.tabRestore.Controls.Add(this.lblRestoreStatus);
            this.tabRestore.Location = new System.Drawing.Point(4, 36);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(15);
            this.tabRestore.Size = new System.Drawing.Size(721, 635);
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "  RESTAURAR  ";
            // 
            // txtRestoreFile
            // 
            this.txtRestoreFile.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRestoreFile.Location = new System.Drawing.Point(20, 20);
            this.txtRestoreFile.Name = "txtRestoreFile";
            this.txtRestoreFile.Size = new System.Drawing.Size(550, 36);
            this.txtRestoreFile.TabIndex = 0;
            // 
            // btnBrowseRestoreFile
            // 
            this.btnBrowseRestoreFile.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBrowseRestoreFile.Location = new System.Drawing.Point(580, 20);
            this.btnBrowseRestoreFile.Name = "btnBrowseRestoreFile";
            this.btnBrowseRestoreFile.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseRestoreFile.TabIndex = 1;
            this.btnBrowseRestoreFile.Text = "Examinar";
            this.btnBrowseRestoreFile.Click += new System.EventHandler(this.btnBrowseRestoreFile_Click);
            // 
            // chkReplaceDatabase
            // 
            this.chkReplaceDatabase.Checked = true;
            this.chkReplaceDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReplaceDatabase.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkReplaceDatabase.Location = new System.Drawing.Point(20, 70);
            this.chkReplaceDatabase.Name = "chkReplaceDatabase";
            this.chkReplaceDatabase.Size = new System.Drawing.Size(104, 24);
            this.chkReplaceDatabase.TabIndex = 2;
            this.chkReplaceDatabase.Text = "Reemplazar base de datos existente";
            // 
            // btnExecuteRestore
            // 
            this.btnExecuteRestore.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExecuteRestore.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExecuteRestore.Location = new System.Drawing.Point(20, 110);
            this.btnExecuteRestore.Name = "btnExecuteRestore";
            this.btnExecuteRestore.Size = new System.Drawing.Size(200, 45);
            this.btnExecuteRestore.TabIndex = 3;
            this.btnExecuteRestore.Text = "RESTAURAR BACKUP";
            // 
            // progressBarRestore
            // 
            this.progressBarRestore.Location = new System.Drawing.Point(20, 170);
            this.progressBarRestore.Name = "progressBarRestore";
            this.progressBarRestore.Size = new System.Drawing.Size(660, 30);
            this.progressBarRestore.TabIndex = 4;
            // 
            // lblRestoreStatus
            // 
            this.lblRestoreStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRestoreStatus.Location = new System.Drawing.Point(20, 210);
            this.lblRestoreStatus.Name = "lblRestoreStatus";
            this.lblRestoreStatus.Size = new System.Drawing.Size(660, 40);
            this.lblRestoreStatus.TabIndex = 5;
            this.lblRestoreStatus.Text = "Seleccione un archivo de backup (.bak) para restaurar";
            // 
            // tabIntegrity
            // 
            this.tabIntegrity.Controls.Add(this.listBoxIntegrityResults);
            this.tabIntegrity.Controls.Add(this.flowLayoutPanel1);
            this.tabIntegrity.Controls.Add(this.lblIntegrityStatus);
            this.tabIntegrity.Location = new System.Drawing.Point(4, 36);
            this.tabIntegrity.Name = "tabIntegrity";
            this.tabIntegrity.Padding = new System.Windows.Forms.Padding(15);
            this.tabIntegrity.Size = new System.Drawing.Size(1037, 770);
            this.tabIntegrity.TabIndex = 2;
            this.tabIntegrity.Text = "  INTEGRIDAD  ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnCheckIntegrity);
            this.flowLayoutPanel1.Controls.Add(this.btnRecalculateDV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1019, 56);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCheckIntegrity
            // 
            this.btnCheckIntegrity.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCheckIntegrity.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCheckIntegrity.Location = new System.Drawing.Point(3, 3);
            this.btnCheckIntegrity.Name = "btnCheckIntegrity";
            this.btnCheckIntegrity.Size = new System.Drawing.Size(200, 45);
            this.btnCheckIntegrity.TabIndex = 0;
            this.btnCheckIntegrity.Text = "VERIFICAR INTEGRIDAD";
            this.btnCheckIntegrity.Click += new System.EventHandler(this.btnCheckIntegrity_Click);
            // 
            // btnRecalculateDV
            // 
            this.btnRecalculateDV.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRecalculateDV.ForeColor = System.Drawing.Color.Black;
            this.btnRecalculateDV.Location = new System.Drawing.Point(209, 3);
            this.btnRecalculateDV.Name = "btnRecalculateDV";
            this.btnRecalculateDV.Size = new System.Drawing.Size(200, 45);
            this.btnRecalculateDV.TabIndex = 3;
            this.btnRecalculateDV.Text = " RECALCULAR DV";
            this.btnRecalculateDV.Click += new System.EventHandler(this.btnRecalculateDV_Click);
            // 
            // lblIntegrityStatus
            // 
            this.lblIntegrityStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblIntegrityStatus.Location = new System.Drawing.Point(20, 440);
            this.lblIntegrityStatus.Name = "lblIntegrityStatus";
            this.lblIntegrityStatus.Size = new System.Drawing.Size(660, 40);
            this.lblIntegrityStatus.TabIndex = 2;
            this.lblIntegrityStatus.Text = "Presione el botón para verificar la integridad de la base de datos";
            // 
            // listBoxIntegrityResults
            // 
            this.listBoxIntegrityResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIntegrityResults.FormattingEnabled = true;
            this.listBoxIntegrityResults.ItemHeight = 27;
            this.listBoxIntegrityResults.Location = new System.Drawing.Point(11, 80);
            this.listBoxIntegrityResults.Name = "listBoxIntegrityResults";
            this.listBoxIntegrityResults.Size = new System.Drawing.Size(1018, 355);
            this.listBoxIntegrityResults.TabIndex = 5;
            // 
            // FormDatabaseMaintenance
            // 
            this.ClientSize = new System.Drawing.Size(1045, 810);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FormDatabaseMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MANTENIMIENTO DE BASE DE DATOS";
            this.tabControl1.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.tabBackup.PerformLayout();
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.tabIntegrity.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Button btnRecalculateDV;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBoxIntegrityResults;
    }
}
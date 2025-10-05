using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormDatabaseMaintenance
    {
        private System.ComponentModel.IContainer components = null;

        // Controles principales
        private TabControl tabControlFormDM;
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
            this.tabControlFormDM = new System.Windows.Forms.TabControl();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowseBackupPath = new System.Windows.Forms.Button();
            this.chkCompression = new System.Windows.Forms.CheckBox();
            this.chkVerifyAfterBackup = new System.Windows.Forms.CheckBox();
            this.btnExecuteBackup = new System.Windows.Forms.Button();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.dgvFileBackups = new System.Windows.Forms.DataGridView();
            this.btnExecuteRestore = new System.Windows.Forms.Button();
            this.progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.lblRestoreStatus = new System.Windows.Forms.Label();
            this.tabIntegrity = new System.Windows.Forms.TabPage();
            this.listBoxIntegrityResults = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckIntegrity = new System.Windows.Forms.Button();
            this.btnRecalculateDV = new System.Windows.Forms.Button();
            this.btnRecalculateAllDV = new System.Windows.Forms.Button();
            this.lblIntegrityStatus = new System.Windows.Forms.Label();
            this.tabControlFormDM.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.tabRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileBackups)).BeginInit();
            this.tabIntegrity.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFormDM
            // 
            this.tabControlFormDM.Controls.Add(this.tabBackup);
            this.tabControlFormDM.Controls.Add(this.tabRestore);
            this.tabControlFormDM.Controls.Add(this.tabIntegrity);
            this.tabControlFormDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFormDM.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControlFormDM.Location = new System.Drawing.Point(0, 0);
            this.tabControlFormDM.Name = "tabControlFormDM";
            this.tabControlFormDM.SelectedIndex = 0;
            this.tabControlFormDM.Size = new System.Drawing.Size(1080, 760);
            this.tabControlFormDM.TabIndex = 0;
            this.tabControlFormDM.SelectedIndexChanged += new System.EventHandler(this.tabControlFormDM_SelectedIndexChanged);
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
            this.tabBackup.Location = new System.Drawing.Point(4, 26);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(15);
            this.tabBackup.Size = new System.Drawing.Size(1072, 730);
            this.tabBackup.TabIndex = 0;
            this.tabBackup.Text = "  BACKUP  ";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBackupPath.Location = new System.Drawing.Point(20, 20);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(550, 24);
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
            this.tabRestore.Controls.Add(this.dgvFileBackups);
            this.tabRestore.Controls.Add(this.btnExecuteRestore);
            this.tabRestore.Controls.Add(this.progressBarRestore);
            this.tabRestore.Controls.Add(this.lblRestoreStatus);
            this.tabRestore.Location = new System.Drawing.Point(4, 26);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(15);
            this.tabRestore.Size = new System.Drawing.Size(1072, 730);
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "  RESTAURAR  ";
            // 
            // dgvFileBackups
            // 
            this.dgvFileBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileBackups.Location = new System.Drawing.Point(18, 69);
            this.dgvFileBackups.Name = "dgvFileBackups";
            this.dgvFileBackups.RowHeadersWidth = 72;
            this.dgvFileBackups.RowTemplate.Height = 31;
            this.dgvFileBackups.Size = new System.Drawing.Size(1036, 532);
            this.dgvFileBackups.TabIndex = 6;
            // 
            // btnExecuteRestore
            // 
            this.btnExecuteRestore.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExecuteRestore.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExecuteRestore.Location = new System.Drawing.Point(18, 18);
            this.btnExecuteRestore.Name = "btnExecuteRestore";
            this.btnExecuteRestore.Size = new System.Drawing.Size(200, 45);
            this.btnExecuteRestore.TabIndex = 3;
            this.btnExecuteRestore.Text = "RESTAURAR BASE DE DATOS";
            this.btnExecuteRestore.Click += new System.EventHandler(this.btnExecuteRestore_Click);
            // 
            // progressBarRestore
            // 
            this.progressBarRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarRestore.Location = new System.Drawing.Point(18, 607);
            this.progressBarRestore.Name = "progressBarRestore";
            this.progressBarRestore.Size = new System.Drawing.Size(660, 30);
            this.progressBarRestore.TabIndex = 4;
            // 
            // lblRestoreStatus
            // 
            this.lblRestoreStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRestoreStatus.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRestoreStatus.Location = new System.Drawing.Point(18, 646);
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
            this.tabIntegrity.Location = new System.Drawing.Point(4, 26);
            this.tabIntegrity.Name = "tabIntegrity";
            this.tabIntegrity.Padding = new System.Windows.Forms.Padding(15);
            this.tabIntegrity.Size = new System.Drawing.Size(1072, 730);
            this.tabIntegrity.TabIndex = 2;
            this.tabIntegrity.Text = "  INTEGRIDAD  ";
            // 
            // listBoxIntegrityResults
            // 
            this.listBoxIntegrityResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIntegrityResults.FormattingEnabled = true;
            this.listBoxIntegrityResults.ItemHeight = 17;
            this.listBoxIntegrityResults.Location = new System.Drawing.Point(11, 80);
            this.listBoxIntegrityResults.Name = "listBoxIntegrityResults";
            this.listBoxIntegrityResults.Size = new System.Drawing.Size(1053, 242);
            this.listBoxIntegrityResults.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnCheckIntegrity);
            this.flowLayoutPanel1.Controls.Add(this.btnRecalculateDV);
            this.flowLayoutPanel1.Controls.Add(this.btnRecalculateAllDV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 56);
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
            this.btnRecalculateDV.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnRecalculateDV.ForeColor = System.Drawing.Color.Black;
            this.btnRecalculateDV.Location = new System.Drawing.Point(209, 3);
            this.btnRecalculateDV.Name = "btnRecalculateDV";
            this.btnRecalculateDV.Size = new System.Drawing.Size(200, 45);
            this.btnRecalculateDV.TabIndex = 3;
            this.btnRecalculateDV.Text = "    RECALCULAR\r\nINCONSISTENCIAS";
            this.btnRecalculateDV.Visible = false;
            this.btnRecalculateDV.Click += new System.EventHandler(this.btnRecalculateDV_Click);
            // 
            // btnRecalculateAllDV
            // 
            this.btnRecalculateAllDV.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRecalculateAllDV.ForeColor = System.Drawing.Color.Black;
            this.btnRecalculateAllDV.Location = new System.Drawing.Point(415, 3);
            this.btnRecalculateAllDV.Name = "btnRecalculateAllDV";
            this.btnRecalculateAllDV.Size = new System.Drawing.Size(200, 45);
            this.btnRecalculateAllDV.TabIndex = 4;
            this.btnRecalculateAllDV.Text = " RECALCULAR DV";
            this.btnRecalculateAllDV.Click += new System.EventHandler(this.btnRecalculateAllDV_Click);
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
            // FormDatabaseMaintenance
            // 
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Controls.Add(this.tabControlFormDM);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FormDatabaseMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MANTENIMIENTO DE BASE DE DATOS";
            this.tabControlFormDM.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.tabBackup.PerformLayout();
            this.tabRestore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileBackups)).EndInit();
            this.tabIntegrity.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Button btnRecalculateDV;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBoxIntegrityResults;
        private DataGridView dgvFileBackups;
        private Button btnRecalculateAllDV;
    }
}
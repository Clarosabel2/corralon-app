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

        // Controles de Backup - Header
        private Panel pnlBackupHeader;
        private Label lblBackupTitle;
        private Label lblBackupSubtitle;

        // Controles de Backup - Destino
        private GroupBox grpBackupDestination;
        private RadioButton rbDefaultPath;
        private Label lblDefaultPathValue;
        private RadioButton rbCustomPath;
        private TextBox txtBackupPath;
        private Button btnBrowseBackupPath;

        // Controles de Backup - Opciones
        private GroupBox grpBackupOptions;
        private CheckBox chkCompression;
        private CheckBox chkVerifyAfterBackup;

        // Controles de Backup - Acción
        private Button btnExecuteBackup;
        private ProgressBar progressBarBackup;
        private Label lblBackupStatus;

        // Controles de Restore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlFormDM = new System.Windows.Forms.TabControl();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.pnlBackupHeader = new System.Windows.Forms.Panel();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.lblBackupSubtitle = new System.Windows.Forms.Label();
            this.grpBackupDestination = new System.Windows.Forms.GroupBox();
            this.rbDefaultPath = new System.Windows.Forms.RadioButton();
            this.lblDefaultPathValue = new System.Windows.Forms.Label();
            this.rbCustomPath = new System.Windows.Forms.RadioButton();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowseBackupPath = new System.Windows.Forms.Button();
            this.grpBackupOptions = new System.Windows.Forms.GroupBox();
            this.chkCompression = new System.Windows.Forms.CheckBox();
            this.chkVerifyAfterBackup = new System.Windows.Forms.CheckBox();
            this.btnExecuteBackup = new System.Windows.Forms.Button();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.lblBackupStatus = new System.Windows.Forms.Label();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.pnlRestoreHeader = new System.Windows.Forms.Panel();
            this.lblRestoreTitle = new System.Windows.Forms.Label();
            this.lblRestoreSubtitle = new System.Windows.Forms.Label();
            this.lblPathRestore = new System.Windows.Forms.Label();
            this.btnBrowseRestoreFile = new System.Windows.Forms.Button();
            this.txtRestoreFile = new System.Windows.Forms.TextBox();
            this.dgvFileBackups = new System.Windows.Forms.DataGridView();
            this.btnExecuteRestore = new System.Windows.Forms.Button();
            this.progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.lblRestoreStatus = new System.Windows.Forms.Label();
            this.tabIntegrity = new System.Windows.Forms.TabPage();
            this.pnlIntegrityHeader = new System.Windows.Forms.Panel();
            this.lblIntegrityTitle = new System.Windows.Forms.Label();
            this.lblIntegritySubtitle = new System.Windows.Forms.Label();
            this.listBoxIntegrityResults = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckIntegrity = new System.Windows.Forms.Button();
            this.btnRecalculateDV = new System.Windows.Forms.Button();
            this.btnRecalculateAllDV = new System.Windows.Forms.Button();
            this.lblIntegrityStatus = new System.Windows.Forms.Label();
            this.tabControlFormDM.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.pnlBackupHeader.SuspendLayout();
            this.grpBackupDestination.SuspendLayout();
            this.grpBackupOptions.SuspendLayout();
            this.tabRestore.SuspendLayout();
            this.pnlRestoreHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileBackups)).BeginInit();
            this.tabIntegrity.SuspendLayout();
            this.pnlIntegrityHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFormDM
            // 
            this.tabControlFormDM.Controls.Add(this.tabBackup);
            this.tabControlFormDM.Controls.Add(this.tabRestore);
            this.tabControlFormDM.Controls.Add(this.tabIntegrity);
            this.tabControlFormDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFormDM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlFormDM.ItemSize = new System.Drawing.Size(180, 36);
            this.tabControlFormDM.Location = new System.Drawing.Point(0, 0);
            this.tabControlFormDM.Name = "tabControlFormDM";
            this.tabControlFormDM.Padding = new System.Drawing.Point(20, 6);
            this.tabControlFormDM.SelectedIndex = 0;
            this.tabControlFormDM.Size = new System.Drawing.Size(1080, 760);
            this.tabControlFormDM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlFormDM.TabIndex = 0;
            this.tabControlFormDM.SelectedIndexChanged += new System.EventHandler(this.tabControlFormDM_SelectedIndexChanged);
            // 
            // ---------------------------------------------------
            // TAB BACKUP
            // ---------------------------------------------------
            // 
            this.tabBackup.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.tabBackup.Controls.Add(this.pnlBackupHeader);
            this.tabBackup.Controls.Add(this.grpBackupDestination);
            this.tabBackup.Controls.Add(this.grpBackupOptions);
            this.tabBackup.Controls.Add(this.btnExecuteBackup);
            this.tabBackup.Controls.Add(this.progressBarBackup);
            this.tabBackup.Controls.Add(this.lblBackupStatus);
            this.tabBackup.Location = new System.Drawing.Point(4, 40);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(20);
            this.tabBackup.Size = new System.Drawing.Size(1072, 716);
            this.tabBackup.TabIndex = 0;
            this.tabBackup.Text = "  ✦  BACKUP  ";
            // 
            // pnlBackupHeader
            // 
            this.pnlBackupHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackupHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlBackupHeader.Controls.Add(this.lblBackupTitle);
            this.pnlBackupHeader.Controls.Add(this.lblBackupSubtitle);
            this.pnlBackupHeader.Location = new System.Drawing.Point(20, 15);
            this.pnlBackupHeader.Name = "pnlBackupHeader";
            this.pnlBackupHeader.Size = new System.Drawing.Size(1032, 80);
            this.pnlBackupHeader.TabIndex = 0;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblBackupTitle.ForeColor = System.Drawing.Color.White;
            this.lblBackupTitle.Location = new System.Drawing.Point(20, 12);
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(250, 30);
            this.lblBackupTitle.TabIndex = 0;
            this.lblBackupTitle.Text = "💾  Copia de Seguridad";
            // 
            // lblBackupSubtitle
            // 
            this.lblBackupSubtitle.AutoSize = true;
            this.lblBackupSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackupSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblBackupSubtitle.Location = new System.Drawing.Point(22, 48);
            this.lblBackupSubtitle.Name = "lblBackupSubtitle";
            this.lblBackupSubtitle.Size = new System.Drawing.Size(400, 17);
            this.lblBackupSubtitle.TabIndex = 1;
            this.lblBackupSubtitle.Text = "Genere una copia de seguridad completa de la base de datos";
            // 
            // grpBackupDestination
            // 
            this.grpBackupDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBackupDestination.BackColor = System.Drawing.Color.White;
            this.grpBackupDestination.Controls.Add(this.rbDefaultPath);
            this.grpBackupDestination.Controls.Add(this.lblDefaultPathValue);
            this.grpBackupDestination.Controls.Add(this.rbCustomPath);
            this.grpBackupDestination.Controls.Add(this.txtBackupPath);
            this.grpBackupDestination.Controls.Add(this.btnBrowseBackupPath);
            this.grpBackupDestination.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpBackupDestination.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpBackupDestination.Location = new System.Drawing.Point(20, 110);
            this.grpBackupDestination.Name = "grpBackupDestination";
            this.grpBackupDestination.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpBackupDestination.Size = new System.Drawing.Size(1032, 175);
            this.grpBackupDestination.TabIndex = 1;
            this.grpBackupDestination.TabStop = false;
            this.grpBackupDestination.Text = "  📂  Destino del Backup  ";
            // 
            // rbDefaultPath
            // 
            this.rbDefaultPath.AutoSize = true;
            this.rbDefaultPath.Checked = true;
            this.rbDefaultPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbDefaultPath.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbDefaultPath.Location = new System.Drawing.Point(25, 35);
            this.rbDefaultPath.Name = "rbDefaultPath";
            this.rbDefaultPath.Size = new System.Drawing.Size(260, 23);
            this.rbDefaultPath.TabIndex = 0;
            this.rbDefaultPath.TabStop = true;
            this.rbDefaultPath.Text = "Guardar en directorio por defecto";
            // 
            // lblDefaultPathValue
            // 
            this.lblDefaultPathValue.AutoSize = true;
            this.lblDefaultPathValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDefaultPathValue.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDefaultPathValue.Location = new System.Drawing.Point(47, 62);
            this.lblDefaultPathValue.Name = "lblDefaultPathValue";
            this.lblDefaultPathValue.Size = new System.Drawing.Size(350, 15);
            this.lblDefaultPathValue.TabIndex = 1;
            this.lblDefaultPathValue.Text = "📁  Mis Documentos\\Delcons\\Backups";
            // 
            // rbCustomPath
            // 
            this.rbCustomPath.AutoSize = true;
            this.rbCustomPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCustomPath.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbCustomPath.Location = new System.Drawing.Point(25, 95);
            this.rbCustomPath.Name = "rbCustomPath";
            this.rbCustomPath.Size = new System.Drawing.Size(230, 23);
            this.rbCustomPath.TabIndex = 2;
            this.rbCustomPath.Text = "Guardar en otro directorio";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupPath.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBackupPath.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.txtBackupPath.Location = new System.Drawing.Point(47, 130);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(850, 25);
            this.txtBackupPath.TabIndex = 3;
            this.txtBackupPath.Text = "C:\\";
            // 
            // btnBrowseBackupPath
            // 
            this.btnBrowseBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseBackupPath.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnBrowseBackupPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseBackupPath.Enabled = false;
            this.btnBrowseBackupPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBrowseBackupPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnBrowseBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBackupPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseBackupPath.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnBrowseBackupPath.Location = new System.Drawing.Point(910, 128);
            this.btnBrowseBackupPath.Name = "btnBrowseBackupPath";
            this.btnBrowseBackupPath.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseBackupPath.TabIndex = 4;
            this.btnBrowseBackupPath.Text = "📁 Examinar";
            this.btnBrowseBackupPath.UseVisualStyleBackColor = false;
            this.btnBrowseBackupPath.Click += new System.EventHandler(this.btnBrowseBackupPath_Click);
            // 
            // grpBackupOptions
            // 
            this.grpBackupOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBackupOptions.BackColor = System.Drawing.Color.White;
            this.grpBackupOptions.Controls.Add(this.chkCompression);
            this.grpBackupOptions.Controls.Add(this.chkVerifyAfterBackup);
            this.grpBackupOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpBackupOptions.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpBackupOptions.Location = new System.Drawing.Point(20, 300);
            this.grpBackupOptions.Name = "grpBackupOptions";
            this.grpBackupOptions.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpBackupOptions.Size = new System.Drawing.Size(1032, 100);
            this.grpBackupOptions.TabIndex = 2;
            this.grpBackupOptions.TabStop = false;
            this.grpBackupOptions.Text = "  ⚙  Opciones  ";
            // 
            // chkCompression
            // 
            this.chkCompression.Checked = true;
            this.chkCompression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompression.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkCompression.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkCompression.Location = new System.Drawing.Point(25, 35);
            this.chkCompression.Name = "chkCompression";
            this.chkCompression.Size = new System.Drawing.Size(200, 24);
            this.chkCompression.TabIndex = 0;
            this.chkCompression.Text = "Usar compresión";
            // 
            // chkVerifyAfterBackup
            // 
            this.chkVerifyAfterBackup.Checked = true;
            this.chkVerifyAfterBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVerifyAfterBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkVerifyAfterBackup.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkVerifyAfterBackup.Location = new System.Drawing.Point(25, 65);
            this.chkVerifyAfterBackup.Name = "chkVerifyAfterBackup";
            this.chkVerifyAfterBackup.Size = new System.Drawing.Size(350, 24);
            this.chkVerifyAfterBackup.TabIndex = 1;
            this.chkVerifyAfterBackup.Text = "Verificar integridad después del backup";
            // 
            // btnExecuteBackup
            // 
            this.btnExecuteBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteBackup.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnExecuteBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecuteBackup.FlatAppearance.BorderSize = 0;
            this.btnExecuteBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnExecuteBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnExecuteBackup.ForeColor = System.Drawing.Color.White;
            this.btnExecuteBackup.Location = new System.Drawing.Point(20, 420);
            this.btnExecuteBackup.Name = "btnExecuteBackup";
            this.btnExecuteBackup.Size = new System.Drawing.Size(1032, 50);
            this.btnExecuteBackup.TabIndex = 3;
            this.btnExecuteBackup.Text = "💾  REALIZAR BACKUP";
            this.btnExecuteBackup.UseVisualStyleBackColor = false;
            this.btnExecuteBackup.Click += new System.EventHandler(this.btnExecuteBackup_Click);
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBackup.Location = new System.Drawing.Point(20, 485);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(1032, 8);
            this.progressBarBackup.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarBackup.TabIndex = 4;
            // 
            // lblBackupStatus
            // 
            this.lblBackupStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackupStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBackupStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBackupStatus.Location = new System.Drawing.Point(20, 500);
            this.lblBackupStatus.Name = "lblBackupStatus";
            this.lblBackupStatus.Size = new System.Drawing.Size(1032, 30);
            this.lblBackupStatus.TabIndex = 5;
            this.lblBackupStatus.Text = "✓  Listo para realizar backup de la base de datos";
            // 
            // ---------------------------------------------------
            // TAB RESTORE
            // ---------------------------------------------------
            // 
            this.tabRestore.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.tabRestore.Controls.Add(this.pnlRestoreHeader);
            this.tabRestore.Controls.Add(this.lblPathRestore);
            this.tabRestore.Controls.Add(this.btnBrowseRestoreFile);
            this.tabRestore.Controls.Add(this.txtRestoreFile);
            this.tabRestore.Controls.Add(this.dgvFileBackups);
            this.tabRestore.Controls.Add(this.btnExecuteRestore);
            this.tabRestore.Controls.Add(this.progressBarRestore);
            this.tabRestore.Controls.Add(this.lblRestoreStatus);
            this.tabRestore.Location = new System.Drawing.Point(4, 40);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(20);
            this.tabRestore.Size = new System.Drawing.Size(1072, 716);
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "  ✦  RESTAURAR  ";
            // 
            // pnlRestoreHeader
            // 
            this.pnlRestoreHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRestoreHeader.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.pnlRestoreHeader.Controls.Add(this.lblRestoreTitle);
            this.pnlRestoreHeader.Controls.Add(this.lblRestoreSubtitle);
            this.pnlRestoreHeader.Location = new System.Drawing.Point(20, 15);
            this.pnlRestoreHeader.Name = "pnlRestoreHeader";
            this.pnlRestoreHeader.Size = new System.Drawing.Size(1032, 80);
            this.pnlRestoreHeader.TabIndex = 0;
            // 
            // lblRestoreTitle
            // 
            this.lblRestoreTitle.AutoSize = true;
            this.lblRestoreTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblRestoreTitle.ForeColor = System.Drawing.Color.White;
            this.lblRestoreTitle.Location = new System.Drawing.Point(20, 12);
            this.lblRestoreTitle.Name = "lblRestoreTitle";
            this.lblRestoreTitle.Size = new System.Drawing.Size(300, 30);
            this.lblRestoreTitle.TabIndex = 0;
            this.lblRestoreTitle.Text = "🔄  Restaurar Base de Datos";
            // 
            // lblRestoreSubtitle
            // 
            this.lblRestoreSubtitle.AutoSize = true;
            this.lblRestoreSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRestoreSubtitle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblRestoreSubtitle.Location = new System.Drawing.Point(22, 48);
            this.lblRestoreSubtitle.Name = "lblRestoreSubtitle";
            this.lblRestoreSubtitle.Size = new System.Drawing.Size(450, 17);
            this.lblRestoreSubtitle.TabIndex = 1;
            this.lblRestoreSubtitle.Text = "Restaure la base de datos desde un archivo de backup existente";
            // 
            // lblPathRestore
            // 
            this.lblPathRestore.AutoSize = true;
            this.lblPathRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPathRestore.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPathRestore.Location = new System.Drawing.Point(20, 115);
            this.lblPathRestore.Name = "lblPathRestore";
            this.lblPathRestore.Size = new System.Drawing.Size(136, 19);
            this.lblPathRestore.TabIndex = 9;
            this.lblPathRestore.Text = "Ruta Archivo .bak:";
            // 
            // btnBrowseRestoreFile
            // 
            this.btnBrowseRestoreFile.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnBrowseRestoreFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseRestoreFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnBrowseRestoreFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnBrowseRestoreFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRestoreFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseRestoreFile.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnBrowseRestoreFile.Location = new System.Drawing.Point(510, 110);
            this.btnBrowseRestoreFile.Name = "btnBrowseRestoreFile";
            this.btnBrowseRestoreFile.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseRestoreFile.TabIndex = 8;
            this.btnBrowseRestoreFile.Text = "📁 Examinar";
            this.btnBrowseRestoreFile.UseVisualStyleBackColor = false;
            this.btnBrowseRestoreFile.Click += new System.EventHandler(this.btnBrowseRestoreFile_Click);
            // 
            // txtRestoreFile
            // 
            this.txtRestoreFile.BackColor = System.Drawing.Color.White;
            this.txtRestoreFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestoreFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRestoreFile.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtRestoreFile.Location = new System.Drawing.Point(170, 112);
            this.txtRestoreFile.Name = "txtRestoreFile";
            this.txtRestoreFile.Size = new System.Drawing.Size(330, 25);
            this.txtRestoreFile.TabIndex = 7;
            // 
            // dgvFileBackups
            // 
            this.dgvFileBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileBackups.BackgroundColor = System.Drawing.Color.White;
            this.dgvFileBackups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFileBackups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFileBackups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dgvFileBackups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFileBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dgvFileBackups.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvFileBackups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFileBackups.EnableHeadersVisualStyles = false;
            this.dgvFileBackups.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvFileBackups.Location = new System.Drawing.Point(20, 195);
            this.dgvFileBackups.Name = "dgvFileBackups";
            this.dgvFileBackups.RowHeadersVisible = false;
            this.dgvFileBackups.RowHeadersWidth = 72;
            this.dgvFileBackups.RowTemplate.Height = 36;
            this.dgvFileBackups.Size = new System.Drawing.Size(1032, 395);
            this.dgvFileBackups.TabIndex = 6;
            // 
            // btnExecuteRestore
            // 
            this.btnExecuteRestore.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnExecuteRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecuteRestore.FlatAppearance.BorderSize = 0;
            this.btnExecuteRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnExecuteRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExecuteRestore.ForeColor = System.Drawing.Color.White;
            this.btnExecuteRestore.Location = new System.Drawing.Point(20, 150);
            this.btnExecuteRestore.Name = "btnExecuteRestore";
            this.btnExecuteRestore.Size = new System.Drawing.Size(240, 40);
            this.btnExecuteRestore.TabIndex = 3;
            this.btnExecuteRestore.Text = "🔄  RESTAURAR BASE DE DATOS";
            this.btnExecuteRestore.UseVisualStyleBackColor = false;
            this.btnExecuteRestore.Click += new System.EventHandler(this.btnExecuteRestore_Click);
            // 
            // progressBarRestore
            // 
            this.progressBarRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRestore.Location = new System.Drawing.Point(20, 600);
            this.progressBarRestore.Name = "progressBarRestore";
            this.progressBarRestore.Size = new System.Drawing.Size(1032, 8);
            this.progressBarRestore.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarRestore.TabIndex = 4;
            // 
            // lblRestoreStatus
            // 
            this.lblRestoreStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRestoreStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRestoreStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRestoreStatus.Location = new System.Drawing.Point(20, 615);
            this.lblRestoreStatus.Name = "lblRestoreStatus";
            this.lblRestoreStatus.Size = new System.Drawing.Size(1032, 30);
            this.lblRestoreStatus.TabIndex = 5;
            this.lblRestoreStatus.Text = "Seleccione un archivo de backup (.bak) para restaurar";
            // 
            // ---------------------------------------------------
            // TAB INTEGRIDAD
            // ---------------------------------------------------
            // 
            this.tabIntegrity.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.tabIntegrity.Controls.Add(this.pnlIntegrityHeader);
            this.tabIntegrity.Controls.Add(this.listBoxIntegrityResults);
            this.tabIntegrity.Controls.Add(this.flowLayoutPanel1);
            this.tabIntegrity.Controls.Add(this.lblIntegrityStatus);
            this.tabIntegrity.Location = new System.Drawing.Point(4, 40);
            this.tabIntegrity.Name = "tabIntegrity";
            this.tabIntegrity.Padding = new System.Windows.Forms.Padding(20);
            this.tabIntegrity.Size = new System.Drawing.Size(1072, 716);
            this.tabIntegrity.TabIndex = 2;
            this.tabIntegrity.Text = "  ✦  INTEGRIDAD  ";
            // 
            // pnlIntegrityHeader
            // 
            this.pnlIntegrityHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIntegrityHeader.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.pnlIntegrityHeader.Controls.Add(this.lblIntegrityTitle);
            this.pnlIntegrityHeader.Controls.Add(this.lblIntegritySubtitle);
            this.pnlIntegrityHeader.Location = new System.Drawing.Point(20, 15);
            this.pnlIntegrityHeader.Name = "pnlIntegrityHeader";
            this.pnlIntegrityHeader.Size = new System.Drawing.Size(1032, 80);
            this.pnlIntegrityHeader.TabIndex = 0;
            // 
            // lblIntegrityTitle
            // 
            this.lblIntegrityTitle.AutoSize = true;
            this.lblIntegrityTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblIntegrityTitle.ForeColor = System.Drawing.Color.White;
            this.lblIntegrityTitle.Location = new System.Drawing.Point(20, 12);
            this.lblIntegrityTitle.Name = "lblIntegrityTitle";
            this.lblIntegrityTitle.Size = new System.Drawing.Size(350, 30);
            this.lblIntegrityTitle.TabIndex = 0;
            this.lblIntegrityTitle.Text = "🛡  Verificación de Integridad";
            // 
            // lblIntegritySubtitle
            // 
            this.lblIntegritySubtitle.AutoSize = true;
            this.lblIntegritySubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIntegritySubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 200, 255);
            this.lblIntegritySubtitle.Location = new System.Drawing.Point(22, 48);
            this.lblIntegritySubtitle.Name = "lblIntegritySubtitle";
            this.lblIntegritySubtitle.Size = new System.Drawing.Size(450, 17);
            this.lblIntegritySubtitle.TabIndex = 1;
            this.lblIntegritySubtitle.Text = "Analice y repare inconsistencias en los dígitos verificadores";
            // 
            // listBoxIntegrityResults
            // 
            this.listBoxIntegrityResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIntegrityResults.BackColor = System.Drawing.Color.White;
            this.listBoxIntegrityResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxIntegrityResults.Font = new System.Drawing.Font("Consolas", 10F);
            this.listBoxIntegrityResults.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.listBoxIntegrityResults.FormattingEnabled = true;
            this.listBoxIntegrityResults.ItemHeight = 15;
            this.listBoxIntegrityResults.Location = new System.Drawing.Point(20, 170);
            this.listBoxIntegrityResults.Name = "listBoxIntegrityResults";
            this.listBoxIntegrityResults.Size = new System.Drawing.Size(1032, 437);
            this.listBoxIntegrityResults.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnCheckIntegrity);
            this.flowLayoutPanel1.Controls.Add(this.btnRecalculateDV);
            this.flowLayoutPanel1.Controls.Add(this.btnRecalculateAllDV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 55);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCheckIntegrity
            // 
            this.btnCheckIntegrity.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnCheckIntegrity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIntegrity.FlatAppearance.BorderSize = 0;
            this.btnCheckIntegrity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 40, 217);
            this.btnCheckIntegrity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIntegrity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckIntegrity.ForeColor = System.Drawing.Color.White;
            this.btnCheckIntegrity.Location = new System.Drawing.Point(3, 3);
            this.btnCheckIntegrity.Name = "btnCheckIntegrity";
            this.btnCheckIntegrity.Size = new System.Drawing.Size(220, 45);
            this.btnCheckIntegrity.TabIndex = 0;
            this.btnCheckIntegrity.Text = "🛡  VERIFICAR INTEGRIDAD";
            this.btnCheckIntegrity.UseVisualStyleBackColor = false;
            this.btnCheckIntegrity.Click += new System.EventHandler(this.btnCheckIntegrity_Click);
            // 
            // btnRecalculateDV
            // 
            this.btnRecalculateDV.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRecalculateDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecalculateDV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRecalculateDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRecalculateDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalculateDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecalculateDV.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRecalculateDV.Location = new System.Drawing.Point(229, 3);
            this.btnRecalculateDV.Name = "btnRecalculateDV";
            this.btnRecalculateDV.Size = new System.Drawing.Size(220, 45);
            this.btnRecalculateDV.TabIndex = 3;
            this.btnRecalculateDV.Text = "RECALCULAR INCONSISTENCIAS";
            this.btnRecalculateDV.UseVisualStyleBackColor = false;
            this.btnRecalculateDV.Visible = false;
            this.btnRecalculateDV.Click += new System.EventHandler(this.btnRecalculateDV_Click);
            // 
            // btnRecalculateAllDV
            // 
            this.btnRecalculateAllDV.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRecalculateAllDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecalculateAllDV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRecalculateAllDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnRecalculateAllDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalculateAllDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecalculateAllDV.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRecalculateAllDV.Location = new System.Drawing.Point(455, 3);
            this.btnRecalculateAllDV.Name = "btnRecalculateAllDV";
            this.btnRecalculateAllDV.Size = new System.Drawing.Size(200, 45);
            this.btnRecalculateAllDV.TabIndex = 4;
            this.btnRecalculateAllDV.Text = "RECALCULAR DV";
            this.btnRecalculateAllDV.UseVisualStyleBackColor = false;
            this.btnRecalculateAllDV.Click += new System.EventHandler(this.btnRecalculateAllDV_Click);
            // 
            // lblIntegrityStatus
            // 
            this.lblIntegrityStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntegrityStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIntegrityStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIntegrityStatus.Location = new System.Drawing.Point(20, 620);
            this.lblIntegrityStatus.Name = "lblIntegrityStatus";
            this.lblIntegrityStatus.Size = new System.Drawing.Size(1032, 30);
            this.lblIntegrityStatus.TabIndex = 2;
            this.lblIntegrityStatus.Text = "Presione el botón para verificar la integridad de la base de datos";
            // 
            // FormDatabaseMaintenance
            // 
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Controls.Add(this.tabControlFormDM);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FormDatabaseMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MANTENIMIENTO DE BASE DE DATOS";
            this.Load += new System.EventHandler(this.FormDatabaseMaintenance_Load);
            this.tabControlFormDM.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.pnlBackupHeader.ResumeLayout(false);
            this.pnlBackupHeader.PerformLayout();
            this.grpBackupDestination.ResumeLayout(false);
            this.grpBackupDestination.PerformLayout();
            this.grpBackupOptions.ResumeLayout(false);
            this.tabRestore.ResumeLayout(false);
            this.tabRestore.PerformLayout();
            this.pnlRestoreHeader.ResumeLayout(false);
            this.pnlRestoreHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileBackups)).EndInit();
            this.tabIntegrity.ResumeLayout(false);
            this.pnlIntegrityHeader.ResumeLayout(false);
            this.pnlIntegrityHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Button btnRecalculateDV;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBoxIntegrityResults;
        private DataGridView dgvFileBackups;
        private Button btnRecalculateAllDV;
        private TextBox txtRestoreFile;
        private Button btnBrowseRestoreFile;
        private Label lblPathRestore;

        private Panel pnlRestoreHeader;
        private Label lblRestoreTitle;
        private Label lblRestoreSubtitle;
        private Panel pnlIntegrityHeader;
        private Label lblIntegrityTitle;
        private Label lblIntegritySubtitle;
    }
}


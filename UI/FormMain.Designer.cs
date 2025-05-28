namespace UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelInterface = new System.Windows.Forms.Panel();
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelDataUser = new System.Windows.Forms.Panel();
            this.photoUser = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lnkMyProfile = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.menuGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnManagerLanguages = new System.Windows.Forms.Button();
            this.btnManageDB = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateHour = new System.Windows.Forms.Timer(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.dropdownMenuReports = new UI.Controls.DropdownMenu(this.components);
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForms.SuspendLayout();
            this.panelInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDataUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUser)).BeginInit();
            this.menuGeneral.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.dropdownMenuReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelForms.Controls.Add(this.panelInterface);
            this.panelForms.Controls.Add(this.panelMenu);
            this.panelForms.Controls.Add(this.panelBarraTitulo);
            resources.ApplyResources(this.panelForms, "panelForms");
            this.panelForms.Name = "panelForms";
            // 
            // panelInterface
            // 
            resources.ApplyResources(this.panelInterface, "panelInterface");
            this.panelInterface.BackColor = System.Drawing.SystemColors.Menu;
            this.panelInterface.Controls.Add(this.guna2ResizeBox1);
            this.panelInterface.Controls.Add(this.guna2CirclePictureBox1);
            this.panelInterface.Name = "panelInterface";
            // 
            // guna2ResizeBox1
            // 
            resources.ApplyResources(this.guna2ResizeBox1, "guna2ResizeBox1");
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.TargetControl = this;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Image = global::UI.Properties.Resources.logo_bss;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panelDataUser);
            this.panelMenu.Controls.Add(this.menuGeneral);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = global::UI.Properties.Resources.icons8_help_48;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLogout.ForeColor = System.Drawing.Color.Silver;
            this.btnLogout.Image = global::UI.Properties.Resources.icons8_logout_20;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelDataUser
            // 
            this.panelDataUser.Controls.Add(this.photoUser);
            this.panelDataUser.Controls.Add(this.lblPosition);
            this.panelDataUser.Controls.Add(this.lnkMyProfile);
            this.panelDataUser.Controls.Add(this.lblName);
            this.panelDataUser.Controls.Add(this.lblEmail);
            resources.ApplyResources(this.panelDataUser, "panelDataUser");
            this.panelDataUser.Name = "panelDataUser";
            // 
            // photoUser
            // 
            this.photoUser.Image = global::UI.Properties.Resources.user_photo_profile;
            resources.ApplyResources(this.photoUser, "photoUser");
            this.photoUser.Name = "photoUser";
            this.photoUser.TabStop = false;
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPosition.Name = "lblPosition";
            // 
            // lnkMyProfile
            // 
            resources.ApplyResources(this.lnkMyProfile, "lnkMyProfile");
            this.lnkMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkMyProfile.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkMyProfile.Name = "lnkMyProfile";
            this.lnkMyProfile.TabStop = true;
            this.lnkMyProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMyProfile_LinkClicked);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Name = "lblName";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Name = "lblEmail";
            // 
            // menuGeneral
            // 
            resources.ApplyResources(this.menuGeneral, "menuGeneral");
            this.menuGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.menuGeneral.Controls.Add(this.btnProducts);
            this.menuGeneral.Controls.Add(this.btnCreateSale);
            this.menuGeneral.Controls.Add(this.btnOrders);
            this.menuGeneral.Controls.Add(this.btnReports);
            this.menuGeneral.Controls.Add(this.btnUsers);
            this.menuGeneral.Controls.Add(this.btnEmployees);
            this.menuGeneral.Controls.Add(this.btnClients);
            this.menuGeneral.Controls.Add(this.btnProfiles);
            this.menuGeneral.Controls.Add(this.btnManagerLanguages);
            this.menuGeneral.Controls.Add(this.btnManageDB);
            this.menuGeneral.Name = "menuGeneral";
            // 
            // btnProducts
            // 
            resources.ApplyResources(this.btnProducts, "btnProducts");
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnProducts.ForeColor = System.Drawing.Color.Silver;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Tag = "PL002";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCreateSale
            // 
            resources.ApplyResources(this.btnCreateSale, "btnCreateSale");
            this.btnCreateSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnCreateSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSale.FlatAppearance.BorderSize = 0;
            this.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCreateSale.ForeColor = System.Drawing.Color.Silver;
            this.btnCreateSale.Image = global::UI.Properties.Resources.shop_store_business_sale_supermarket_icon_175937;
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.UseVisualStyleBackColor = false;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // btnOrders
            // 
            resources.ApplyResources(this.btnOrders, "btnOrders");
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnOrders.ForeColor = System.Drawing.Color.Silver;
            this.btnOrders.Image = global::UI.Properties.Resources.icons8_forklift_48;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Tag = "PR004";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnReports
            // 
            resources.ApplyResources(this.btnReports, "btnReports");
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReports.ForeColor = System.Drawing.Color.Silver;
            this.btnReports.Image = global::UI.Properties.Resources.icons8_report_48;
            this.btnReports.Name = "btnReports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnUsers.ForeColor = System.Drawing.Color.Silver;
            this.btnUsers.Image = global::UI.Properties.Resources.manager_icon_150030;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Tag = "PL004";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnEmployees
            // 
            resources.ApplyResources(this.btnEmployees, "btnEmployees");
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEmployees.ForeColor = System.Drawing.Color.Silver;
            this.btnEmployees.Image = global::UI.Properties.Resources.manager_icon_150030;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Tag = "PL004";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnClients
            // 
            resources.ApplyResources(this.btnClients, "btnClients");
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClients.ForeColor = System.Drawing.Color.Silver;
            this.btnClients.Image = global::UI.Properties.Resources.manager_icon_150030;
            this.btnClients.Name = "btnClients";
            this.btnClients.Tag = "PL004";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnProfiles
            // 
            resources.ApplyResources(this.btnProfiles, "btnProfiles");
            this.btnProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnProfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnProfiles.ForeColor = System.Drawing.Color.Silver;
            this.btnProfiles.Image = global::UI.Properties.Resources.employee_icon;
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Tag = "PL008";
            this.btnProfiles.UseVisualStyleBackColor = false;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // btnManagerLanguages
            // 
            resources.ApplyResources(this.btnManagerLanguages, "btnManagerLanguages");
            this.btnManagerLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnManagerLanguages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagerLanguages.FlatAppearance.BorderSize = 0;
            this.btnManagerLanguages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnManagerLanguages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnManagerLanguages.ForeColor = System.Drawing.Color.Silver;
            this.btnManagerLanguages.Name = "btnManagerLanguages";
            this.btnManagerLanguages.UseVisualStyleBackColor = false;
            this.btnManagerLanguages.Click += new System.EventHandler(this.btnManagerLanguages_Click);
            // 
            // btnManageDB
            // 
            resources.ApplyResources(this.btnManageDB, "btnManageDB");
            this.btnManageDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.btnManageDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDB.FlatAppearance.BorderSize = 0;
            this.btnManageDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnManageDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnManageDB.ForeColor = System.Drawing.Color.Silver;
            this.btnManageDB.Name = "btnManageDB";
            this.btnManageDB.UseVisualStyleBackColor = false;
            this.btnManageDB.Click += new System.EventHandler(this.btnManageDB_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.panelBarraTitulo.Controls.Add(this.nightControlBox1);
            this.panelBarraTitulo.Controls.Add(this.lblDateTime);
            resources.ApplyResources(this.panelBarraTitulo, "panelBarraTitulo");
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // nightControlBox1
            // 
            resources.ApplyResources(this.nightControlBox1, "nightControlBox1");
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            // 
            // lblDateTime
            // 
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDateTime.Name = "lblDateTime";
            // 
            // timerDateHour
            // 
            this.timerDateHour.Tick += new System.EventHandler(this.timerDateHour_Tick);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // dropdownMenuReports
            // 
            this.dropdownMenuReports.IsMainMenu = false;
            this.dropdownMenuReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporte1ToolStripMenuItem,
            this.reporte2ToolStripMenuItem,
            this.reporte3ToolStripMenuItem});
            this.dropdownMenuReports.MenuItemHeight = 25;
            this.dropdownMenuReports.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropdownMenuReports.Name = "dropdownMenuReports";
            this.dropdownMenuReports.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            resources.ApplyResources(this.dropdownMenuReports, "dropdownMenuReports");
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            resources.ApplyResources(this.reporte1ToolStripMenuItem, "reporte1ToolStripMenuItem");
            // 
            // reporte2ToolStripMenuItem
            // 
            this.reporte2ToolStripMenuItem.Name = "reporte2ToolStripMenuItem";
            resources.ApplyResources(this.reporte2ToolStripMenuItem, "reporte2ToolStripMenuItem");
            // 
            // reporte3ToolStripMenuItem
            // 
            this.reporte3ToolStripMenuItem.Name = "reporte3ToolStripMenuItem";
            resources.ApplyResources(this.reporte3ToolStripMenuItem, "reporte3ToolStripMenuItem");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.panelForms);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            this.panelInterface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelDataUser.ResumeLayout(false);
            this.panelDataUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUser)).EndInit();
            this.menuGeneral.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.dropdownMenuReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panelInterface;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox photoUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.LinkLabel lnkMyProfile;
        private System.Windows.Forms.Timer timerDateHour;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnManagerLanguages;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.FlowLayoutPanel menuGeneral;
        private System.Windows.Forms.Panel panelDataUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
        private Controls.DropdownMenu dropdownMenuReports;
        private System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte3ToolStripMenuItem;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnManageDB;
    }
}
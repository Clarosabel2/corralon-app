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
            this.btnClients = new System.Windows.Forms.Button();
            this.menuVentas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.menuOperador = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOperator = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnRegisterOrder = new System.Windows.Forms.Button();
            this.menuReportes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReport1 = new System.Windows.Forms.Button();
            this.btnReport2 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.menuUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.menuAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnManagerLanguages = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerDateHour = new System.Windows.Forms.Timer(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.panelForms.SuspendLayout();
            this.panelInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDataUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoUser)).BeginInit();
            this.menuGeneral.SuspendLayout();
            this.menuVentas.SuspendLayout();
            this.menuOperador.SuspendLayout();
            this.menuReportes.SuspendLayout();
            this.menuUsuario.SuspendLayout();
            this.menuAdmin.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
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
            this.menuGeneral.Controls.Add(this.btnClients);
            this.menuGeneral.Controls.Add(this.menuVentas);
            this.menuGeneral.Controls.Add(this.menuOperador);
            this.menuGeneral.Controls.Add(this.menuReportes);
            this.menuGeneral.Controls.Add(this.menuUsuario);
            this.menuGeneral.Controls.Add(this.menuAdmin);
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
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
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
            this.btnClients.Name = "btnClients";
            this.btnClients.UseVisualStyleBackColor = false;
            // 
            // menuVentas
            // 
            this.menuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.menuVentas.Controls.Add(this.btnSales);
            this.menuVentas.Controls.Add(this.btnCreateSale);
            resources.ApplyResources(this.menuVentas, "menuVentas");
            this.menuVentas.Name = "menuVentas";
            // 
            // btnSales
            // 
            resources.ApplyResources(this.btnSales, "btnSales");
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSales.ForeColor = System.Drawing.Color.Silver;
            this.btnSales.Name = "btnSales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCreateSale
            // 
            resources.ApplyResources(this.btnCreateSale, "btnCreateSale");
            this.btnCreateSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnCreateSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSale.FlatAppearance.BorderSize = 0;
            this.btnCreateSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCreateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCreateSale.ForeColor = System.Drawing.Color.Silver;
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.UseVisualStyleBackColor = false;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // menuOperador
            // 
            this.menuOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.menuOperador.Controls.Add(this.btnOperator);
            this.menuOperador.Controls.Add(this.btnOrders);
            this.menuOperador.Controls.Add(this.btnRegisterOrder);
            resources.ApplyResources(this.menuOperador, "menuOperador");
            this.menuOperador.Name = "menuOperador";
            // 
            // btnOperator
            // 
            resources.ApplyResources(this.btnOperator, "btnOperator");
            this.btnOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperator.FlatAppearance.BorderSize = 0;
            this.btnOperator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnOperator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnOperator.ForeColor = System.Drawing.Color.Silver;
            this.btnOperator.Name = "btnOperator";
            this.btnOperator.UseVisualStyleBackColor = false;
            this.btnOperator.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnOrders
            // 
            resources.ApplyResources(this.btnOrders, "btnOrders");
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnOrders.ForeColor = System.Drawing.Color.Silver;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnRegisterOrder
            // 
            resources.ApplyResources(this.btnRegisterOrder, "btnRegisterOrder");
            this.btnRegisterOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnRegisterOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterOrder.FlatAppearance.BorderSize = 0;
            this.btnRegisterOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnRegisterOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnRegisterOrder.ForeColor = System.Drawing.Color.Silver;
            this.btnRegisterOrder.Name = "btnRegisterOrder";
            this.btnRegisterOrder.UseVisualStyleBackColor = false;
            // 
            // menuReportes
            // 
            this.menuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.menuReportes.Controls.Add(this.btnReport);
            this.menuReportes.Controls.Add(this.btnReport1);
            this.menuReportes.Controls.Add(this.btnReport2);
            this.menuReportes.Controls.Add(this.btnReport3);
            resources.ApplyResources(this.menuReportes, "menuReportes");
            this.menuReportes.Name = "menuReportes";
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReport.ForeColor = System.Drawing.Color.Silver;
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnReport1
            // 
            resources.ApplyResources(this.btnReport1, "btnReport1");
            this.btnReport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnReport1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport1.FlatAppearance.BorderSize = 0;
            this.btnReport1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReport1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReport1.ForeColor = System.Drawing.Color.Silver;
            this.btnReport1.Name = "btnReport1";
            this.btnReport1.UseVisualStyleBackColor = false;
            // 
            // btnReport2
            // 
            resources.ApplyResources(this.btnReport2, "btnReport2");
            this.btnReport2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnReport2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport2.FlatAppearance.BorderSize = 0;
            this.btnReport2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReport2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReport2.ForeColor = System.Drawing.Color.Silver;
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.UseVisualStyleBackColor = false;
            // 
            // btnReport3
            // 
            resources.ApplyResources(this.btnReport3, "btnReport3");
            this.btnReport3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnReport3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport3.FlatAppearance.BorderSize = 0;
            this.btnReport3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnReport3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnReport3.ForeColor = System.Drawing.Color.Silver;
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.UseVisualStyleBackColor = false;
            // 
            // menuUsuario
            // 
            this.menuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.menuUsuario.Controls.Add(this.btnUser);
            this.menuUsuario.Controls.Add(this.btnMyAccount);
            this.menuUsuario.Controls.Add(this.btnLanguage);
            this.menuUsuario.Controls.Add(this.btnSecurity);
            resources.ApplyResources(this.menuUsuario, "menuUsuario");
            this.menuUsuario.Name = "menuUsuario";
            // 
            // btnUser
            // 
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnUser.ForeColor = System.Drawing.Color.Silver;
            this.btnUser.Name = "btnUser";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMyAccount
            // 
            resources.ApplyResources(this.btnMyAccount, "btnMyAccount");
            this.btnMyAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyAccount.FlatAppearance.BorderSize = 0;
            this.btnMyAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMyAccount.ForeColor = System.Drawing.Color.Silver;
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            // 
            // btnLanguage
            // 
            resources.ApplyResources(this.btnLanguage, "btnLanguage");
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLanguage.ForeColor = System.Drawing.Color.Silver;
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.UseVisualStyleBackColor = false;
            // 
            // btnSecurity
            // 
            resources.ApplyResources(this.btnSecurity, "btnSecurity");
            this.btnSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSecurity.ForeColor = System.Drawing.Color.Silver;
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.UseVisualStyleBackColor = false;
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.menuAdmin.Controls.Add(this.btnAdmin);
            this.menuAdmin.Controls.Add(this.btnManagerLanguages);
            this.menuAdmin.Controls.Add(this.btnProfiles);
            resources.ApplyResources(this.menuAdmin, "menuAdmin");
            this.menuAdmin.Name = "menuAdmin";
            // 
            // btnAdmin
            // 
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnAdmin.ForeColor = System.Drawing.Color.Silver;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnManagerLanguages
            // 
            resources.ApplyResources(this.btnManagerLanguages, "btnManagerLanguages");
            this.btnManagerLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnManagerLanguages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagerLanguages.FlatAppearance.BorderSize = 0;
            this.btnManagerLanguages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnManagerLanguages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnManagerLanguages.ForeColor = System.Drawing.Color.Silver;
            this.btnManagerLanguages.Name = "btnManagerLanguages";
            this.btnManagerLanguages.UseVisualStyleBackColor = false;
            // 
            // btnProfiles
            // 
            resources.ApplyResources(this.btnProfiles, "btnProfiles");
            this.btnProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.btnProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnProfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnProfiles.ForeColor = System.Drawing.Color.Silver;
            this.btnProfiles.Image = global::UI.Properties.Resources.employee_icon;
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
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
            this.timerDateHour.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
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
            this.TopMost = true;
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
            this.menuVentas.ResumeLayout(false);
            this.menuOperador.ResumeLayout(false);
            this.menuReportes.ResumeLayout(false);
            this.menuUsuario.ResumeLayout(false);
            this.menuAdmin.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel menuVentas;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.FlowLayoutPanel menuUsuario;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.FlowLayoutPanel menuOperador;
        private System.Windows.Forms.Button btnOperator;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnRegisterOrder;
        private System.Windows.Forms.FlowLayoutPanel menuAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnManagerLanguages;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.FlowLayoutPanel menuReportes;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReport1;
        private System.Windows.Forms.Button btnReport2;
        private System.Windows.Forms.Button btnReport3;
        private System.Windows.Forms.FlowLayoutPanel menuGeneral;
        private System.Windows.Forms.Panel panelDataUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
    }
}
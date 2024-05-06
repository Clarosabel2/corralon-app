namespace UI
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelInterface = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnChangeLenguage = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lnkMyProfile = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panelForms.SuspendLayout();
            this.panelInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            this.panelInterface.BackColor = System.Drawing.SystemColors.Menu;
            this.panelInterface.Controls.Add(this.pictureBoxLogo);
            resources.ApplyResources(this.panelInterface, "panelInterface");
            this.panelInterface.Name = "panelInterface";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UI.Properties.Resources.logo_bss;
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnChangeLenguage);
            this.panelMenu.Controls.Add(this.btn1);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btn2);
            this.panelMenu.Controls.Add(this.lnkMyProfile);
            this.panelMenu.Controls.Add(this.lblEmail);
            this.panelMenu.Controls.Add(this.lblName);
            this.panelMenu.Controls.Add(this.lblPosition);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnLogout);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnChangeLenguage
            // 
            this.btnChangeLenguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChangeLenguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeLenguage.FlatAppearance.BorderSize = 0;
            this.btnChangeLenguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnChangeLenguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnChangeLenguage, "btnChangeLenguage");
            this.btnChangeLenguage.ForeColor = System.Drawing.Color.LightGray;
            this.btnChangeLenguage.Name = "btnChangeLenguage";
            this.btnChangeLenguage.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.ForeColor = System.Drawing.Color.Silver;
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.ForeColor = System.Drawing.Color.Silver;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.ForeColor = System.Drawing.Color.Silver;
            this.btn2.Name = "btn2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // lnkMyProfile
            // 
            resources.ApplyResources(this.lnkMyProfile, "lnkMyProfile");
            this.lnkMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkMyProfile.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkMyProfile.Name = "lnkMyProfile";
            this.lnkMyProfile.TabStop = true;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Name = "lblEmail";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Name = "lblName";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPosition.Name = "lblPosition";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.alexander_hipp_iEEBWgY_6lA_unsplash;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLogout.ForeColor = System.Drawing.Color.Silver;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.panelBarraTitulo.Controls.Add(this.lblDateTime);
            this.panelBarraTitulo.Controls.Add(this.btnMinimized);
            this.panelBarraTitulo.Controls.Add(this.btnReset);
            this.panelBarraTitulo.Controls.Add(this.btnMaximized);
            this.panelBarraTitulo.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panelBarraTitulo, "panelBarraTitulo");
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            // 
            // lblDateTime
            // 
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDateTime.Name = "lblDateTime";
            // 
            // btnMinimized
            // 
            resources.ApplyResources(this.btnMinimized, "btnMinimized");
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = global::UI.Properties.Resources.minus_111123;
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::UI.Properties.Resources._1492790945_39minimize_84242;
            this.btnReset.Name = "btnReset";
            this.btnReset.TabStop = false;
            // 
            // btnMaximized
            // 
            resources.ApplyResources(this.btnMaximized, "btnMaximized");
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::UI.Properties.Resources._4115230_cancel_close_cross_delete_114048;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelForms.ResumeLayout(false);
            this.panelInterface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panelInterface;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.LinkLabel lnkMyProfile;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnChangeLenguage;
        private System.Windows.Forms.Timer timerDate;
    }
}


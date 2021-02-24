
namespace PassGuard
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.GeneratePasswordBtn = new System.Windows.Forms.Button();
            this.PasswordsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.STrayManager = new System.Windows.Forms.NotifyIcon(this.components);
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            resources.ApplyResources(this.Sidebar, "Sidebar");
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.Sidebar.Controls.Add(this.settingsBtn);
            this.Sidebar.Controls.Add(this.AboutBtn);
            this.Sidebar.Controls.Add(this.GeneratePasswordBtn);
            this.Sidebar.Controls.Add(this.PasswordsBtn);
            this.Sidebar.Controls.Add(this.HomeBtn);
            this.Sidebar.Controls.Add(this.Logo);
            this.Sidebar.Name = "Sidebar";
            // 
            // settingsBtn
            // 
            resources.ApplyResources(this.settingsBtn, "settingsBtn");
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.Image = global::PassGuard.Properties.Resources.settings;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AboutBtn, "AboutBtn");
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.About_Click);
            // 
            // GeneratePasswordBtn
            // 
            this.GeneratePasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.GeneratePasswordBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.GeneratePasswordBtn, "GeneratePasswordBtn");
            this.GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            this.GeneratePasswordBtn.UseVisualStyleBackColor = false;
            this.GeneratePasswordBtn.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // PasswordsBtn
            // 
            this.PasswordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.PasswordsBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PasswordsBtn, "PasswordsBtn");
            this.PasswordsBtn.Name = "PasswordsBtn";
            this.PasswordsBtn.UseVisualStyleBackColor = false;
            this.PasswordsBtn.Click += new System.EventHandler(this.Passwords_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HomeBtn, "HomeBtn");
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.Home_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::PassGuard.Properties.Resources.logo_white_small;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // Content
            // 
            resources.ApplyResources(this.Content, "Content");
            this.Content.BackColor = System.Drawing.Color.Transparent;
            this.Content.Name = "Content";
            // 
            // STrayManager
            // 
            resources.ApplyResources(this.STrayManager, "STrayManager");
            this.STrayManager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.STrayManager_MouseDown);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Sidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button PasswordsBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button GeneratePasswordBtn;
        private System.Windows.Forms.Button settingsBtn;
        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.NotifyIcon STrayManager;
    }
}



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.Passwords = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            resources.ApplyResources(this.Sidebar, "Sidebar");
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.Sidebar.Controls.Add(this.settingsBtn);
            this.Sidebar.Controls.Add(this.About);
            this.Sidebar.Controls.Add(this.GeneratePassword);
            this.Sidebar.Controls.Add(this.Passwords);
            this.Sidebar.Controls.Add(this.Home);
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
            // About
            // 
            this.About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.About.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.About, "About");
            this.About.Name = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.GeneratePassword.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.GeneratePassword, "GeneratePassword");
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.UseVisualStyleBackColor = false;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // Passwords
            // 
            this.Passwords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Passwords.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Passwords, "Passwords");
            this.Passwords.Name = "Passwords";
            this.Passwords.UseVisualStyleBackColor = false;
            this.Passwords.Click += new System.EventHandler(this.Passwords_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Home.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Home, "Home");
            this.Home.Name = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Logo
            // 
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
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Sidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Passwords;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.Button settingsBtn;
        public System.Windows.Forms.Panel Content;
    }
}


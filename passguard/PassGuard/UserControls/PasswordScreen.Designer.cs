
namespace PassGuard.UserControls
{
    partial class PasswordScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.PasswordNameTB = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(30, 397);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 28);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.BorderSize = 0;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeButton.Location = new System.Drawing.Point(145, 180);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(79, 28);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Change";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.urlTB);
            this.panel3.Location = new System.Drawing.Point(30, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 28);
            this.panel3.TabIndex = 11;
            // 
            // urlTB
            // 
            this.urlTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.urlTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.urlTB.Location = new System.Drawing.Point(3, 7);
            this.urlTB.Name = "urlTB";
            this.urlTB.ReadOnly = true;
            this.urlTB.Size = new System.Drawing.Size(576, 14);
            this.urlTB.TabIndex = 2;
            this.urlTB.Text = "URL...";
            this.urlTB.Leave += new System.EventHandler(this.urlTB_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.passwordTB);
            this.panel2.Location = new System.Drawing.Point(145, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 28);
            this.panel2.TabIndex = 10;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.Location = new System.Drawing.Point(3, 7);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(461, 14);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.Text = "Password";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 17.7F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(23, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(129, 30);
            this.title.TabIndex = 8;
            this.title.Text = "Password:";
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.showPassword.FlatAppearance.BorderSize = 0;
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.White;
            this.showPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.showPassword.Location = new System.Drawing.Point(30, 78);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(100, 28);
            this.showPassword.TabIndex = 15;
            this.showPassword.Text = "Show Password";
            this.showPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showPassword.UseVisualStyleBackColor = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.editButton.BackgroundImage = global::PassGuard.Properties.Resources.edit;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.editButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editButton.Location = new System.Drawing.Point(590, 24);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(21, 21);
            this.editButton.TabIndex = 16;
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.icon.Location = new System.Drawing.Point(30, 180);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(100, 100);
            this.icon.TabIndex = 12;
            this.icon.TabStop = false;
            // 
            // PasswordNameTB
            // 
            this.PasswordNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.PasswordNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordNameTB.Font = new System.Drawing.Font("Century Gothic", 17.7F);
            this.PasswordNameTB.ForeColor = System.Drawing.Color.White;
            this.PasswordNameTB.Location = new System.Drawing.Point(153, 20);
            this.PasswordNameTB.Name = "PasswordNameTB";
            this.PasswordNameTB.Size = new System.Drawing.Size(38, 29);
            this.PasswordNameTB.TabIndex = 17;
            this.PasswordNameTB.Text = "YO";
            this.PasswordNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordNameTB.TextChanged += new System.EventHandler(this.PasswordNameTB_TextChanged);
            this.PasswordNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordNameTB_KeyDown);
            // 
            // PasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.PasswordNameTB);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title);
            this.Name = "PasswordScreen";
            this.Size = new System.Drawing.Size(640, 450);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button showPassword;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox PasswordNameTB;
    }
}

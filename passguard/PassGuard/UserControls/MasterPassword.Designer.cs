namespace PassGuard.UserControls
{
    partial class MasterPassword
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
            this.MasterPasswordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.WrongPasswordLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MasterPasswordTB
            // 
            this.MasterPasswordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasterPasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.MasterPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MasterPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MasterPasswordTB.ForeColor = System.Drawing.Color.White;
            this.MasterPasswordTB.Location = new System.Drawing.Point(197, 254);
            this.MasterPasswordTB.Name = "MasterPasswordTB";
            this.MasterPasswordTB.PasswordChar = '*';
            this.MasterPasswordTB.Size = new System.Drawing.Size(242, 16);
            this.MasterPasswordTB.TabIndex = 8;
            this.MasterPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter your master password:";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 17.7F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(218, 154);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(205, 30);
            this.title.TabIndex = 6;
            this.title.Text = "Welcome back!";
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.goButton.ForeColor = System.Drawing.Color.White;
            this.goButton.Location = new System.Drawing.Point(257, 294);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(123, 28);
            this.goButton.TabIndex = 9;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // WrongPasswordLB
            // 
            this.WrongPasswordLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WrongPasswordLB.AutoSize = true;
            this.WrongPasswordLB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongPasswordLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(100)))));
            this.WrongPasswordLB.Location = new System.Drawing.Point(193, 274);
            this.WrongPasswordLB.Name = "WrongPasswordLB";
            this.WrongPasswordLB.Size = new System.Drawing.Size(118, 16);
            this.WrongPasswordLB.TabIndex = 10;
            this.WrongPasswordLB.Text = "Password is incorrect";
            this.WrongPasswordLB.Visible = false;
            // 
            // MasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.WrongPasswordLB);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.MasterPasswordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "MasterPassword";
            this.Size = new System.Drawing.Size(640, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MasterPasswordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label WrongPasswordLB;
    }
}

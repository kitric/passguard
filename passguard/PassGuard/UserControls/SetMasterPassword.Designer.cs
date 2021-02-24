namespace PassGuard.UserControls
{
    partial class SetMasterPassword
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MasterPasswordTB = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 17.7F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(172, 154);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(293, 30);
            this.title.TabIndex = 2;
            this.title.Text = "Welcome to PassGuard";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set a master password:";
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
            this.MasterPasswordTB.TabIndex = 5;
            this.MasterPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.goButton.ForeColor = System.Drawing.Color.White;
            this.goButton.Location = new System.Drawing.Point(257, 288);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(123, 28);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // SetMasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.MasterPasswordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "SetMasterPassword";
            this.Size = new System.Drawing.Size(640, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MasterPasswordTB;
        private System.Windows.Forms.Button goButton;
    }
}

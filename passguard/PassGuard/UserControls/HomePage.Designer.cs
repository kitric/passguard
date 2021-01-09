
namespace PassGuard.UserControls
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.YourPasswords = new System.Windows.Forms.Button();
            this.GenerateAPassword = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pwtBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pwtBig)).BeginInit();
            this.SuspendLayout();
            // 
            // YourPasswords
            // 
            this.YourPasswords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YourPasswords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.YourPasswords.FlatAppearance.BorderSize = 0;
            this.YourPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YourPasswords.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.YourPasswords.ForeColor = System.Drawing.Color.White;
            this.YourPasswords.Location = new System.Drawing.Point(190, 300);
            this.YourPasswords.Name = "YourPasswords";
            this.YourPasswords.Size = new System.Drawing.Size(123, 28);
            this.YourPasswords.TabIndex = 1;
            this.YourPasswords.Text = "Your Passwords";
            this.YourPasswords.UseVisualStyleBackColor = false;
            this.YourPasswords.Click += new System.EventHandler(this.YourPasswords_Click);
            // 
            // GenerateAPassword
            // 
            this.GenerateAPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateAPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.GenerateAPassword.FlatAppearance.BorderSize = 0;
            this.GenerateAPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateAPassword.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.GenerateAPassword.ForeColor = System.Drawing.Color.White;
            this.GenerateAPassword.Location = new System.Drawing.Point(329, 300);
            this.GenerateAPassword.Name = "GenerateAPassword";
            this.GenerateAPassword.Size = new System.Drawing.Size(123, 28);
            this.GenerateAPassword.TabIndex = 2;
            this.GenerateAPassword.Text = "Generate a Password";
            this.GenerateAPassword.UseVisualStyleBackColor = false;
            this.GenerateAPassword.Click += new System.EventHandler(this.GenerateAPassword_Click);
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(0, 421);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(640, 21);
            this.Time.TabIndex = 3;
            this.Time.Text = "time";
            this.Time.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 800;
            // 
            // pwtBig
            // 
            this.pwtBig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwtBig.Image = global::PassGuard.Properties.Resources.homeScreenImage;
            this.pwtBig.Location = new System.Drawing.Point(219, 122);
            this.pwtBig.Name = "pwtBig";
            this.pwtBig.Size = new System.Drawing.Size(201, 131);
            this.pwtBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pwtBig.TabIndex = 0;
            this.pwtBig.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.Time);
            this.Controls.Add(this.GenerateAPassword);
            this.Controls.Add(this.YourPasswords);
            this.Controls.Add(this.pwtBig);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(640, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pwtBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pwtBig;
        private System.Windows.Forms.Button YourPasswords;
        private System.Windows.Forms.Button GenerateAPassword;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer Timer;
    }
}

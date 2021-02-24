
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
            this.YourPasswordsBtn = new System.Windows.Forms.Button();
            this.GenerateAPasswordBtn = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pwtBig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pwtBig)).BeginInit();
            this.SuspendLayout();
            // 
            // YourPasswordsBtn
            // 
            this.YourPasswordsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YourPasswordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.YourPasswordsBtn.FlatAppearance.BorderSize = 0;
            this.YourPasswordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YourPasswordsBtn.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.YourPasswordsBtn.ForeColor = System.Drawing.Color.White;
            this.YourPasswordsBtn.Location = new System.Drawing.Point(190, 300);
            this.YourPasswordsBtn.Name = "YourPasswordsBtn";
            this.YourPasswordsBtn.Size = new System.Drawing.Size(123, 28);
            this.YourPasswordsBtn.TabIndex = 1;
            this.YourPasswordsBtn.Text = "Your Passwords";
            this.YourPasswordsBtn.UseVisualStyleBackColor = false;
            this.YourPasswordsBtn.Click += new System.EventHandler(this.YourPasswords_Click);
            // 
            // GenerateAPasswordBtn
            // 
            this.GenerateAPasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateAPasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.GenerateAPasswordBtn.FlatAppearance.BorderSize = 0;
            this.GenerateAPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateAPasswordBtn.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.GenerateAPasswordBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateAPasswordBtn.Location = new System.Drawing.Point(329, 300);
            this.GenerateAPasswordBtn.Name = "GenerateAPasswordBtn";
            this.GenerateAPasswordBtn.Size = new System.Drawing.Size(123, 28);
            this.GenerateAPasswordBtn.TabIndex = 2;
            this.GenerateAPasswordBtn.Text = "Generate a Password";
            this.GenerateAPasswordBtn.UseVisualStyleBackColor = false;
            this.GenerateAPasswordBtn.Click += new System.EventHandler(this.GenerateAPassword_Click);
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
            this.Timer.Tick += new System.EventHandler(this.UpdateTime);
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
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Time);
            this.Controls.Add(this.GenerateAPasswordBtn);
            this.Controls.Add(this.YourPasswordsBtn);
            this.Controls.Add(this.pwtBig);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(640, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pwtBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pwtBig;
        private System.Windows.Forms.Button YourPasswordsBtn;
        private System.Windows.Forms.Button GenerateAPasswordBtn;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer Timer;
    }
}

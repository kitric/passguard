namespace PassGuard.UserControls
{
    partial class About
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crxssed = new System.Windows.Forms.Button();
            this.nordic = new System.Windows.Forms.Button();
            this.website = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spacer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::PassGuard.Properties.Resources.kitric_text;
            this.pictureBox1.Location = new System.Drawing.Point(255, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // crxssed
            // 
            this.crxssed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crxssed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.crxssed.FlatAppearance.BorderSize = 0;
            this.crxssed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crxssed.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.crxssed.Image = global::PassGuard.Properties.Resources.crxssed;
            this.crxssed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.crxssed.Location = new System.Drawing.Point(206, 98);
            this.crxssed.Name = "crxssed";
            this.crxssed.Size = new System.Drawing.Size(114, 126);
            this.crxssed.TabIndex = 3;
            this.crxssed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crxssed.UseVisualStyleBackColor = false;
            this.crxssed.Click += new System.EventHandler(this.crxssed_Click);
            // 
            // nordic
            // 
            this.nordic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nordic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.nordic.FlatAppearance.BorderSize = 0;
            this.nordic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nordic.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.nordic.Image = global::PassGuard.Properties.Resources.nordic;
            this.nordic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nordic.Location = new System.Drawing.Point(320, 98);
            this.nordic.Name = "nordic";
            this.nordic.Size = new System.Drawing.Size(114, 126);
            this.nordic.TabIndex = 4;
            this.nordic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nordic.UseVisualStyleBackColor = false;
            this.nordic.Click += new System.EventHandler(this.nordic_Click);
            // 
            // website
            // 
            this.website.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.website.FlatAppearance.BorderSize = 0;
            this.website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.website.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.website.ForeColor = System.Drawing.Color.White;
            this.website.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.website.Location = new System.Drawing.Point(246, 264);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(148, 28);
            this.website.TabIndex = 5;
            this.website.Text = "Visit our website!";
            this.website.UseVisualStyleBackColor = false;
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::PassGuard.Properties.Resources.pw_text;
            this.pictureBox2.Location = new System.Drawing.Point(219, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 30);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 124);
            this.label1.TabIndex = 7;
            this.label1.Text = "PassGuard is a simple password manager made for those who want to keep their pass" +
    "words safe.\r\nThe project is open-source and is available\r\non the Kitric Github p" +
    "age.\r\n\r\nv0.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacer
            // 
            this.spacer.Location = new System.Drawing.Point(0, 524);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(621, 38);
            this.spacer.TabIndex = 8;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.spacer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.website);
            this.Controls.Add(this.nordic);
            this.Controls.Add(this.crxssed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "About";
            this.Size = new System.Drawing.Size(640, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button crxssed;
        private System.Windows.Forms.Button nordic;
        private System.Windows.Forms.Button website;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel spacer;
    }
}

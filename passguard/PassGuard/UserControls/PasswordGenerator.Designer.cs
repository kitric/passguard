
namespace PassGuard.UserControls
{
    partial class PasswordGenerator
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
            this.generate = new System.Windows.Forms.Button();
            this.generatedPassTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PassGuard.Properties.Resources.password_gen;
            this.pictureBox1.Location = new System.Drawing.Point(126, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // generate
            // 
            this.generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.generate.FlatAppearance.BorderSize = 0;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.generate.ForeColor = System.Drawing.Color.White;
            this.generate.Location = new System.Drawing.Point(259, 261);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(123, 28);
            this.generate.TabIndex = 5;
            this.generate.Text = "GENERATE!";
            this.generate.UseVisualStyleBackColor = false;
            // 
            // generatedPassTB
            // 
            this.generatedPassTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generatedPassTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.generatedPassTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generatedPassTB.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.generatedPassTB.ForeColor = System.Drawing.Color.White;
            this.generatedPassTB.Location = new System.Drawing.Point(3, 329);
            this.generatedPassTB.Name = "generatedPassTB";
            this.generatedPassTB.ReadOnly = true;
            this.generatedPassTB.Size = new System.Drawing.Size(634, 30);
            this.generatedPassTB.TabIndex = 6;
            this.generatedPassTB.Text = "[password]";
            this.generatedPassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.generatedPassTB);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PasswordGenerator";
            this.Size = new System.Drawing.Size(640, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox generatedPassTB;
    }
}

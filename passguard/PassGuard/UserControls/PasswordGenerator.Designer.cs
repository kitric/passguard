﻿
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.generatedPassTB = new System.Windows.Forms.TextBox();
            this.genLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.genLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(259, 261);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(123, 28);
            this.generateBtn.TabIndex = 5;
            this.generateBtn.Text = "GENERATE!";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generate_Click);
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
            // genLogo
            // 
            this.genLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genLogo.Image = global::PassGuard.Properties.Resources.password_gen;
            this.genLogo.Location = new System.Drawing.Point(126, 85);
            this.genLogo.Name = "genLogo";
            this.genLogo.Size = new System.Drawing.Size(387, 130);
            this.genLogo.TabIndex = 0;
            this.genLogo.TabStop = false;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.generatedPassTB);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.genLogo);
            this.Name = "PasswordGenerator";
            this.Size = new System.Drawing.Size(640, 450);
            ((System.ComponentModel.ISupportInitialize)(this.genLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox genLogo;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox generatedPassTB;
    }
}

﻿
namespace PassGuard.UserControls.Components
{
    partial class PasswordButton
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
            this.nameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nameBtn
            // 
            this.nameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.nameBtn.FlatAppearance.BorderSize = 0;
            this.nameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nameBtn.ForeColor = System.Drawing.Color.White;
            this.nameBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameBtn.Location = new System.Drawing.Point(0, 58);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(141, 34);
            this.nameBtn.TabIndex = 3;
            this.nameBtn.Text = "Home";
            this.nameBtn.UseVisualStyleBackColor = false;
            // 
            // PasswordButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.nameBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PasswordButton";
            this.Size = new System.Drawing.Size(141, 92);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nameBtn;
    }
}


namespace PassGuard.UserControls
{
    partial class SettingsPage
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
            this.ThemeLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayName = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeLB
            // 
            this.ThemeLB.AutoSize = true;
            this.ThemeLB.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ThemeLB.ForeColor = System.Drawing.Color.White;
            this.ThemeLB.Location = new System.Drawing.Point(90, 244);
            this.ThemeLB.Name = "ThemeLB";
            this.ThemeLB.Size = new System.Drawing.Size(53, 20);
            this.ThemeLB.TabIndex = 0;
            this.ThemeLB.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profile";
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.ForeColor = System.Drawing.Color.White;
            this.displayName.Location = new System.Drawing.Point(26, 79);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(108, 20);
            this.displayName.TabIndex = 5;
            this.displayName.Text = "Display Name";
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(30, 131);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(123, 28);
            this.logOut.TabIndex = 6;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "General";
            // 
            // left
            // 
            this.left.Image = global::PassGuard.Properties.Resources.leftTheme;
            this.left.Location = new System.Drawing.Point(204, 246);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(14, 16);
            this.left.TabIndex = 8;
            this.left.TabStop = false;
            this.left.Click += new System.EventHandler(this.btn1_Click);
            // 
            // right
            // 
            this.right.Image = global::PassGuard.Properties.Resources.rightTheme;
            this.right.Location = new System.Drawing.Point(224, 246);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(14, 16);
            this.right.TabIndex = 9;
            this.right.TabStop = false;
            this.right.Click += new System.EventHandler(this.btn2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(95)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(0, 422);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(640, 28);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save changes";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemeLB);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(640, 450);
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThemeLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.Button SaveBtn;
    }
}

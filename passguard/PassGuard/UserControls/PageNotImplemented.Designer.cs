
namespace PassGuard.UserControls
{
    partial class PageNotImplemented
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
            this.Title = new System.Windows.Forms.Label();
            this.h2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(40, 43);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(560, 56);
            this.Title.TabIndex = 0;
            this.Title.Text = "Page not implemented";
            // 
            // h2
            // 
            this.h2.AutoSize = true;
            this.h2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2.ForeColor = System.Drawing.Color.White;
            this.h2.Location = new System.Drawing.Point(295, 103);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(291, 16);
            this.h2.TabIndex = 1;
            this.h2.Text = "\"Wait, you will. Trust in the Force, you must.\"";
            // 
            // PageNotImplemented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.h2);
            this.Controls.Add(this.Title);
            this.Name = "PageNotImplemented";
            this.Size = new System.Drawing.Size(640, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label h2;
    }
}

﻿using PassGuard.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class PasswordScreen : UserControl
    {
        // Dictates whether the user can or cannot change the password fields.
        private static bool contentsLocked = true;
        private PasswordInfo Passwd { get; set; }


        public PasswordScreen(PasswordInfo password)
        {
            InitializeComponent();

            this.Passwd = password;
            this.PasswordNameTB.Text = Passwd.Name;

            urlTB.Text = password.LoginURL;

            if (!string.IsNullOrEmpty(this.Passwd.ImageURL))
            {
                string actualURL = $"https://logo.clearbit.com/{urlTB.Text}?size=100";
                this.icon.LoadAsync(actualURL);
            }

            this.passwordTB.Text = EncryptionManager.Decrypt(Passwd.PasswordAfterEncrypt, Passwd.Key);

            AdjustPasswordNameTBWidth();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            contentsLocked = !contentsLocked;


            this.passwordTB.ReadOnly = contentsLocked;
            this.urlTB.ReadOnly = contentsLocked;
            this.saveButton.Enabled = !contentsLocked;
            this.changeButton.Enabled = !contentsLocked;
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            if (this.passwordTB.PasswordChar != '\0') //Text hidden
            {
                this.passwordTB.Text = EncryptionManager.Decrypt(Passwd.PasswordAfterEncrypt, Passwd.Key);
                this.passwordTB.PasswordChar = '\0';

                this.showPassword.Text = "Hide Password";

            }
            else //Text not hidden.
            {
                this.passwordTB.PasswordChar = '*';
                this.passwordTB.Text = EncryptionManager.Decrypt(Passwd.PasswordAfterEncrypt, Passwd.Key);

                this.showPassword.Text = "Show Password";
            }
        }

        private void urlTB_Leave(object sender, EventArgs e)
        {
            string actualURL = $"https://logo.clearbit.com/{urlTB.Text}?size=100";

            this.icon.LoadAsync(actualURL);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog
            {
                Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                icon.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Passwd.PasswordAfterEncrypt = EncryptionManager.Encrypt(this.passwordTB.Text);
            this.Passwd.Key = EncryptionManager.GetKey(this.passwordTB.Text);

            this.Passwd.LoginURL = urlTB.Text;
            this.Passwd.ImageURL = $"https://logo.clearbit.com/{urlTB.Text}?size=25";
        }

        private void PasswordNameTB_TextChanged(object sender, EventArgs e)
        {

            AdjustPasswordNameTBWidth();
        }


        /// <summary>
        /// Resizes the textbox automatically.
        /// </summary>
        private void AdjustPasswordNameTBWidth()
        {
            // Rendered text size.
            int rtSize = TextRenderer.MeasureText(this.PasswordNameTB.Text, this.PasswordNameTB.Font).Width;

            this.PasswordNameTB.Width = rtSize + 2; 
            
        }

        /// <summary>
        /// If pressed key is enter, and name isn't an empty string, rename the password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.PasswordNameTB.Text != "")
                {
                    this.Passwd.Name = this.PasswordNameTB.Text;
                    this.title.Focus();
                }
            }
        }
    }
}

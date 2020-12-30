using PassGuard.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class AddPassword : UserControl
    {
        public AddPassword()
        {
            InitializeComponent();
        }

        private void nameTB_MouseClick(object sender, MouseEventArgs e)
        {
            //Name... is the placeholder text for nameTB.
            if (e.Button == MouseButtons.Left && (!string.IsNullOrEmpty(nameTB.Text) && nameTB.Text == "Name..."))
            {
                nameTB.Clear();
                nameTB.ForeColor = Color.White;
            }
        }

        private void passwordTB_MouseClick(object sender, MouseEventArgs e)
        {
            //Password... is the placeholder text for passwordTB.
            if (e.Button == MouseButtons.Left && (!string.IsNullOrEmpty(passwordTB.Text) && passwordTB.Text == "Password..."))
            {
                passwordTB.Clear();
                passwordTB.ForeColor = Color.White;
                passwordTB.PasswordChar = '*';
            }
        }

        private void urlTB_MouseClick(object sender, MouseEventArgs e)
        {
            //Password... is the placeholder text for passwordTB.
            if (e.Button == MouseButtons.Left && (!string.IsNullOrEmpty(urlTB.Text) && urlTB.Text == "URL..."))
            {
                urlTB.Clear();
                urlTB.ForeColor = Color.White;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Neither empty, nor null nor placeholder.
            bool validName = (!string.IsNullOrEmpty(nameTB.Text) && nameTB.Text != "Name...");
            bool validPassword = (!string.IsNullOrEmpty(passwordTB.Text) && passwordTB.Text != "Password...");
            bool validURL = (!string.IsNullOrEmpty(urlTB.Text) && urlTB.Text != "URL...");

            if (validName && validPassword && validURL) //just works, bud
            {
                string encryptedPassword = Encryptor.Encrypt(passwordTB.Text);
                PasswordInfo passwd = new PasswordInfo(encryptedPassword, nameTB.Text, urlTB.Text, validURL ? $"https://logo.clearbit.com/{urlTB.Text}?size=25" : "");
                MainScreen.passwords.Add(passwd);
                
            } else
            {
                MessageBox.Show("Invalid fields!\nMake sure you've entered your name, password and url correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void urlTB_Leave(object sender, EventArgs e)
        {
            string actualURL = $"https://logo.clearbit.com/{urlTB.Text}?size=100";

            icon.LoadAsync(actualURL);            
        }

        private void icon_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //If the image was found, do not let the user change it, otherwise let him do whatever he wants.
            if (icon.Image != icon.ErrorImage)
            {
                this.changeButton.Enabled = false;
            }
            else
            {
                this.changeButton.Enabled = true;
            }
        }
    }
}

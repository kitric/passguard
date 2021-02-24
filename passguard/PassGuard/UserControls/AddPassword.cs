using PassGuard.Models;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class AddPassword : UserControl, IPage
    {
        public AddPassword()
        {
            InitializeComponent();

            ApplyTheme();
        }

        #region events

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
            //URL... is the placeholder text for passwordTB.
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
                string encryptedPassword = EncryptionManager.Encrypt(passwordTB.Text);

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(passwordTB.Text));

                    PasswordInfo passwd = new PasswordInfo(encryptedPassword, nameTB.Text, urlTB.Text, key, validURL ? $"https://logo.clearbit.com/{urlTB.Text}?size=25" : "");
                    MainScreen.Data.passwords.Add(passwd);
                    GlobalFunctions.SwitchTo<Passwords>(MainScreen.Instance.Content);
                }

            }
            else
            {
                MessageBox.Show("Invalid fields!\nMake sure you've entered your name, password and url correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTB.Text))
            {
                nameTB.Text = "Name...";
                urlTB.ForeColor = Color.WhiteSmoke;
            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTB.Text))
            {
                passwordTB.Text = "Password...";
                passwordTB.PasswordChar = '\0';
                passwordTB.ForeColor = Color.WhiteSmoke;
            }
        }

        private void urlTB_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(urlTB.Text))
            {
                string actualURL = $"https://logo.clearbit.com/{urlTB.Text}?size=100";

                icon.LoadAsync(actualURL);

            }
            else
            {
                urlTB.Text = "URL...";
                urlTB.ForeColor = Color.WhiteSmoke;
            }
        }

        private void icon_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //If the image was found, do not let the user change it, otherwise let him do whatever he wants.
            this.changeButton.Enabled = this.icon.Image == this.icon.ErrorImage;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog
            {
                Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                icon.Image = Image.FromFile(dialog.FileName);
            }
        }

        #endregion

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.changeButton.BackColor = Color.FromArgb(193, 25, 26);

                    this.nameTB.BackColor = Color.FromArgb(9, 11, 16);
                    this.panel1.BackColor = Color.FromArgb(9, 11, 16);

                    this.passwordTB.BackColor = Color.FromArgb(9, 11, 16);
                    this.panel2.BackColor = Color.FromArgb(9, 11, 16);

                    this.urlTB.BackColor = Color.FromArgb(9, 11, 16);
                    this.panel3.BackColor = Color.FromArgb(9, 11, 16);

                    this.saveButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.icon.BackColor = Color.FromArgb(9, 11, 16);

                    break;
                case Theme.TECHNO_LIGHT:
                    this.changeButton.BackColor = Color.FromArgb(193, 25, 26);

                    this.nameTB.BackColor = Color.FromArgb(200, 255, 255);
                    this.nameTB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.panel1.BackColor = Color.FromArgb(200, 255, 255);

                    this.passwordTB.BackColor = Color.FromArgb(200, 255, 255);
                    this.passwordTB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.panel2.BackColor = Color.FromArgb(200, 255, 255);

                    this.urlTB.BackColor = Color.FromArgb(200, 255, 255);
                    this.urlTB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.panel3.BackColor = Color.FromArgb(200, 255, 255);

                    this.saveButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.icon.BackColor = Color.FromArgb(200, 255, 255);

                    this.title.ForeColor = Color.FromArgb(193, 25, 26);

                    break;
                case Theme.CONTRAST_DARK:
                    this.changeButton.BackColor = Color.White;
                    this.changeButton.ForeColor = Color.Black;

                    this.nameTB.BackColor = Color.White;
                    this.nameTB.ForeColor = Color.Black;
                    this.panel1.BackColor = Color.White;

                    this.passwordTB.BackColor = Color.White;
                    this.passwordTB.ForeColor = Color.Black;
                    this.panel2.BackColor = Color.White;

                    this.urlTB.BackColor = Color.White;
                    this.urlTB.ForeColor = Color.Black;
                    this.panel3.BackColor = Color.White;

                    this.saveButton.BackColor = Color.White;
                    this.saveButton.ForeColor = Color.Black;
                    this.icon.BackColor = Color.Black;

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.changeButton.BackColor = Color.Black;
                    this.changeButton.ForeColor = Color.White;

                    this.nameTB.BackColor = Color.Black;
                    this.nameTB.ForeColor = Color.White;
                    this.panel1.BackColor = Color.Black;

                    this.passwordTB.BackColor = Color.Black;
                    this.passwordTB.ForeColor = Color.White;
                    this.panel2.BackColor = Color.Black;

                    this.urlTB.BackColor = Color.Black;
                    this.urlTB.ForeColor = Color.White;
                    this.panel3.BackColor = Color.Black;

                    this.saveButton.BackColor = Color.Black;
                    this.saveButton.ForeColor = Color.White;
                    this.icon.BackColor = Color.White;

                    this.title.ForeColor = Color.Black;

                    break;
            }
        }
    }
}

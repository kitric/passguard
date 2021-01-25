using PassGuard.Models;
using PassGuard.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class PasswordScreen : UserControl, IPage
    {
        // Dictates whether the user can or cannot change the password fields.
        private static bool contentsLocked = true;
        private PasswordInfo Passwd { get; set; }

        /// <summary>
        /// This constructor is called from somewhere else! :eyes:
        /// </summary>
        /// <param name="password"></param>
        public PasswordScreen(PasswordInfo password)
        {
            InitializeComponent();

            this.Passwd = password;
            this.PasswordNameTB.Text = Passwd.Name;

            urlTB.Text = password.LoginURL;

            if (!string.IsNullOrEmpty(this.Passwd.ImageURL))
            {
                // This logo database sucks, we must find a better one later (or should we make our own?).
                // WE SHOULD MAKE OUR OWN - crxssed
                // HOW GREAT - nordic
                string actualURL = $"https://logo.clearbit.com/{urlTB.Text}?size=100";
                this.icon.LoadAsync(actualURL);
            }

            this.passwordTB.Text = EncryptionManager.Decrypt(Passwd.PasswordAfterEncrypt, Passwd.Key);

            ApplyTheme();
            AdjustPasswordNameTBWidth();
        }


        #region events
        private void editButton_Click(object sender, EventArgs e)
        {
            contentsLocked = !contentsLocked;

            this.PasswordNameTB.ReadOnly = contentsLocked;
            this.passwordTB.ReadOnly = contentsLocked;
            this.urlTB.ReadOnly = contentsLocked;
            this.saveButton.Enabled = !contentsLocked;
            this.changeButton.Enabled = !contentsLocked;

            ShowOrHidePW();
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            ShowOrHidePW();
        }

        void ShowOrHidePW()
        {
            if (this.passwordTB.PasswordChar != '\0') // Text hidden
            {
                this.passwordTB.Text = EncryptionManager.Decrypt(Passwd.PasswordAfterEncrypt, Passwd.Key);
                this.passwordTB.PasswordChar = '\0';

                this.showPassword.Text = "Hide Password";

            }
            else // Text not hidden.
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
                Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                icon.Image = Image.FromFile(dialog.FileName);

                Passwd.ImageURL = dialog.FileName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Passwd.PasswordAfterEncrypt = EncryptionManager.Encrypt(this.passwordTB.Text);
            this.Passwd.Key = EncryptionManager.GetKey(this.passwordTB.Text);

            this.Passwd.LoginURL = urlTB.Text;
            this.Passwd.ImageURL = $"https://logo.clearbit.com/{urlTB.Text}?size=25";

            if (this.PasswordNameTB.Text != "")
            {
                this.Passwd.Name = this.PasswordNameTB.Text;
            }

            this.InvalidNameLB.Visible = this.PasswordNameTB.Text == "";

            // Disable edit mode
            contentsLocked = !contentsLocked;

            this.PasswordNameTB.ReadOnly = contentsLocked;
            this.passwordTB.ReadOnly = contentsLocked;
            this.urlTB.ReadOnly = contentsLocked;
            this.saveButton.Enabled = !contentsLocked;
            this.changeButton.Enabled = !contentsLocked;
        }

        private void PasswordNameTB_TextChanged(object sender, EventArgs e)
        {

            AdjustPasswordNameTBWidth();
        }

        #endregion

        /// <summary>
        /// Resizes the textbox automatically.
        /// </summary>
        private void AdjustPasswordNameTBWidth()
        {
            // Rendered text size.
            int rtSize = TextRenderer.MeasureText(this.PasswordNameTB.Text, this.PasswordNameTB.Font).Width;

            this.PasswordNameTB.Width = rtSize + 2;

        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:

                    this.editButton.BackColor = Color.FromArgb(15, 17, 26);

                    this.title.ForeColor = Color.FromArgb(193, 25, 26);
                    this.showPassword.BackColor = Color.FromArgb(193, 25, 26);
                    this.changeButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.saveButton.BackColor = Color.FromArgb(193, 25, 26);

                    this.urlTB.BackColor = Color.FromArgb(9, 11, 16);
                    this.passwordTB.BackColor = Color.FromArgb(9, 11, 16);

                    this.icon.BackColor = Color.FromArgb(9, 11, 16);

                    this.PasswordNameTB.BackColor = Color.FromArgb(15, 17, 26);

                    break;
                case Theme.TECHNO_LIGHT:

                    this.editButton.BackColor = Color.FromArgb(242, 242, 242);
                    this.editButton.BackgroundImage = Resources.edit_dark;

                    this.title.ForeColor = Color.FromArgb(193, 25, 26);
                    this.showPassword.BackColor = Color.FromArgb(193, 25, 26);
                    this.changeButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.saveButton.BackColor = Color.FromArgb(193, 25, 26);

                    this.urlTB.BackColor = Color.FromArgb(200, 255, 255);
                    this.passwordTB.BackColor = Color.FromArgb(200, 255, 255);

                    this.urlTB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.passwordTB.ForeColor = Color.FromArgb(193, 25, 26);

                    this.icon.BackColor = Color.FromArgb(200, 255, 255);

                    this.PasswordNameTB.BackColor = Color.FromArgb(242, 242, 242);
                    this.PasswordNameTB.ForeColor = Color.FromArgb(193, 25, 26);

                    break;
                case Theme.CONTRAST_DARK:
                    this.editButton.BackColor = Color.FromArgb(5, 5, 5);

                    this.showPassword.BackColor = Color.White;
                    this.showPassword.ForeColor = Color.Black;
                    this.changeButton.BackColor = Color.White;
                    this.changeButton.ForeColor = Color.Black;
                    this.saveButton.BackColor = Color.White;
                    this.saveButton.ForeColor = Color.Black;

                    this.urlTB.BackColor = Color.White;
                    this.passwordTB.BackColor = Color.White;

                    this.urlTB.ForeColor = Color.Black;
                    this.passwordTB.ForeColor = Color.Black;

                    this.icon.BackColor = Color.Black;

                    this.PasswordNameTB.BackColor = Color.FromArgb(5, 5, 5);

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.editButton.BackColor = Color.FromArgb(250, 250, 250);
                    this.editButton.BackgroundImage = Resources.edit_dark;

                    this.showPassword.BackColor = Color.Black;
                    this.showPassword.ForeColor = Color.White;
                    this.changeButton.BackColor = Color.Black;
                    this.changeButton.ForeColor = Color.White;
                    this.saveButton.BackColor = Color.Black;
                    this.saveButton.ForeColor = Color.White;

                    this.urlTB.BackColor = Color.Black;
                    this.passwordTB.BackColor = Color.Black;

                    this.urlTB.ForeColor = Color.White;
                    this.passwordTB.ForeColor = Color.White;

                    this.icon.BackColor = Color.White;

                    this.PasswordNameTB.BackColor = Color.FromArgb(250, 250, 250);
                    this.PasswordNameTB.ForeColor = Color.Black;
                    this.title.ForeColor = Color.Black;

                    break;
            }

            this.panel2.BackColor = this.passwordTB.BackColor;
            this.panel3.BackColor = this.passwordTB.BackColor;
        }
    }
}

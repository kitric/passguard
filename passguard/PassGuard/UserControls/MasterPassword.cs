using PassGuard.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class MasterPassword : UserControl, IPage
    {
        private readonly MainScreen MainScreen;

        public MasterPassword(MainScreen ms)
        {
            InitializeComponent();

            this.MainScreen = ms;

            GlobalFunctions.RoundCorners(goButton);

            ApplyTheme();
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.goButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.MasterPasswordTB.BackColor = Color.FromArgb(9, 11, 16);

                    break;
                case Theme.TECHNO_LIGHT:
                    this.goButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.MasterPasswordTB.BackColor = Color.FromArgb(200, 255, 255);
                    this.MasterPasswordTB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.title.ForeColor = Color.FromArgb(193, 25, 26);
                    this.label1.ForeColor = Color.FromArgb(193, 25, 26);
                    this.remind.ForeColor = Color.FromArgb(193, 25, 26);

                    break;
                case Theme.CONTRAST_DARK:
                    this.goButton.BackColor = Color.White;
                    this.goButton.ForeColor = Color.Black;
                    this.MasterPasswordTB.BackColor = Color.White;
                    this.MasterPasswordTB.ForeColor = Color.Black;
                    this.title.ForeColor = Color.White;
                    this.label1.ForeColor = Color.White;
                    break;
                case Theme.CONTRAST_LIGHT:
                    this.goButton.BackColor = Color.Black;
                    this.goButton.ForeColor = Color.White;
                    this.MasterPasswordTB.BackColor = Color.Black;
                    this.MasterPasswordTB.ForeColor = Color.White;
                    this.title.ForeColor = Color.Black;
                    this.label1.ForeColor = Color.Black;
                    this.remind.ForeColor = Color.Black;
                    break;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (MasterPasswordTB.Text == MainScreen.Data.MasterPassword)
            {
                MainScreen.EnableTabs();
                GlobalFunctions.SwitchTo<HomePage>(MainScreen.Instance.Content);
            }

            WrongPasswordLB.Visible = !(MasterPasswordTB.Text == MainScreen.Data.MasterPassword);
        }

        private async void remind_Click(object sender, EventArgs e)
        {
            string content = "Hiya, " + MainScreen.user.DisplayName + 
                "<br><br>Here is your PassGuard login info:<br><h1>" + 
                MainScreen.Data.MasterPassword + 
                "</h1><br><br>In the future please remember this, its the best way to keep your PassGuard account safe." +
                "<br><br>Thanks,<br>The Kitric Team";

            await EmailHandler.SendEmailAsync(MainScreen.user.DisplayName, MainScreen.user.EmailAddress, content);
            MessageBox.Show("We have sent you an email with a reminder of your password.", "Email sent", MessageBoxButtons.OK);
        }
    }
}

using PassGuard.Models;
using PassGuard.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class HomePage : UserControl, IPage
    {

        public HomePage()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(YourPasswordsBtn);
            GlobalFunctions.RoundCorners(GenerateAPasswordBtn);

            Timer.Tick += UpdateTime;

            this.Time.Text = DateTime.Now.ToString("t");
            ApplyTheme();
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("t");

            //If currentTime is different than the one registered on the label
            if (currentTime != this.Time.Text)
            {
                this.Time.Text = currentTime;
            }
        }

        private void YourPasswords_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<Passwords>(MainScreen.Instance.Content);
        }

        private void GenerateAPassword_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<PasswordGenerator>(MainScreen.Instance.Content, args: new object[] { });
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme) {
                case Theme.TECHNO_DARK:    
                    this.YourPasswordsBtn.BackColor = Color.FromArgb(193, 25, 26); 
                    this.GenerateAPasswordBtn.BackColor = Color.FromArgb(193, 25, 26); 
                    this.Time.ForeColor = Color.FromArgb(193, 25, 26);
                    break;
                case Theme.TECHNO_LIGHT:
                    this.YourPasswordsBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.GenerateAPasswordBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.Time.ForeColor = Color.FromArgb(193, 25, 26);

                    this.pwtBig.Image = Resources.homeScreenImage_dark;

                    break;
                case Theme.CONTRAST_DARK:
                    this.YourPasswordsBtn.BackColor = Color.White;
                    this.YourPasswordsBtn.ForeColor = Color.Black;
                    this.GenerateAPasswordBtn.BackColor = Color.White;
                    this.GenerateAPasswordBtn.ForeColor = Color.Black;

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.YourPasswordsBtn.BackColor = Color.Black;
                    this.YourPasswordsBtn.ForeColor = Color.White;
                    this.GenerateAPasswordBtn.BackColor = Color.Black;
                    this.GenerateAPasswordBtn.ForeColor = Color.White;

                    this.pwtBig.Image = Resources.homeScreenImage_dark;

                    break;
            }
        }
    }
}

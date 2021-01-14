using PassGuard.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Login : UserControl, IPage
    {

        public Login()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            GlobalFunctions.RoundCorners(loginButton);
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.loginButton.BackColor = Color.FromArgb(193, 25, 26);
                    break;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainScreen.LoginAccount();
        }
    }
}

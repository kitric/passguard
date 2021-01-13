using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Login : UserControl
    {

        public Login()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            GlobalFunctions.RoundCorners(loginButton);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainScreen.LoginAccount();
        }
    }
}

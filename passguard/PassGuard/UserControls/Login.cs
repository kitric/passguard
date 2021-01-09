using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Login : UserControl
    {
        readonly MainScreen mainScreen;

        public Login(MainScreen ms)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            GlobalFunctions.RoundCorners(loginButton);

            this.mainScreen = ms;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainScreen.LoginAccount();
        }
    }
}

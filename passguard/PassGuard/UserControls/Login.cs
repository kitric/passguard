using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassGuard.Models;

namespace PassGuard.UserControls
{
    public partial class Login : UserControl
    {
        MainScreen mainScreen;

        public Login(MainScreen ms)
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(loginButton);

            this.mainScreen = ms;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainScreen.LoginAccount();
        }
    }
}

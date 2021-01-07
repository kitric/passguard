using PassGuard.Models;
using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class HomePage : UserControl
    {
        internal static MainScreen mainScreen;

        public HomePage(MainScreen ms)
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(YourPasswords);
            GlobalFunctions.RoundCorners(GenerateAPassword);

            Timer.Tick += UpdateTime;

            this.Time.Text = DateTime.Now.ToString("t");
            mainScreen = ms;
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
            mainScreen.SwitchTo<Passwords>();
        }

        private void GenerateAPassword_Click(object sender, EventArgs e)
        {
            mainScreen.SwitchTo<PasswordGenerator>(args: new object[] { });
        }
    }
}

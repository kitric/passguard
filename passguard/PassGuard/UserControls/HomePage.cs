using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class HomePage : UserControl
    {
        MainScreen mainScreen;

        public HomePage(MainScreen ms)
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(YourPasswords, 15);
            GlobalFunctions.RoundCorners(GenerateAPassword, 15);

            Timer.Tick += UpdateTime;

            this.Time.Text = DateTime.Now.ToString("t");
            this.mainScreen = ms;
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
            mainScreen.AddPasswordScreen();
        }

        private void GenerateAPassword_Click(object sender, EventArgs e)
        {
            mainScreen.AddGeneratorScreen();
        }
    }
}

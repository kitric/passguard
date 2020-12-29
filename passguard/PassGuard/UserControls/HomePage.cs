using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(YourPasswords, 15);
            GlobalFunctions.RoundCorners(GenerateAPassword, 15);

            Timer.Tick += UpdateTime;

            this.Time.Text = DateTime.Now.ToString("t");

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
    }
}

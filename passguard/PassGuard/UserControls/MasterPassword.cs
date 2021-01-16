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

                    break;
                case Theme.TECHNO_LIGHT:
                    this.goButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.MasterPasswordTB.BackColor = Color.FromArgb(200, 255, 255);
                    this.MasterPasswordTB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.title.ForeColor = Color.FromArgb(193, 25, 26);
                    this.label1.ForeColor = Color.FromArgb(193, 25, 26);

                    break;
                case Theme.CONTRAST_DARK:
                    this.goButton.BackColor = Color.White;
                    this.goButton.ForeColor = Color.Black;
                    this.MasterPasswordTB.BackColor = Color.White;
                    this.MasterPasswordTB.ForeColor = Color.Black;
                    this.title.ForeColor = Color.White;
                    this.label1.ForeColor = Color.White;
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


    }
}

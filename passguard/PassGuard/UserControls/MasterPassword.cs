using PassGuard.Models;
using System;
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
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
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

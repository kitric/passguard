using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class SetMasterPassword : UserControl
    {
        private readonly MainScreen MainScreen;

        public SetMasterPassword(MainScreen ms)
        {
            InitializeComponent();
            this.MainScreen = ms;

            GlobalFunctions.RoundCorners(goButton);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MasterPasswordTB.Text))
            {
                MainScreen.Data.MasterPassword = MasterPasswordTB.Text;
                MainScreen.EnableTabs();
                GlobalFunctions.SwitchTo<HomePage>(MainScreen.Instance.Content);
            }
        }
    }
}

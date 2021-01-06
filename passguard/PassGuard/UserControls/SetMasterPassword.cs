using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Properties.Settings.Default.MasterPassword = MasterPasswordTB.Text;
                MainScreen.EnableTabs();
                MainScreen.AddHomePageScreen();

                Properties.Settings.Default.Save();
            }
        }
    }
}

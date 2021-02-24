using System;
using System.Drawing;
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

            ApplyTheme();
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

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.goButton.BackColor = Color.FromArgb(193, 25, 26);
                    this.MasterPasswordTB.BackColor = Color.FromArgb(9, 11, 16);

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
                case Theme.CONTRAST_LIGHT:
                    this.goButton.BackColor = Color.Black;
                    this.goButton.ForeColor = Color.White;
                    this.MasterPasswordTB.BackColor = Color.Black;
                    this.MasterPasswordTB.ForeColor = Color.White;
                    this.title.ForeColor = Color.Black;
                    this.label1.ForeColor = Color.Black;
                    break;
            }
        }
    }
}

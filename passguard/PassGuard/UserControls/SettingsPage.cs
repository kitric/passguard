using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            RestoreSettings();
        }

        private void RestoreSettings()
        {
            this.ThemeLB.Text = MainScreen.Data.ThemeName.ToLower();
        }
    }
}

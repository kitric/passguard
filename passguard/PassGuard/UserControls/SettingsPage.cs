using System;
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
            this.ThemeLB.Text = MainScreen.Data.Theme.ToString().ToLower().Replace("_", " ");
        }

        private void btn1_Click(object sender, System.EventArgs e)
        {
            int current = (int)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));

            if (current == 0) {
                current = (int)Enum.GetValues(typeof(Theme)).Length - 1;
            
            } else
            {
                --current;
            }

            Theme temp = (Theme)current;

            this.ThemeLB.Text = temp.ToString().ToLower().Replace("_", " ");
        }
    }
}

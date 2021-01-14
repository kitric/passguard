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

        private void btn1_Click(object sender, EventArgs e)
        {
            int current = (int)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));

            
            // If the current theme is the first one select the last one
            // otherwise select the theme above the current one.
            current = current != 0 ? --current : Enum.GetValues(typeof(Theme)).Length - 1;

            Theme temp = (Theme)current;
            this.ThemeLB.Text = temp.ToString().ToLower().Replace("_", " ");
            MainScreen.Data.Theme = temp;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int current = (int)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));

            // If the current theme is the last one select the first one
            // otherwise select the theme below the current one.
            current = current == Enum.GetValues(typeof(Theme)).Length - 1 ? 0 : ++current;

            Theme temp = (Theme)current;
            this.ThemeLB.Text = temp.ToString().ToLower().Replace("_", " ");
            MainScreen.Data.Theme = temp;
        }
    }
}

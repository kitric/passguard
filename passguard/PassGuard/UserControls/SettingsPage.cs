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
                // Select the last element of the enum.
                current = Enum.GetValues(typeof(Theme)).Length - 1;
            
            } else
            {
                // Select the theme above the current one.
                --current; 
            }

            Theme temp = (Theme)current;
            this.ThemeLB.Text = temp.ToString().ToLower().Replace("_", " ");
            MainScreen.Data.Theme = temp;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int current = (int)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));
            
            if (current == Enum.GetValues(typeof(Theme)).Length - 1) //The last one
            {
                current = 0;
            
            } else
            {
                // Select the theme below the current one.
                current++;
            }

            Theme temp = (Theme)current;
            this.ThemeLB.Text = temp.ToString().ToLower().Replace("_", " ");
            MainScreen.Data.Theme = temp;
        }
    }
}

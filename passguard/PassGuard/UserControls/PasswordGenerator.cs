using PassGuard.Models;
using PassGuard.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class PasswordGenerator : UserControl, IPage
    {
        public PasswordGenerator()
        {
            InitializeComponent();
            GlobalFunctions.RoundCorners(generateBtn);

            ApplyTheme();
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.generateBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.generatedPassTB.BackColor = Color.FromArgb(15, 17, 26);

                    break;
                case Theme.TECHNO_LIGHT:
                    this.generateBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.generatedPassTB.BackColor = Color.FromArgb(242, 242, 242);
                    this.generatedPassTB.ForeColor = Color.FromArgb(193, 25, 26);

                    this.genLogo.Image = Resources.genLogo_dark;

                    break;
                case Theme.CONTRAST_DARK:
                    this.generateBtn.BackColor = Color.White;
                    this.generateBtn.ForeColor = Color.Black;
                    this.generatedPassTB.BackColor = Color.FromArgb(5, 5, 5);

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.generateBtn.BackColor = Color.Black;
                    this.generateBtn.ForeColor = Color.White;
                    this.generatedPassTB.BackColor = Color.FromArgb(250, 250, 250);
                    this.generatedPassTB.ForeColor = Color.Black;

                    this.genLogo.Image = Resources.genLogo_dark;

                    break;
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.generateBtn.Enabled = false;
            this.generatedPassTB.Text = PasswordGeneration.GeneratePassword(16);
            this.generateBtn.Enabled = true;
        }
    }
}

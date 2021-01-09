using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class PasswordGenerator : UserControl
    {
        public PasswordGenerator()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(generateBtn);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.generateBtn.Enabled = false;
            this.generatedPassTB.Text = PasswordGeneration.GeneratePassword(16);
            this.generateBtn.Enabled = true;
        }
    }
}

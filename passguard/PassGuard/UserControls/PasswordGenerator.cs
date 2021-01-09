using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class PasswordGenerator : UserControl
    {
        public PasswordGenerator()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(generate);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.generatedPassTB.Text = PasswordGeneration.GeneratePassword(16);
        }
    }
}

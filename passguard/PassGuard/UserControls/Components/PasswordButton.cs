using PassGuard.Models;
using System.Windows.Forms;

namespace PassGuard.UserControls.Components
{
    public partial class PasswordButton : UserControl
    {
        public PasswordButton(PasswordInfo password)
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(this, 15);
            GlobalFunctions.RoundCorners(nameBtn, 15);

            nameBtn.Text = password.Name;

            if (!string.IsNullOrEmpty(password.Image))
            {
                icon.LoadAsync(password.Image);
            }
        }
    }
}

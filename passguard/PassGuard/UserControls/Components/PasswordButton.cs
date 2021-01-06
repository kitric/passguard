using PassGuard.Models;
using System.Windows.Forms;

namespace PassGuard.UserControls.Components
{
    public partial class PasswordButton : UserControl
    {
        // This is only here to access the AddToScreen functions, if there is a better way to do this, then feel free to change it.
        private readonly MainScreen mainScreen;
        private readonly PasswordInfo passwordInfo;

        public PasswordButton(PasswordInfo password, MainScreen ms)
        {
            InitializeComponent();

            this.mainScreen = ms;
            this.passwordInfo = password;

            GlobalFunctions.RoundCorners(this);
            GlobalFunctions.RoundCorners(nameBtn);

            nameBtn.Text = password.Name;

            if (!string.IsNullOrEmpty(password.ImageURL))
            {
                icon.LoadAsync(password.ImageURL);
            }
        }

        private void nameBtn_Click(object sender, System.EventArgs e)
        {
            mainScreen.AddPasswordViewerScreen(passwordInfo);
        }
    }
}

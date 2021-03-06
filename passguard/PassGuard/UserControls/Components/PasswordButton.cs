﻿using PassGuard.Models;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls.Components
{
    public partial class PasswordButton : UserControl
    {
        // This is only here to access the AddToScreen functions, if there is a better way to do this, then feel free to change it.
        private readonly PasswordInfo passwordInfo;

        public PasswordButton(PasswordInfo password)
        {
            InitializeComponent();

            this.passwordInfo = password;

            GlobalFunctions.RoundCorners(this);
            GlobalFunctions.RoundCorners(nameBtn);

            nameBtn.Text = password.Name;

            if (!string.IsNullOrEmpty(password.ImageURL))
            {
                icon.LoadAsync(password.ImageURL);
            }

            ApplyTheme();
        }

        private void nameBtn_Click(object sender, System.EventArgs e)
        {
            GlobalFunctions.SwitchTo<PasswordScreen>(MainScreen.Instance.Content, args: new object[] { passwordInfo });
        }


        private void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.BackColor = Color.FromArgb(9, 11, 16);
                    this.nameBtn.BackColor = Color.FromArgb(193, 25, 26);
                    break;
                case Theme.TECHNO_LIGHT:
                    this.BackColor = Color.FromArgb(200, 255, 255);
                    this.nameBtn.BackColor = Color.FromArgb(193, 25, 26);

                    break;
                case Theme.CONTRAST_DARK:
                    this.BackColor = Color.Black;
                    this.nameBtn.BackColor = Color.White;
                    this.nameBtn.ForeColor = Color.Black;

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.BackColor = Color.White;
                    this.nameBtn.BackColor = Color.Black;
                    this.nameBtn.ForeColor = Color.White;

                    break;
            }
        }
    }
}

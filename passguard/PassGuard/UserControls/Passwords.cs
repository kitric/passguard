using PassGuard.Models;
using PassGuard.Properties;
using PassGuard.UserControls.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Passwords : UserControl
    {

        public Passwords()
        {
            InitializeComponent();

            GlobalFunctions.HideScrollbars(content);

            ApplyTheme();

            DeserializeList();
        }

        private void DeserializeList()
        {
            foreach (PasswordInfo info in MainScreen.Data.passwords)
            {
                PasswordButton btn = new PasswordButton(info);
                content.Controls.Add(btn);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<AddPassword>(MainScreen.Instance.Content);
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.addButton.BackColor = Color.FromArgb(15, 17, 26);

                    break;
                case Theme.TECHNO_LIGHT:
                    this.addButton.BackColor = Color.FromArgb(242, 242, 242);

                    this.title.ForeColor = Color.FromArgb(193, 25, 26);
                    this.addButton.BackgroundImage = Resources.add_dark;

                    break;
                case Theme.CONTRAST_DARK:
                    this.addButton.BackColor = Color.FromArgb(5, 5, 5);

                    this.title.ForeColor = Color.White;

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.addButton.BackColor = Color.FromArgb(250, 250, 250);

                    this.title.ForeColor = Color.Black;

                    this.addButton.BackgroundImage = Resources.add_dark;

                    break;
            }
        }
    }
}

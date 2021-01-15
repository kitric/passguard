using PassGuard.Models;
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
            }
        }
    }
}

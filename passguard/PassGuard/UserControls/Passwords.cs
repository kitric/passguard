using PassGuard.Models;
using PassGuard.UserControls.Components;
using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Passwords : UserControl
    {

        public Passwords()
        {
            InitializeComponent();

            GlobalFunctions.HideScrollbars(content);

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
    }
}

using PassGuard.Models;
using PassGuard.UserControls.Components;
using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Passwords : UserControl
    {
        readonly MainScreen mainScreen;

        public Passwords(MainScreen ms)
        {
            InitializeComponent();

            GlobalFunctions.HideScrollbars(content);

            this.mainScreen = ms;

            DeserializeList();
        }

        private void DeserializeList()
        {
            foreach (PasswordInfo info in MainScreen.Data.passwords)
            {
                PasswordButton btn = new PasswordButton(info, mainScreen);
                content.Controls.Add(btn);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            mainScreen.SwitchTo<AddPassword>(args: new object[] { });
        }
    }
}

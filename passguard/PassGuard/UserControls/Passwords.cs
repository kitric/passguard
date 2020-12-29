using PassGuard.Models;
using PassGuard.UserControls.Components;
using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class Passwords : UserControl
    {
        MainScreen mainScreen;

        public Passwords(MainScreen ms)
        {
            InitializeComponent();

            this.mainScreen = ms;

            DeserializeList();
        }

        private void DeserializeList()
        {
            foreach (PasswordInfo info in MainScreen.passwords)
            {
                PasswordButton btn = new PasswordButton(info);
                content.Controls.Add(btn);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            mainScreen.Add_AddPasswordScreen();
        }
    }
}

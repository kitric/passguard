﻿using PassGuard.Models;
using System;
using System.Windows.Forms;

namespace PassGuard.UserControls
{
    public partial class MasterPassword : UserControl
    {
        private readonly MainScreen MainScreen;

        public MasterPassword(MainScreen ms)
        {
            InitializeComponent();

            this.MainScreen = ms;

            GlobalFunctions.RoundCorners(goButton);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (MasterPasswordTB.Text == MainScreen.Data.MasterPassword)
            {
                MainScreen.EnableTabs();
                MainScreen.SwitchTo<HomePage>();
            }

            WrongPasswordLB.Visible = !(MasterPasswordTB.Text == MainScreen.Data.MasterPassword);
        }
    }
}

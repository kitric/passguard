﻿using PassGuard.Models;
using PassGuard.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace PassGuard.UserControls
{
    public partial class SettingsPage : UserControl, IPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            GlobalFunctions.RoundCorners(logOut);
            GlobalFunctions.RoundCorners(resetPW);
            GlobalFunctions.RoundCorners(deleteData);

            this.displayName.Text = GlobalFunctions.ToTitleCase(MainScreen.user.DisplayName);

            RestoreSettings();

            ApplyTheme();
        }

        private void RestoreSettings()
        {
            this.ThemeLB.Text = MainScreen.Data.Theme.ToString().ToLower().Replace("_", " ");
            this.ThemeLB.Text = GlobalFunctions.ToTitleCase(ThemeLB.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int current = (int)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));

            // If the current theme is the first one select the last one
            // otherwise select the theme above the current one.
            current = current != 0 ? --current : Enum.GetValues(typeof(Theme)).Length - 1;

            Theme temp = (Theme)current;
            this.ThemeLB.Text = GlobalFunctions.ToTitleCase(temp.ToString().ToLower().Replace("_", " "));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int current = (int)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));

            // If the current theme is the last one select the first one
            // otherwise select the theme below the current one.
            current = current == Enum.GetValues(typeof(Theme)).Length - 1 ? 0 : ++current;

            Theme temp = (Theme)current;
            this.ThemeLB.Text = GlobalFunctions.ToTitleCase(temp.ToString().ToLower().Replace("_", " "));
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            MainScreen.SerializePasswordInfos();
            Directory.Delete(Path.Combine(GlobalFunctions.GetAppdataFolder() + "\\token.json"), true);
            MainScreen.loggedIn = false;
            Application.Restart();
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.logOut.BackColor = Color.FromArgb(193, 25, 26);
                    this.resetPW.BackColor = Color.FromArgb(193, 25, 26);
                    this.SaveBtn.BackColor = Color.FromArgb(193, 25, 26);
                    break;

                case Theme.TECHNO_LIGHT:
                    this.logOut.BackColor = Color.FromArgb(193, 25, 26);
                    this.resetPW.BackColor = Color.FromArgb(193, 25, 26);
                    this.SaveBtn.BackColor = Color.FromArgb(193, 25, 26);

                    this.ThemeLB.ForeColor = Color.FromArgb(193, 25, 26);
                    this.label1.ForeColor = Color.FromArgb(193, 25, 26);
                    this.label2.ForeColor = Color.FromArgb(193, 25, 26);
                    this.label3.ForeColor = Color.FromArgb(193, 25, 26);
                    this.displayName.ForeColor = Color.FromArgb(193, 25, 26);

                    this.left.Image = Resources.leftTheme_dark;
                    this.right.Image = Resources.rightTheme_dark;
                    break;

                case Theme.CONTRAST_DARK:
                    this.logOut.BackColor = Color.White;
                    this.resetPW.BackColor = Color.White;
                    this.logOut.ForeColor = Color.Black;
                    this.resetPW.ForeColor = Color.Black;
                    this.SaveBtn.ForeColor = Color.Black;
                    this.SaveBtn.BackColor = Color.White;
                    break;

                case Theme.CONTRAST_LIGHT:
                    this.logOut.BackColor = Color.Black;
                    this.resetPW.BackColor = Color.Black;
                    this.logOut.BackColor = Color.Black;
                    this.resetPW.BackColor = Color.Black;
                    this.SaveBtn.ForeColor = Color.White;
                    this.SaveBtn.BackColor = Color.Black;

                    this.ThemeLB.ForeColor = Color.Black;
                    this.label1.ForeColor = Color.Black;
                    this.label2.ForeColor = Color.Black;
                    this.label3.ForeColor = Color.Black;
                    this.displayName.ForeColor = Color.Black;

                    this.left.Image = Resources.leftTheme_dark;
                    this.right.Image = Resources.rightTheme_dark;
                    break;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your changes have been saved.\nThe app will now restart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Theme temp = (Theme)Enum.Parse(typeof(Theme), this.ThemeLB.Text.ToUpper().Replace(" ", "_"));
                MainScreen.Data.Theme = temp;

                GlobalFunctions.Close = true;
                Application.Restart();
            }
        }

        private void resetPW_Click(object sender, EventArgs e)
        {
            MainScreen.Data.MasterPassword = "";
            MainScreen.SerializePasswordInfos();
            Application.Restart();
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete your data? THIS CANNOT BE UNDONE.", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MainScreen.Data.passwords.Clear();
                MainScreen.Data.Theme = Theme.DEFAULT;
                MainScreen.SerializePasswordInfos();
                Application.Restart();
            }
        }
    }
}

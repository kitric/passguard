﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PassGuard.Models;
using PassGuard.Properties;

namespace PassGuard.UserControls
{
    public partial class About : UserControl, IPage
    {
        public About()
        {
            InitializeComponent();

            GlobalFunctions.HideScrollbars(this);
            GlobalFunctions.RoundCorners(website);

            ApplyTheme();
        }

        public void ApplyTheme()
        {
            switch (MainScreen.Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.crxssed.BackColor = Color.FromArgb(15, 17, 26);
                    this.nordic.BackColor = Color.FromArgb(15, 17, 26);
                    this.website.BackColor = Color.FromArgb(15, 17, 26);
                    break;
                case Theme.TECHNO_LIGHT:
                    this.crxssed.BackColor = Color.FromArgb(242, 242, 242);
                    this.nordic.BackColor = Color.FromArgb(242, 242, 242);
                    this.website.BackColor = Color.FromArgb(242, 242, 242);

                    this.website.ForeColor = Color.FromArgb(193, 25, 26);
                    this.info.ForeColor = Color.FromArgb(193, 25, 26);

                    this.crxssed.Image = Resources.crxssed_dark;
                    this.nordic.Image = Resources.nordic_dark;
                    this.kilogo.Image = Resources.kitric_dark;
                    this.pgtext.Image = Resources.pg_dark;

                    break;
                case Theme.CONTRAST_DARK:
                    this.website.BackColor = Color.White;
                    this.website.ForeColor = Color.Black;

                    break;
                case Theme.CONTRAST_LIGHT:
                    this.website.BackColor = Color.Black;
                    this.website.ForeColor = Color.White;

                    this.info.ForeColor = Color.Black;

                    this.crxssed.Image = Resources.crxssed_dark;
                    this.nordic.Image = Resources.nordic_dark;
                    this.kilogo.Image = Resources.kitric_dark;
                    this.pgtext.Image = Resources.pg_dark;

                    break;
            }
        }

        private void crxssed_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/crxssed7");
        }

        private void nordic_Click(object sender, EventArgs e)
        {
            Process.Start("https://nordic16.github.io");
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start("https://kitric.github.io");
        }


    }
}

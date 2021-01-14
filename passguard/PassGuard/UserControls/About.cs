using System;
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

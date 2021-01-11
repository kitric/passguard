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

namespace PassGuard.UserControls
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();

            GlobalFunctions.HideScrollbars(this);
            GlobalFunctions.RoundCorners(website);
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

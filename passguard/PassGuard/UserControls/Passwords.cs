using PassGuard.UserControls.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            mainScreen.Add_AddPasswordScreen();
        }
    }
}

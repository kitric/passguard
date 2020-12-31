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
    public partial class PasswordGenerator : UserControl
    {
        public PasswordGenerator()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(generate, 15);
        }
    }
}

using PassGuard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGuard.UserControls.Components
{
    public partial class PasswordButton : UserControl
    {
        public PasswordButton(PasswordInfo password)
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(this, 15);
            GlobalFunctions.RoundCorners(nameBtn, 15);

            nameBtn.Text = password.Name;
        }
    }
}

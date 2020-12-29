using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGuard
{
    public static class GlobalFunctions
    {
        /// <summary>
        /// Round all them corners boi
        /// </summary>
        /// <param name="c">Control to round</param>
        /// <param name="diameter">The diameter of the roundness</param>
        public static void RoundCorners(Control c, int diameter)
        {
            Rectangle r = new Rectangle(0, 0, c.Width, c.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(r.X, r.Y, diameter, diameter, 180, 90);
            gp.AddArc(r.X + r.Width - diameter, r.Y, diameter, diameter, 270, 90);
            gp.AddArc(r.X + r.Width - diameter, r.Y + r.Height - diameter, diameter, diameter, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - diameter, diameter, diameter, 90, 90);
            c.Region = new Region(gp);
        }

        public static string GetAppdataFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "passguard");
        }
    }
}

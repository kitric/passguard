using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PassGuard
{
    public static class GlobalFunctions
    {
        public const int ROUND_DIAMETER = 15;
        private static readonly RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();

        public const string ApplicationName = "Passguard";

        // Checks whether MasterPassword has been entered or not.
        internal static bool Validated = false;

        internal static bool Close = false;

        /// <summary>
        /// Round all them corners boi
        /// </summary>
        /// <param name="c">Control to round</param>
        /// <param name="diameter">The diameter of the roundness</param>
        public static void RoundCorners(Control c, int diameter = ROUND_DIAMETER)
        {
            Rectangle r = new Rectangle(0, 0, c.Width, c.Height);
            GraphicsPath gp = new GraphicsPath();
            // Create an arc in the bottom left
            gp.AddArc(r.X, r.Y, diameter, diameter, 180, 90);
            // Create an arc in the top left
            gp.AddArc(r.X + r.Width - diameter, r.Y, diameter, diameter, 270, 90);
            // Create an arc in the top right
            gp.AddArc(r.X + r.Width - diameter, r.Y + r.Height - diameter, diameter, diameter, 0, 90);
            // Create an arc in the bottom right
            gp.AddArc(r.X, r.Y + r.Height - diameter, diameter, diameter, 90, 90);
            c.Region = new Region(gp);
        }

        public static string GetAppdataFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "passguard");
        }

        #region randNumber
        public static int Rand(int minValue, int maxExclusiveValue)
        {
            if (minValue >= maxExclusiveValue)
                throw new ArgumentOutOfRangeException("minValue must be lower than maxExclusiveValue");

            long diff = (long)maxExclusiveValue - minValue;
            long upperBound = uint.MaxValue / diff * diff;

            uint ui;
            do
            {
                ui = GetRandomUInt();
            } while (ui >= upperBound);
            return (int)(minValue + (ui % diff));
        }

        private static uint GetRandomUInt()
        {
            var randomBytes = GenerateRandomBytes(sizeof(uint));
            return BitConverter.ToUInt32(randomBytes, 0);
        }

        private static byte[] GenerateRandomBytes(int bytesNumber)
        {
            byte[] buffer = new byte[bytesNumber];
            csp.GetBytes(buffer);
            return buffer;
        }
        #endregion


        /// <summary>
        /// Now, you only need one function for switching windows.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        public static void SwitchTo<T>(Panel Content, object[] args = null) where T : UserControl
        {
            Control topControl = Content.Controls[0];

            //Creates a new UserControl from T. 
            UserControl control = (UserControl)Activator.CreateInstance(typeof(T), args ?? new object[] { });
            control.Dock = DockStyle.Fill;

            // If the window on the top is different:
            if (topControl.GetType() != control.GetType())
            {
                foreach (Control x in topControl.Controls) { x.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(control);
            }
        }

        /// <summary>
        /// Hides all scrollbars on a control. AutoScroll property must be set to false
        /// </summary>
        public static void HideScrollbars(Panel p)
        {
            p.VerticalScroll.Maximum = 0;
            p.AutoScroll = false;
            p.HorizontalScroll.Visible = false;
            p.AutoScroll = true;
        }

        public static void HideScrollbars(UserControl uc)
        {
            uc.VerticalScroll.Maximum = 0;
            uc.AutoScroll = false;
            uc.HorizontalScroll.Visible = false;
            uc.AutoScroll = true;
        }

        // Returns every word in capital
        public static string ToTitleCase(string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.ToLower());
        }
    }
}
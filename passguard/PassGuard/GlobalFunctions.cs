using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PassGuard
{
    public static class GlobalFunctions
    {
        public const int ROUND_DIAMETER = 15;

        /// <summary>
        /// Round all them corners boi
        /// </summary>
        /// <param name="c">Control to round</param>
        /// <param name="diameter">The diameter of the roundness</param>
        public static void RoundCorners(Control c, int diameter=ROUND_DIAMETER)
        {
            Rectangle r = new Rectangle(0, 0, c.Width, c.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
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

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}
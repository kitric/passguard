using PassGuard.UserControls;
using System.Drawing;
using System.Windows.Forms;

namespace PassGuard
{
    public partial class MainScreen : Form
    {
        const int roundDiameter = 15;

        public MainScreen()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(Home, roundDiameter);
            GlobalFunctions.RoundCorners(Passwords, roundDiameter);
            GlobalFunctions.RoundCorners(GeneratePassword, roundDiameter);
            GlobalFunctions.RoundCorners(About, roundDiameter);

            this.Content.Controls.Add(new HomePage() { Dock = DockStyle.Fill });
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            if (topControl.GetType() != typeof(HomePage))
            {
                Content.Controls.Clear();

                //Disposes all components, in order to boost performance.
                foreach (Control control in topControl.Controls) { control.Dispose(); }

                Content.Controls.Add(new HomePage() { Dock = DockStyle.Fill });
            }
        }

        private void Passwords_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(Passwords))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }

                Content.Controls.Clear();
                Content.Controls.Add(new Passwords() { Dock = DockStyle.Fill });
            }
        }

        private void GeneratePassword_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(PageNotImplemented))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }

                Content.Controls.Clear();
                Content.Controls.Add(new PageNotImplemented() { Dock = DockStyle.Fill });
            }
        }

        private void About_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(PageNotImplemented))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }

                Content.Controls.Clear();
                Content.Controls.Add(new PageNotImplemented() { Dock = DockStyle.Fill });
            }
        }
    }
}

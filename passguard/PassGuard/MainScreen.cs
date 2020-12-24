using PassGuard.UserControls;
using System.Windows.Forms;

namespace PassGuard
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            this.Content.Controls.Add(new HomePage());
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            if (topControl.GetType() != typeof(HomePage))
            {
                Content.Controls.Clear();

                //Disposes all components, in order to boost performance.
                foreach (Control control in topControl.Controls) { control.Dispose(); }

                Content.Controls.Add(new HomePage());
            }
        }

        private void Passwords_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(PageNotImplemented))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }

                Content.Controls.Clear();
                Content.Controls.Add(new PageNotImplemented());
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
                Content.Controls.Add(new PageNotImplemented());
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
                Content.Controls.Add(new PageNotImplemented());
            }
        }
    }
}

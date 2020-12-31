using PassGuard.Models;
using PassGuard.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PassGuard
{
    public partial class MainScreen : Form
    {
        const int roundDiameter = 15;

        public static List<PasswordInfo> passwords;

        public MainScreen()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(Home, roundDiameter);
            GlobalFunctions.RoundCorners(Passwords, roundDiameter);
            GlobalFunctions.RoundCorners(GeneratePassword, roundDiameter);
            GlobalFunctions.RoundCorners(About, roundDiameter);

            this.Content.Controls.Add(new HomePage(this) { Dock = DockStyle.Fill });
        }

        // Static constructor: used to instantiate static fields and to run code that must be executed ONLY once.
        static MainScreen()
        {
            DeserializePasswordInfos();
            Directory.CreateDirectory(GlobalFunctions.GetAppdataFolder());
        }

        #region events
        private void Home_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            if (topControl.GetType() != typeof(HomePage))
            {
                Content.Controls.Clear();

                //Disposes all components, in order to boost performance.
                foreach (Control control in topControl.Controls) { control.Dispose(); }
                topControl.Dispose();

                Content.Controls.Add(new HomePage(this) { Dock = DockStyle.Fill });
            }
        }

        private void Passwords_Click(object sender, System.EventArgs e)
        {
            AddPasswordScreen();
        }

        private void GeneratePassword_Click(object sender, System.EventArgs e)
        {
            AddGeneratorScreen();
        }

        private void About_Click(object sender, System.EventArgs e)
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(PageNotImplemented))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(new PageNotImplemented() { Dock = DockStyle.Fill });
            }
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerializePasswordInfos();
        }
        #endregion


        #region switch pages
        // Shows the password page
        public void AddPasswordScreen()
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(Passwords))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(new Passwords(this) { Dock = DockStyle.Fill });
            }
        }

        // Shows generator page
        public void AddGeneratorScreen()
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(PasswordGeneration))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(new PasswordGenerator() { Dock = DockStyle.Fill });
            }
        }

        public void Add_AddPasswordScreen()
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(AddPassword))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(new AddPassword() { Dock = DockStyle.Fill });
            }
        }

        public void AddPasswordViewerScreen(PasswordInfo password)
        {
            Control topControl = Content.Controls[0];

            //Since the page is yet to be created, it'll only verify if the page being shown is of type PageNotImplemented.
            if (topControl.GetType() != typeof(PasswordScreen))
            {
                foreach (Control control in topControl.Controls) { control.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(new PasswordScreen(password) { Dock = DockStyle.Fill });
            }
        }
        #endregion


        #region serialization
        // Serializes stuff to a .guard file, of course xD
        private static void SerializePasswordInfos()
        {
            string fpath = Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard");
            using (FileStream fs = new FileStream(fpath, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, passwords);
            }
        }

        // Deserializes stuff from a .guard file, of course xD
        private static void DeserializePasswordInfos()
        {
            string fpath = Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard");
            if (File.Exists(fpath))
            {
                using (FileStream fs = new FileStream(fpath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    passwords = (List<PasswordInfo>)formatter.Deserialize(fs);
                }

            } else // If the file doesn't exist, there's nothing to be deserialized, so a new instance is created.
            {
                passwords = new List<PasswordInfo>();
            }
        }
        #endregion

    }
}

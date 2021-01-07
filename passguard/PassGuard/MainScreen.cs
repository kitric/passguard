using PassGuard.Models;
using PassGuard.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace PassGuard
{
    public partial class MainScreen : Form
    {
        private readonly static string[] Scopes = { DriveService.Scope.DriveAppdata };
        public static DriveService driveService = new DriveService();

        public static List<PasswordInfo> passwords;

        private static bool loggedIn = false;

        public MainScreen()
        {
            InitializeComponent();

            GlobalFunctions.RoundCorners(Home);
            GlobalFunctions.RoundCorners(Passwords);
            GlobalFunctions.RoundCorners(GeneratePassword);
            GlobalFunctions.RoundCorners(About);

            DisableTabs();

            //this.Content.Controls.Add(new HomePage(this) { Dock = DockStyle.Fill });
            //If the user is logged in then load pages normally
            if (System.IO.File.Exists(Path.Combine(GlobalFunctions.GetAppdataFolder() + "\\token.json\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user")))
            {
                // Already signed in with gdrive
                LoginAccount();
            }
            else
            {
                // Show the login screen
                this.Content.Controls.Add(new Login(this) { Dock = DockStyle.Fill });
            }
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
            SwitchTo<Passwords>();
        }

        private void GeneratePassword_Click(object sender, System.EventArgs e)
        {
            SwitchTo<PasswordGenerator>(args: new object[] { });
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
        //Turns all the tabs to disabled
        public void DisableTabs()
        {
            Home.Enabled = false;
            Passwords.Enabled = false;
            GeneratePassword.Enabled = false;
            About.Enabled = false;
        }

        //Turns all the tabs to enabled
        public void EnableTabs()
        {
            Home.Enabled = true;
            Passwords.Enabled = true;
            GeneratePassword.Enabled = true;
            About.Enabled = true;
        }

        /// <summary>
        /// I FUCKING MADE IT. Now, you only need one function for switching windows.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        public void SwitchTo<T>(object[] args = null) where T : UserControl
        {
            Control topControl = Content.Controls[0];

            //Creates a new UserControl from T. 
            UserControl control = (UserControl)Activator.CreateInstance(typeof(T), args == null ? new object[] { this } : args);
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

            // if file exists, upload it.
            if (System.IO.File.Exists(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard")))
            {
                //Upload to drive
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = "passwd.guard",
                    Parents = new List<string>()
                    {
                        "appDataFolder"
                    }
                };
                FilesResource.CreateMediaUpload request;
                using (var stream = new System.IO.FileStream(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard"), System.IO.FileMode.Open))
                {
                    request = driveService.Files.Create(fileMetadata, stream, "application/json");
                    request.Fields = "id";
                    request.Upload();
                }
            }
        }

        // Deserializes stuff from a .guard file, of course xD
        private static async void DeserializePasswordInfos()
        {
            // Download the file
            if (loggedIn)
            {
                var file = GlobalFunctions.GetGDriveFile("passwd.gaurd");
                if (file != null)
                {
                    using (Stream stream = new FileStream(GlobalFunctions.GetAppdataFolder() + "\\passwd.guard", FileMode.Create, FileAccess.Write))
                    {
                        var req = driveService.Files.Get(file.Id);
                        await req.DownloadAsync(stream);
                    }
                }
            }

            string fpath = Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard");
            if (System.IO.File.Exists(fpath))
            {
                using (FileStream fs = new FileStream(fpath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    passwords = (List<PasswordInfo>)formatter.Deserialize(fs);
                }

            }
            else // If the file doesn't exist, there's nothing to be deserialized, so a new instance is created.
            {
                passwords = new List<PasswordInfo>();
            }
        }
        #endregion

        #region gdrive
        /// <summary>
        /// Logs in to the Google Drive using the token.json file.
        /// </summary>
        public void LoginAccount()
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = Path.Combine(GlobalFunctions.GetAppdataFolder() + "\\token.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = GlobalFunctions.ApplicationName
            });

            loggedIn = true;

            if (Properties.Settings.Default.MasterPassword == "")
            {
                // Set master pw
                Content.Controls.Clear();
                this.Content.Controls.Add(new SetMasterPassword(this) { Dock = DockStyle.Fill });
            }
            else
            {
                // Show master pw screen
                this.Content.Controls.Add(new MasterPassword(this) { Dock = DockStyle.Fill });
            }
        }
        #endregion

    }
}

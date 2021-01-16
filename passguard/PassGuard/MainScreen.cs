using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using PassGuard.Models;
using PassGuard.Properties;
using PassGuard.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGuard
{
    public partial class MainScreen : Form
    {
        #region fields
        private readonly static string[] Scopes = { DriveService.Scope.DriveAppdata };
        public static DriveService driveService = new DriveService();

        internal static UserData Data = new UserData();
        private static bool loggedIn = false;

        public static MainScreen Instance;
        #endregion

        public MainScreen()
        {
            InitializeComponent();

            foreach (Control x in this.Sidebar.Controls)
            {
                if (x.GetType() != typeof(PictureBox))
                {
                    GlobalFunctions.RoundCorners(x);
                }
            }

            Instance = this;

            DisableTabs();

            //this.Content.Controls.Add(new HomePage(this) { Dock = DockStyle.Fill });
            //If the user is logged in then load pages normally
            if (File.Exists(Path.Combine(GlobalFunctions.GetAppdataFolder() + "\\token.json\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user")))
            {
                // Already signed in with gdrive
                LoginAccount();
                DeserializePasswordInfos();

                SetOrEnterMasterPassword();
            }
            else
            {
                // Show the login screen
                this.Content.Controls.Add(new Login() { Dock = DockStyle.Fill });
            }

            ApplyTheme();
            Console.WriteLine(Data.MasterPassword);
        }


        // Static constructor: used to instantiate static fields and to run code that must be executed ONLY once.
        static MainScreen()
        {
            Directory.CreateDirectory(GlobalFunctions.GetAppdataFolder());
        }

        private void ApplyTheme()
        {
            switch (Data.Theme)
            {
                case Theme.TECHNO_DARK:
                    this.BackColor = Color.FromArgb(15, 17, 26);

                    this.HomeBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.GeneratePasswordBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.AboutBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.PasswordsBtn.BackColor = Color.FromArgb(193, 25, 26);

                    this.Sidebar.BackColor = Color.FromArgb(9, 11, 16);

                    break;
                case Theme.TECHNO_LIGHT:
                    this.BackColor = Color.FromArgb(242, 242, 242);

                    this.HomeBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.GeneratePasswordBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.AboutBtn.BackColor = Color.FromArgb(193, 25, 26);
                    this.PasswordsBtn.BackColor = Color.FromArgb(193, 25, 26);

                    this.Logo.Image = Resources.icon_dark;
                    this.settingsBtn.Image = Resources.settings_dark;

                    this.Sidebar.BackColor = Color.FromArgb(200, 255, 255);

                    break;
                case Theme.CONTRAST_DARK:
                    this.BackColor = Color.FromArgb(5, 5, 5);

                    this.HomeBtn.BackColor = Color.White;
                    this.GeneratePasswordBtn.BackColor = Color.White;
                    this.AboutBtn.BackColor = Color.White;
                    this.PasswordsBtn.BackColor = Color.White;

                    this.HomeBtn.ForeColor = Color.Black;
                    this.GeneratePasswordBtn.ForeColor = Color.Black;
                    this.AboutBtn.ForeColor = Color.Black;
                    this.PasswordsBtn.ForeColor = Color.Black;

                    this.Sidebar.BackColor = Color.Black;

                    break;
            }

            this.settingsBtn.BackColor = Sidebar.BackColor;


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

                Content.Controls.Add(new HomePage() { Dock = DockStyle.Fill });
            }
        }

        private void Passwords_Click(object sender, System.EventArgs e)
        {
            GlobalFunctions.SwitchTo<Passwords>(this.Content);
        }

        private void GeneratePassword_Click(object sender, System.EventArgs e)
        {
            GlobalFunctions.SwitchTo<PasswordGenerator>(this.Content, args: new object[] { });
        }

        private void About_Click(object sender, System.EventArgs e)
        {
            GlobalFunctions.SwitchTo<About>(this.Content, args: new object[] { });
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerializePasswordInfos();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<SettingsPage>(this.Content);
        }
        #endregion


        #region switch pages
        public void SetOrEnterMasterPassword()
        {

            this.Content.Controls.Clear();
            UserControl control = string.IsNullOrEmpty(Data.MasterPassword) ? (UserControl)new SetMasterPassword(this) { Dock = DockStyle.Fill } :
                new MasterPassword(this) { Dock = DockStyle.Fill };

            this.Content.Controls.Add(control);
        }

        //Turns all the tabs to disabled
        public void DisableTabs()
        {
            HomeBtn.Enabled = false;
            PasswordsBtn.Enabled = false;
            GeneratePasswordBtn.Enabled = false;
            AboutBtn.Enabled = false;
            settingsBtn.Enabled = false;
        }

        //Turns all the tabs to enabled
        public void EnableTabs()
        {
            HomeBtn.Enabled = true;
            PasswordsBtn.Enabled = true;
            GeneratePasswordBtn.Enabled = true;
            AboutBtn.Enabled = true;
            settingsBtn.Enabled = true;
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
                formatter.Serialize(fs, Data);
            }

            // if the file exists, upload it.
            if (File.Exists(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard")))
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
                using (var stream = new FileStream(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard"), FileMode.Open))
                {
                    request = driveService.Files.Create(fileMetadata, stream, "application/json");
                    request.Fields = "id";
                    request.Upload();
                }

                File.Delete(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard"));
            }
        }

        // Deserializes stuff from a .guard file, of course xD
        private void DeserializePasswordInfos()
        {
            // Download the file
            if (loggedIn)
            {
                var file = GetGDriveFile("passwd.guard");
                if (file != null)
                {
                    using (Stream stream = new FileStream(GlobalFunctions.GetAppdataFolder() + "\\passwd.guard", FileMode.Create, FileAccess.Write))
                    {
                        var req = driveService.Files.Get(file.Id);
                        req.Download(stream);
                    }
                }
            }

            string fpath = Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard");
            if (File.Exists(fpath))
            {
                using (FileStream fs = new FileStream(fpath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Data = (UserData)formatter.Deserialize(fs);
                }

            }
            else // If the file doesn't exist, there's nothing to be deserialized, so a new instance is created.
            {
                Data = new UserData();
            }

            System.IO.File.Delete(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard"));
        }
        #endregion

        #region gdrive
        /// <summary>
        /// Logs in to Google Drive using the token.json file.
        /// </summary>
        public static void LoginAccount()
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
        }

        /// <summary>
        /// Gets a file from Google Drive if it exists.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Google.Apis.Drive.v3.Data.File GetGDriveFile(string fileName)
        {
            var request = driveService.Files.List();
            request.Spaces = "appDataFolder";
            request.Fields = "nextPageToken, files(id, name)";
            request.PageSize = 10;
            var result = request.Execute();
            foreach (var file in result.Files)
            {
                Console.WriteLine(file.Name);
                if (file.Name == fileName)
                {
                    return file;
                }
            }
            return null;
        }
        #endregion
    }
}

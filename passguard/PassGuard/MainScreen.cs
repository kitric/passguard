﻿using GitHubUpdate;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
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
using System.Windows.Forms;

namespace PassGuard
{
    public partial class MainScreen : Form
    {
        #region fields
        private readonly static string[] Scopes = { DriveService.Scope.DriveAppdata };
        public static DriveService driveService = new DriveService();
        public static User user;

        internal static UserData Data = new UserData();
        public static bool loggedIn = false;

        public static MainScreen Instance;

        private static bool errored = false;
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

            //If the user is logged in then load pages normally
            if (System.IO.File.Exists(Path.Combine(GlobalFunctions.GetAppdataFolder() + "\\token.json\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user")))
            {
                // Already signed in with gdrive
                LoginAccount();
            }
            else
            {
                // Show the login screen
                this.Content.Controls.Add(new Login() { Dock = DockStyle.Fill });
            }

            ApplyTheme();
        }

        // Static constructor: used to instantiate static fields and to run code that must be executed ONLY once.
        static MainScreen()
        {
            Directory.CreateDirectory(GlobalFunctions.GetAppdataFolder());
            UpdateIfNeeded();
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
                case Theme.CONTRAST_LIGHT:
                    this.BackColor = Color.FromArgb(250, 250, 250);

                    this.HomeBtn.BackColor = Color.Black;
                    this.GeneratePasswordBtn.BackColor = Color.Black;
                    this.AboutBtn.BackColor = Color.Black;
                    this.PasswordsBtn.BackColor = Color.Black;

                    this.HomeBtn.ForeColor = Color.White;
                    this.GeneratePasswordBtn.ForeColor = Color.White;
                    this.AboutBtn.ForeColor = Color.White;
                    this.PasswordsBtn.ForeColor = Color.White;

                    this.Sidebar.BackColor = Color.White;

                    this.Logo.Image = Resources.icon_dark;
                    this.settingsBtn.Image = Resources.settings_dark;

                    break;
            }

            this.settingsBtn.BackColor = Sidebar.BackColor;
        }

        #region events
        private void Home_Click(object sender, System.EventArgs e)
        {
            GlobalFunctions.SwitchTo<HomePage>(this.Content, args: new object[] { });
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
            GlobalFunctions.SwitchTo<UserControls.About>(this.Content, args: new object[] { });
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            GlobalFunctions.SwitchTo<SettingsPage>(this.Content);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            if (errored)
            {
                this.Close();
            }
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SerializePasswordInfos();

            // Cancels the event: The app is not closed.
            e.Cancel = !GlobalFunctions.Close;
        }


        private void STrayManager_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Calling Hide() is the same as setting Visible to false.
                    if (!this.Visible)
                    {
                        this.Show();
                    }
                    break;

                // This is when the contextMenu should appear. appears.
                case MouseButtons.Right:
                    STrayManager.ContextMenu = GetSystemTrayMenu();
                    break;
            }


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
        public static void SerializePasswordInfos()
        {
            if (System.IO.File.Exists(Path.Combine(GlobalFunctions.GetAppdataFolder() + "\\token.json\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user")))
            {
                string fpath = Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard");
                using (FileStream fs = new FileStream(fpath, FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, Data);
                }

                try
                {
                    // if the file exists, upload it.
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
                        using (var stream = new FileStream(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard"), FileMode.Open))
                        {
                            request = driveService.Files.Create(fileMetadata, stream, "application/json");
                            request.Fields = "id";
                            request.Upload();
                        }

                        System.IO.File.Delete(Path.Combine(GlobalFunctions.GetAppdataFolder(), "passwd.guard"));

                    }
                }
                catch
                {
                    MessageBox.Show("There was an error.\nPlease check your internet connection.", "Error", MessageBoxButtons.OK);

                    Application.Exit();
                }
            }
        }

        // Deserializes stuff from a .guard file, of course xD
        public static void DeserializePasswordInfos()
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
            if (System.IO.File.Exists(fpath))
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
            try
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

                var request = driveService.About.Get();
                request.Fields = "user";
                user = request.Execute().User;

                loggedIn = true;

                DeserializePasswordInfos();
                Instance.SetOrEnterMasterPassword();
            }
            catch
            {
                if (!errored)
                {
                    MessageBox.Show("There was an error. Please check your internet connection.", "Error");
                    errored = true;
                }
            }
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
                if (file.Name == fileName)
                {
                    return file;
                }
            }
            return null;
        }
        #endregion


        #region Helper Functions
        /// <summary>
        /// This probably doesn't even work xD
        /// </summary>
        /// <returns></returns>
        private static void UpdateIfNeeded()
        {
            try
            {
                var checker = new UpdateChecker("kitric", "passguard");

                if (checker.CheckUpdate().Result != UpdateType.None)
                {
                    var result = new UpdateNotifyDialog(checker).ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        checker.DownloadAsset("passguard.msi");
                    }
                }
            }
            catch
            {
                if (!errored)
                {
                    MessageBox.Show("There was an error. Please check your internet connection.", "Error");
                    errored = true;
                }
            }
        }

        internal ContextMenu GetSystemTrayMenu()
        {
            ContextMenu menu = new ContextMenu();

            MenuItem viewPasswords = new MenuItem("View Passwords");
            viewPasswords.Click += ViewPasswords_Click;
            menu.MenuItems.Add(viewPasswords);

            MenuItem addPassword = new MenuItem("Add Password");
            addPassword.Click += AddPassword_Click;
            menu.MenuItems.Add(addPassword);

            MenuItem settings = new MenuItem("Settings");
            settings.Click += Settings_Click;
            menu.MenuItems.Add(settings);

            MenuItem exit = new MenuItem("Quit Passguard");
            exit.Click += Exit_Click;
            menu.MenuItems.Add(exit);

            return menu;
        }

        #endregion

        // I know this code is too repetitive
        #region SystemTrayMenuEvents
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.STrayManager.Visible = false;
            SerializePasswordInfos();
            Environment.Exit(0);
        }

        private void AddPassword_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }

            // Only if masterPassword has been entered.
            if (GlobalFunctions.Validated)
            {
                GlobalFunctions.SwitchTo<AddPassword>(Content);
            }
        }

        private void ViewPasswords_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }

            if (GlobalFunctions.Validated)
            {
                GlobalFunctions.SwitchTo<Passwords>(Content);
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }

            if (GlobalFunctions.Validated)
            {
                GlobalFunctions.SwitchTo<SettingsPage>(Content);
            }
        }

        #endregion
    }
}

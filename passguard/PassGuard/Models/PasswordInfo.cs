using System;

namespace PassGuard.Models
{
    [Serializable]
    public class PasswordInfo
    {
        // The password after its been encrypted, dumbo
        public string PasswordAfterEncrypt { get; set; }

        // Name of the service eg, Discord
        public string Name { get; set; }

        // Either Image url, or the image file name, idk
        public string ImageURL { get; set; }

        // The url of the website, preferably for to the login page
        public string LoginURL { get; set; }

        public byte[] Key { get; set; }


        public PasswordInfo(string passwdAfterEncrypt, string name, string url, byte[] key, string imageURL = "")
        {
            this.PasswordAfterEncrypt = passwdAfterEncrypt;
            this.Name = name;
            this.ImageURL = imageURL;
            this.Key = key;
            this.LoginURL = url;
        }
    }
}

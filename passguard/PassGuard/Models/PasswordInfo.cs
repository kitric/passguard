using System;

namespace PassGuard.Models
{
    /// <summary>
    /// Like, you gotta store that password in this class, man
    /// </summary>
    /// 
    [Serializable]
    public class PasswordInfo
    {

        public PasswordInfo(string passwdAfterEncrypt, string name, string url, byte[] key, string image="")
        {
            this.PasswordAfterEncrypt = passwdAfterEncrypt;
            this.Name = name;
            this.Image = image;
            this.Key = key;
            this.LoginURL = url;
        }

        // The password after its been encrypted, dumbo
        public string PasswordAfterEncrypt { get; set; }

        // Name of the service eg, Discord
        public string Name { get; set; }

        // Either Image url, or the image file name, idk
        public string Image { get; set; }

        // The url of the website, preferably for to the login page
        public string LoginURL { get; set; }

        public byte[] Key { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace PassGuard.Models
{
    [Serializable]
    public class UserData
    {
        public List<PasswordInfo> passwords;
        public string MasterPassword;
        public Theme Theme;

        public UserData()
        {
            MasterPassword = "";
            passwords = new List<PasswordInfo>();
            Theme = Theme.DEFAULT;
        }
    }
}

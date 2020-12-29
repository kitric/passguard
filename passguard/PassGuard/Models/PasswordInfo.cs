using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGuard.Models
{
    /// <summary>
    /// Like, you gotta store that password in this class, man
    /// </summary>
    public class PasswordInfo
    {
        // The password after its been encrypted, dumbo
        public string PasswordAfterEncrypt { get; set; }

        // Name of the service eg, Discord
        public string Name { get; set; }

        // Either Image url, or the image file name, idk
        public string Image { get; set; }

        // The url of the website, preferably for to the login page
        public string LoginURL { get; set; }
    }
}

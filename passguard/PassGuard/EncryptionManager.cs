using System;
using System.Security.Cryptography;
using System.Text;

namespace PassGuard
{
    public static class EncryptionManager
    {
        private static readonly MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        /// <summary>
        /// Returns an encrypted string, ya dummy.
        /// </summary>
        /// <param name="originalString"></param>
        /// <returns></returns>
        public static string Encrypt(string originalString)
        {

            //The object used to encrypt/decrypt md5 hashes.
            using(var tdes = new TripleDESCryptoServiceProvider())
            {

                byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(originalString));

                //A key is like a password required for decrypting a string after encrypting it.
                tdes.Key = result;
                tdes.Mode = CipherMode.ECB; //CipherMode.CBC didn't work, but ECB works.
                tdes.Padding = PaddingMode.PKCS7;

                //The actual encryptor.
                using (var encryptor = tdes.CreateEncryptor())
                {
                    byte[] data = Encoding.UTF8.GetBytes(originalString);
                    byte[] bytes = encryptor.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(bytes);
                }
            }
        }

        internal static byte[] GetKey(string str)
        {
            return md5.ComputeHash(Encoding.UTF8.GetBytes(str));
        }


        /// <summary>
        /// Returns the decrypted string from its cipher (value returned by Encrypt) and its key, dummy.
        /// </summary>
        /// <param name="cipher"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string cipher, byte[] key)
        {
            using (var tdes = new TripleDESCryptoServiceProvider())
            {
                tdes.Key = key;
                tdes.Mode = CipherMode.ECB; //CipherMode.CBC didn't work, but ECB works.
                tdes.Padding = PaddingMode.PKCS7;

                //Performs the actualy decryption.
                using (var decryptor = tdes.CreateDecryptor())
                {
                    byte[] cipherBytes = Convert.FromBase64String(cipher);
                    byte[] data = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);


                    return Encoding.UTF8.GetString(data);
                }
            }
        }
    }
}

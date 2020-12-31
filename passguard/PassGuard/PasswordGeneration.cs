using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGuard
{
    public static class PasswordGeneration
    {
        private static readonly Random randGenerator = new Random();

        public static string GeneratePassword(int len)
        {
            StringBuilder passwd = GenerateString(len);

            AddNumbers(passwd);
            FlushPassword(passwd);

            AddSpecialCharacters(passwd);
            FlushPassword(passwd);

            return passwd.ToString();
        }

        private static StringBuilder GenerateString(int len)
        {
            StringBuilder passwd = new StringBuilder(len);

            for (int i = 0; i < passwd.Capacity; i++) //Fills the stringBuilder entirely with letters.
            {
                passwd.Append((char)randGenerator.Next(97, 123));
            }

            return passwd;
        }
        private static void AddNumbers(StringBuilder passwd)
        {
            //Determines a random number between 3 (inclusive) and 7 (exclusive).
            int numberAmount = randGenerator.Next(passwd.Length / 2 - 3, passwd.Length / 2 + 1);

            for (int i = 0; i < numberAmount; i++)
            {
                //48 is the ASCII value for 0 and 57 is the ASCII value for 9
                int rand = randGenerator.Next(48, 58);
                passwd[i] = (char)rand;
            }
        }
        private static void AddSpecialCharacters(StringBuilder passwd)
        {
            int charAmount = randGenerator.Next(passwd.Length / 4, passwd.Length / 2 + 1);

            for (int i = 0; i < charAmount; i++)
            {
                //33 (!) to 47 (/)
                char rand = (char)randGenerator.Next(33, 48);

                //Generating a random index, then replacing the character at that index with rand.
                passwd[i] = rand;
            }
            passwd.Replace('\"', '_');

        }
        private static void FlushPassword(StringBuilder passwd)
        {
            //Shuffles everything.
            for (int i = 0; i < passwd.Length; i++)
            {
                int randIndex = randGenerator.Next(0, passwd.Length);

                //Interchange
                char temp = passwd[randIndex];
                passwd[randIndex] = passwd[i];
                passwd[i] = temp;
            }
        }
    }
}

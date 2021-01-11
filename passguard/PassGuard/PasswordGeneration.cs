using System;
using System.Text;

namespace PassGuard
{
    public static class PasswordGeneration
    {
        public const string NON_ALPHANUM_CHARACTERS = "$!%&#|/?@";
        public const string LETTERS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";


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

            int prev = -1; // Keeps track of the previously generated random number.
            for (int i = 0; i < passwd.Capacity; i++) //Fills the stringBuilder entirely with letters.
            {
                int rand = GlobalFunctions.Rand(0, LETTERS.Length);
                
                // Generate a random number till that number is different than the previous one.
                while (rand == prev)
                {
                    rand = GlobalFunctions.Rand(0, LETTERS.Length);
                }

                passwd.Append(LETTERS[rand]);
                prev = rand;
            }

            return passwd;
        }
        
        private static void AddNumbers(StringBuilder passwd)
        {
            //Determines a random number between half of the password length - 3 (inclusive)
            //and half of the password length + 1 (exclusive)
            int numberAmount = GlobalFunctions.Rand(passwd.Length / 2 - 3, passwd.Length / 2 + 1);

            for (int i = 0; i < numberAmount; i++)
            {
                //48 is the ASCII value for 0 and 57 is the ASCII value for 9
                int rand = GlobalFunctions.Rand(48, 58);
                passwd[i] = (char)rand;
            }
        }

        private static void AddSpecialCharacters(StringBuilder passwd)
        {
            int charAmount = GlobalFunctions.Rand(passwd.Length / 4, passwd.Length / 2 + 1);

            int prev = -1;
            for (int i = 0; i < charAmount; i++)
            {
                int rand = GlobalFunctions.Rand(0, NON_ALPHANUM_CHARACTERS.Length);

                // Generate a random number till that number is different than the previous one.
                while (rand == prev)
                {
                    rand = GlobalFunctions.Rand(0, NON_ALPHANUM_CHARACTERS.Length);
                }

                // Generating a random index, then replacing the character at that index with rand.
                passwd[i] = NON_ALPHANUM_CHARACTERS[rand];
                prev = rand;
            }
        }

        private static void FlushPassword(StringBuilder passwd)
        {
            //Shuffles everything.
            for (int i = 0; i < passwd.Length; i++)
            {
                int randIndex = GlobalFunctions.Rand(0, passwd.Length);

                //Interchange
                char temp = passwd[randIndex];
                passwd[randIndex] = passwd[i];
                passwd[i] = temp;
            }
        }
    }
}

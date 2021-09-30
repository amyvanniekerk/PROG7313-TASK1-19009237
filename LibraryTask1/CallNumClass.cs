using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask1
{
    class CallNumClass
    {
        private readonly Random random = new Random();

        // Generates a random number within a specfic range   
        public int RandomNumbersCalled(int min, int max)
        {
            return random.Next(min, max);
        }

        // Generates a random string with a given size.    
        public string RandomString(int size, bool lowerCase)
        {
            var stringGenerator = new StringBuilder(size);

            // CODE TAKEN FROM : https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/

            char offset = lowerCase ? 'a' : 'A';
            var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var newChar = new char[3];
            var randomChar = new Random();

            for (int i = 0; i < newChar.Length; i++)
            {
                newChar[i] = letters[randomChar.Next(letters.Length)];
            }

            // END OF ATTRIBUTION 

            var resChar = new string(newChar);
            return resChar;
        }

        public CallNumbers RanCallNum()
        {
            var libraryBuilder = new StringBuilder();

            return new CallNumbers(RandomNumbersCalled(100, 999), RandomString(3, false));
        }
    }
}

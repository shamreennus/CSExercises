using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //a
            int len;
            char eachChar =' ';            
            TotalVowel(out len, out eachChar);

            //b
            eachChar = Vowels(len, eachChar);          
            Console.Read();
        }

        private static char Vowels(int len, char eachChar)
        {
            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0, startChar2 = 1;

            Console.Write("Please enter the phrase :");
            string phrase2 = Console.ReadLine();

            while (startChar2 < phrase2.Length)
            {
                eachChar = Convert.ToChar(phrase2.Substring(startChar2, len));
                if (eachChar.Equals('a'))
                {
                    aCount++;

                }
                else if (eachChar.Equals('e'))
                {
                    eCount++;
                }
                else if (eachChar.Equals('i'))
                {
                    iCount++;
                }
                else if (eachChar.Equals('o'))
                {
                    oCount++;
                }
                else if (eachChar.Equals('u'))
                {
                    uCount++;
                }
                startChar2++;
            }
            Console.WriteLine("Number of a :" + aCount);
            Console.WriteLine("Number of e :" + eCount);
            Console.WriteLine("Number of i :" + iCount);
            Console.WriteLine("Number of o :" + oCount);
            Console.WriteLine("Number of u :" + uCount);
            return eachChar;
        }

        private static void TotalVowel(out int len, out char eachChar)
        {
            int startChar = 0;
            len = 1;
            int vowelCount = 0;



            Console.Write("Please enter the phrase :");
            string phrase = Console.ReadLine();

            while (startChar < phrase.Length)
            {
                eachChar = Convert.ToChar(phrase.Substring(startChar, len));
                if (eachChar.Equals('a') || eachChar.Equals('e') || eachChar.Equals('i') || eachChar.Equals('o') || eachChar.Equals('u'))
                {
                    vowelCount++;

                }
                startChar++;
            }

            Console.WriteLine("Total number of vowels :" + vowelCount);
            eachChar = ' ';
        }
    }
}

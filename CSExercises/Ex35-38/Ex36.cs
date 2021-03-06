using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {            
            WordPalindrome();          
            PhrasePalindrome();
            Console.Read();
        }

        private static void PhrasePalindrome()
        {
            Console.Write("Enter a phrase : ");
            string phrase2 = Console.ReadLine();
            bool isPalin2 = true;


            int min2 = 0;
            int max2 = phrase2.Length - 1;

            while (max2 > 0)
            {
                char a2 = Convert.ToChar(phrase2.Substring(min2, 1));
                char b2 = Convert.ToChar(phrase2.Substring(max2, 1));

                while (!char.IsLetterOrDigit(a2))
                {

                    min2++;
                    if (min2 > max2)
                    {
                        isPalin2 = true;
                    }
                    else
                    {

                        isPalin2 = false;
                    }
                    a2 = Convert.ToChar(phrase2.Substring(min2, 1));
                }

                while (!char.IsLetterOrDigit(b2))
                {

                    max2--;
                    if (min2 > max2)
                    {
                        isPalin2 = true;
                    }
                    else
                    {

                        isPalin2 = false;
                    }
                    b2 = Convert.ToChar(phrase2.Substring(max2, 1));
                }



                if (char.ToLower(a2) == char.ToLower(b2))
                {
                    isPalin2 = true;
                }
                else
                {
                    isPalin2 = false;
                }
                min2++;
                max2--;
            }

            if (isPalin2)
                Console.WriteLine("'{0}' is Palindrome", phrase2);
            else
                Console.WriteLine("'{0}' is NOT Palindrome", phrase2);
        }

        private static void WordPalindrome()
        {
            Console.Write("Enter a word : ");
            string phrase = Console.ReadLine();
            bool isPalin = true;

            int min = 0;
            int max = phrase.Length - 1;

            while (max > 0)
            {
                char a = Convert.ToChar(phrase.Substring(min, 1));
                char b = Convert.ToChar(phrase.Substring(max, 1));
                if (char.ToLower(a) == char.ToLower(b))
                {
                    isPalin = true;
                }
                else
                {
                    isPalin = false;
                }
                min++;
                max--;
            }

            if (isPalin)
                Console.WriteLine("{0} is Palindrome", phrase);
            else
                Console.WriteLine("{0} is NOT Palindrome", phrase);
        }
    }
}

using System;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Phrase :");
            string  s = Console.ReadLine();

            Console.Write("Which Character to replace ? :");
            char  c1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Replace with new char :");
            char c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("After Substitution : {0}", Substitute(s, c1, c2));
            Console.ReadLine();


        }

        public static string Substitute(string s, char c1, char c2)
        {
            string retVal = string.Empty;
            retVal = s.Replace(c1, c2);
            return retVal;
        }
    }
}

using System;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter String  1:");
            string s1 = Console.ReadLine();
            Console.Write("Enter String  2:");
            string s2 = Console.ReadLine();
            Console.WriteLine("S2 occurs in S1? :{0}",InString(s1, s2));
            Console.ReadLine();

        }


        public static bool InString(string s1, string s2)
        {
            bool Val = false;
            if (s1.Contains(s2))
                Val = true;
            else
                Val = false;


            return Val;
        }
    }
}

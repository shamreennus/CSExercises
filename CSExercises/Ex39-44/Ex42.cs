using System;

namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter String  1:");
            string s1 = Console.ReadLine();
            Console.Write("Enter String  2:");
            string s2 = Console.ReadLine();

            int pos = FindWord(s1, s2);
            if(pos==-1)
                Console.WriteLine("S2 not found in S1");
            else
                Console.WriteLine("S2 Position in S1? :{0}", pos);


            Console.ReadLine();
        }

        public static int FindWord(string s1, string s2)
        {
            int position =-1;
            if (s1.Contains(s2))
            {
                position = s1.IndexOf(s2);                
            }
            return position;
        }
    }
}


using System;
using System.Linq;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double val;
            Console.WriteLine(string.Concat(Enumerable.Repeat('-',50)));
            Console.WriteLine("No\tInverse\t\tSquare_Root\tSquare");
            Console.WriteLine(string.Concat(Enumerable.Repeat('-', 50)));

            for (int i = 1; i < 11; i++)
            {
                val = Convert.ToDouble(i);
                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}",Math.Round(val,1), Math.Round(1/val,3),Math.Round(Math.Sqrt(val),3),Math.Round(Math.Pow(val, 2),1));
            }
                Console.Read();
        }
    }
}

using System;
using System.Linq;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            double x,y;
                        
            Console.WriteLine("X\t\t\tY");
            Console.WriteLine(string.Concat(Enumerable.Repeat('-', 50)));
                       
            
            for(int i=-5;i<5;i++)
            {
                x = Convert.ToDouble(i);
                y = (double)((2 * Math.Pow(x, 2)) - (4 * x) + 3);
                Console.WriteLine("{0:0.0}\t\t\t{1:0.0}",x, y);
            }

            for (int i = -5; i < 5; i++)
            {
                x = Convert.ToDouble(i);
                y = (double)((2 * Math.Pow(x, 2)) - (4 * x) + 3);                
                Console.WriteLine("{0} {1}TotalTimes",string.Concat(Enumerable.Repeat('*',Convert.ToInt32(y))),y);
            }


            Console.Read();
        }
    }
}

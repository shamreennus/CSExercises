using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square Root of numbers between 1 and 25");
            for(int i=1;i<=25;i++)
            {
                Console.WriteLine("SQRT of {0} is {1}",i, SQT(i));

            }
            Console.ReadLine();
        }

        public static double SQT(int y)
        {
            double mSqrt = Math.Sqrt(Convert.ToDouble(y));
            return mSqrt;
        }
    }
}

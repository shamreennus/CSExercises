using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount");
            double amt = Convert.ToDouble(Console.ReadLine());
            amt = (Math.Ceiling(amt * 20) / 20) * 100;
            int amt1 = Convert.ToInt32(amt);

            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;

            if (amt1 >= 100) //to check how many 100's are present
            {
                c1 = amt1 / 100;
            }
            if ((amt1 - (100 * c1)) >= 50 && (amt1 - (100 * c1)) < 100) //to check how many 50's are present
            {
                c2 = (amt1 - (100 * c1)) / 50;
            }
            if ((amt1 - (100 * c1) - (50 * c2)) >= 20 && (amt1 - (100 * c1) - (50 * c2)) < 50) //to check how many 20;s are present
            {
                c3 = (amt1 - (100 * c1) - (50 * c2)) / 20;
            }
            if ((amt1 - (100 * c1) - (50 * c2) - (20 * c3)) >= 10 && (amt1 - (100 * c1) - (50 * c2) - (20 * c3)) < 20) //to check how many 10's are present
            {
                c4 = (amt1 - (100 * c1) - (50 * c2) - (20 * c3)) / 10;
            }
            if ((amt1 - (100 * c1) - (50 * c2) - (20 * c3) - (10 * c4)) >= 5 && (amt1 - (100 * c1) - (50 * c2) - (20 * c3) - (10 * c4)) < 10) //to check how many 5's are present
            {
                c5 = (amt1 - (100 * c1) - (50 * c2) - (20 * c3) - (10 * c4)) / 5;
            }

            if (c1 > 0)
            {
                for (int i = 0; i < c1; i++)
                {
                    Console.WriteLine("100c");
                }
            }
            if (c2 > 0)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.WriteLine("50c");
                }
            }
            if (c3 > 0)
            {
                for (int k = 0; k < c3; k++)
                {
                    Console.WriteLine("20c");
                }
            }
            if (c4 > 0)
            {
                for (int l = 0; l < c4; l++)
                {
                    Console.WriteLine("10c");
                }
            }
            if (c5 > 0)
            {
                for (int m = 0; m < c5; m++)
                {
                    Console.WriteLine("5c");
                }
            }
            Console.Read();
        }
        

    }
}

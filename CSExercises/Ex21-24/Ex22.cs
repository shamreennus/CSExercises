using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b, maxVal,minVal;           

            do
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());

                maxVal = Math.Max(a, b);
                minVal = Math.Min(a, b);

                maxVal -= minVal;
            } while (minVal!=maxVal);

            Console.WriteLine("HCF :{0}",minVal);

            Console.WriteLine("LCM :{0}", (a*b)/minVal);
            Console.ReadLine();



            


        }
    }
}

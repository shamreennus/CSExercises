using System;
using System.Linq;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int maxValue, minValue, maxIndex,minIndex;
            int[] info = new int[12];
            double sum = 0;
            string[] sales = new string[] {"January","February","March","April","May","June","July","August","September","October","November","December"};
            
            for(int i =0;i<sales.Length;i++)
            {
                Console.Write("Enter sales for month {0} :",sales[i]);
                 info[i] = Convert.ToInt32(Console.ReadLine());
                 sum = sum + info[i];
                 
            }

            maxValue = info.Max();
            minValue = info.Min();

            maxIndex = info.ToList().IndexOf(maxValue);
            minIndex = info.ToList().IndexOf(minValue);

            Console.WriteLine("Maximum Sales Value : {0}", maxValue);

            for (int i = 0; i < 12;i++)
            {
                if (i == maxIndex)
                {
                    Console.WriteLine("Maximum Sales Month : {0}", sales[i]);
                }

            }

            Console.WriteLine("Minimum Sales Value : {0}", minValue);
            for (int i = 0; i < 12; i++)
            {
                if (i == minIndex)
                {
                    Console.WriteLine("Minimum Sales Month : {0}", sales[i]);
                }

            }


              Console.WriteLine("Avergae Sales : {0}", sum / info.Length);
            Console.ReadLine();

        }
    }
}

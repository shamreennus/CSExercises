using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int[] array = new int[10];            
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                count = r.Next(0, 10);
                array[count]++;
            }

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine("The number is {0} and it occured {1} times.", k, array[k]);
            }
            Console.Read();
        }
    }
}

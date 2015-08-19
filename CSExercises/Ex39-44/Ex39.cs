using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to find Factorial : ");
            long no = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Factorial of number : {0} ", Factorial(no));
            Console.Read();
        }

        public static long Factorial(long n)
        {
            long fact = 1;
            for (int i = 1; i <= n;i++)
            {
                fact = fact * i;
            }
                return fact;
        }
    }
}

using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int no=0;

            do
            {
                Console.Write("Enter an Integer Number :");
                no = Convert.ToInt32(Console.ReadLine());
            } while (no != 88);

          Console.WriteLine("Lucky You!"); 
          Console.Read();
        }       
    }
}

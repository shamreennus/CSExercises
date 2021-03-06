using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            

            //get input
            Console.Write("Enter Number :");
            double input = Convert.ToDouble(Console.ReadLine());

            //get random number = double
            Random r = new Random();
            double guess = r.NextDouble();
            guess = guess * (input -1);
            guess = guess + 1;


            //get sqrt of value | check |loop
            bool result = false;
            int count =0;
           do
           {
               count++;
                result = Math.Abs((guess * guess) - input) < 0.00001;

                if (result)
                        Console.Write("Success at {0} attempt",count);            
                else
                {
                    guess = (guess + input / guess) / 2;
                    Console.WriteLine("Looping {0}",count);      
                }
           } while (result == false);

           Console.ReadLine();
        }
    }
}









/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Demo
{
    class Program2
    {
        static void Main(string[] args)
        {
            double N = GetInputFromUser("Please enter a number: ");

            double G = GetARandomNumberBetween1AndN(N);

            bool status = false;
            do
            {
                status = CheckWhetherGIsTheSquareRootOfN(G, N);

                if (status == false)
                {
                    G = CalculateNewG(G, N);
                }

            } while (status == false);

            Console.WriteLine(G);
        }

        //This method is used to prompt the user using the supplied string
        //and get the input, convert the input to double and return it
        static double GetInputFromUser(string prompt)
        {
            Console.Write(prompt);
            double output = Convert.ToDouble(Console.ReadLine());

            return output;
        }

        static double GetARandomNumberBetween1AndN(double N)
        {
            Random r = new Random();

            double x = r.NextDouble();
            x = x*(N - 1);
            x = x + 1;

            return x;
        }

        public static bool CheckWhetherGIsTheSquareRootOfN(double G, double N)
        {
            bool result = Math.Abs((G*G) - N) < 0.00001;

            //result = (G*G - N < 0.00001) || (G*G - N > -0.00001);

            return result;
        }

        static double CalculateNewG(double G, double N)
        {
            double newG = (G + N/G)/2;
            return newG;
        }

    }
}
*/
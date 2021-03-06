using System;
using System.Linq;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] names = new string[] { "John","Venkat","Mary","Victor","Betty"};
            names = names.OrderBy(d => d).ToArray();
            Console.WriteLine("Name in Ascending order :");
            
            for (int i = 0; i < names.Length;i++ )
                    Console.Write(names[i]+ " ");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Marks();
            Console.Read();

        }

        private static void Marks()
        {
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            int temp;

            //marks desc
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[j] > marks[i])
                    {
                        temp = marks[j];
                        marks[j] = marks[i];
                        marks[i] = temp;
                    }
                }
            }

            Console.WriteLine("Descending order of Marks :");
            for (int i = 0; i < marks.Length; i++)
            {

                Console.Write("{0} ", marks[i]);
            }
        }
    }
}

using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {          
            Console.Write("Enter Pharase : ");
            string phrase = Console.ReadLine();
            char[] array = phrase.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                    array[0] = char.ToUpper(array[0]);
            }


            for (int i = 1; i < array.Length;i++)
            {
                if(array[i-1] == ' ')
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
          
            Console.WriteLine(array);
          Console.ReadLine();

        }
    }
}

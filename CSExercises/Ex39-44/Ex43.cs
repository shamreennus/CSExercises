using System;

namespace CSExercises
{
    public class Ex43
    {

        public static void Main(string[] args)
        {  
             for(int decValue=1;decValue<=100;decValue++)
             {
                 Console.WriteLine("HexaDecimal of {0} = {1}",decValue,Hex(decValue));
             }
             Console.Read();
        }

        public static string Hex(int i)
        {
           string hexValue = string.Empty;
           hexValue = i.ToString("X");          
           return hexValue;
        }
    }
}

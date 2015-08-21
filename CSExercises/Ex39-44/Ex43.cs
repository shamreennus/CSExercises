using System;

namespace CSExercises
{
    public class Ex43
    {

        public static void Main(string[] args)
        {  
             for(int decValue=1;decValue<=100;decValue++)
             {
                 Console.WriteLine("{0}\t\t{1}\t{2}",decValue,Hex(decValue),decValue.ToString("X"));
             }
             Console.Read();
        }

        public static string Hex(int j)
        {
           int n=j;
            string s2="";
         do{
               
             int hex1 = n % 16;
             if (hex1 >= 10)
               {
                   int caseSwitch = hex1;
                   switch (caseSwitch)
                   {
                       case 10:
                          s2=s2+"A";
                           break;
                       case 11:
                           s2 = s2 + "B";
                           break;
                       case 12:
                           s2 = s2 + "C";
                           break;
                       case 13:
                           s2 = s2 + "D";
                           break;
                       case 14:
                           s2 = s2 + "E";
                           break;
                       case 15:
                           s2 = s2 + "F";
                           break;
                       default:
                           s2 = "";
                           break;
                   }
               }
               else
               {
                   s2=s2+hex1;
               }
               n = n / 16;

           } while (n > 0);
         char[] cArray = s2.ToCharArray();
         string reverse = String.Empty;
         for (int i = cArray.Length - 1; i > -1; i--)
         {
             reverse += cArray[i];
         }
         return reverse;
        }
    }
}










 
      
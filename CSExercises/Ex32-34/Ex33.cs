
using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] no = new int[] {86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            int temp,minIndex,count=0;

            for(int i=0;i<no.Length -1;i++)
            {
                for (int j = i+1; j < no.Length; j++)
                {                    
                    //if(no[i] > no[j])
                    if (no[j] > no[i])
                    {                      
                        { 
                            //temp =no[i];
                            //no[i] = no[j];
                            //no[j] = temp;
                            temp = no[j];
                            no[j] = no[i];
                            no[i] = temp;
                        }
                    }

                    Console.WriteLine();
                    count += 1;
                    Console.Write("Pass {0} : ",count);

                    for (int k = 0; k < no.Length; k++)
                    {
                        Console.Write("{0} ", no[k]);
                    }
                }

                
                
            }
            Console.Read();
        }
    }
}

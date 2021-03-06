using System;
using System.Linq;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            string[] name = new string[] { "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "N9", "N10", "N11", "N12"};
            int[,] marks = new int[,]{
                                        {	56	,	84	,	68	,	29	},
                                        {	94	,	73	,	31	,	89	},
                                        {	41	,	63	,	36	,	90	},
                                        {	99	,	9	,	18	,	17	},
                                        {	62	,	3	,	65	,	75	},
                                        {	40	,	96	,	53	,	23	},
                                        {	81	,	15	,	27	,	30	},
                                        {	21	,	70	,	100	,	22	},
                                        {	88	,	50	,	13	,	12	},
                                        {	48	,	54	,	52	,	78	},
                                        {	64	,	71	,	67	,	25	},
                                        {	16	,	93	,	46	,	72	},
                                    };

            int[] avgOFSUb = new int[4];

            //a
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine();
                Console.Write("Student name :"+name[i]);
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + marks[i, j];
                }
                Console.WriteLine(",Total_Marks :" + sum);                
            }




            //b
            int loop = 0,classSUM = 0;
            double avgSub;
            Console.WriteLine(string.Concat(Enumerable.Repeat('*',50)));            
            while (loop < 4)
            {
                
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        classSUM += marks[i,j];
                    }

                }
                avgSub = Convert.ToDouble(classSUM) / Convert.ToDouble(name.Length);
                Console.WriteLine("Average of Subject {0} : {1:0.000}",loop,avgSub);
                
                avgOFSUb[loop] = Convert.ToInt32(avgSub);
                
                loop++;
            }


            //c
            int subSum = 0,totalSum = 0;
            double avg;
            Console.WriteLine(string.Concat(Enumerable.Repeat('*', 50)));       
            for (int i = 0; i < name.Length;i++ )
            {
                subSum = 0;
                for(int j=0;j<4;j++)
                {

                    subSum += marks[i, j];
                }
                totalSum += subSum;
            }

            avg = Convert.ToDouble(totalSum) / Convert.ToDouble(12 * 4);
            Console.WriteLine("Average of Whole Class for all marks :{0:0.000}",avg);


            //SD
            for (int j = 0; j < 4;j++ )
            {
                double subSUm1 = 0;
                double stdDEV = 0;
                for(int i=0;i<12;i++)
                {
                    double temp = Convert.ToDouble(marks[i, j]);
                    subSUm1 = subSUm1 + (Math.Pow((temp - avgOFSUb[j]), 2));
                }
                stdDEV = Convert.ToDouble(Math.Sqrt(subSUm1 / 12));
                Console.WriteLine("STD DEV {0:0.000}", stdDEV);
            }
                Console.Read();

        }
    }
}





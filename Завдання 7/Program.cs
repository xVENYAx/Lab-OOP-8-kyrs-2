using System;

namespace Завдання_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int i, j, q, temp, temp1;
            int k = 0;
            int h = 0;
            int[] b1 = new int[6];
            int[] b2 = new int[10];
            Random rnd = new Random();
            Random rnd1 = new Random();

            string strValue = "\n ----------------------------------------";
            Console.WriteLine("\n Исходный массив C: ");
           
            for (i = 0; i < 6; i++)
            {
                    temp = rnd.Next(-10, 10);
                    b1[i] = Convert.ToInt32(temp);
                    Console.Write(" {0}", b1[i]);
            }

            Console.WriteLine();

            for (i = 0; i < 6; i++)
            {
                if (b1[i] < m)
                {
                    k++;
                    if (k == 2)
                    {
                        j = b1[i];
                        b1[i] = b1[0];
                        b1[0] = j;
                    }
                }

            }
            
            Console.WriteLine("\n Массив C после перестановки: ");
            for (i = 0; i < 6; i++)
            {
                Console.Write(" {0}", b1[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine(strValue);
            Console.WriteLine();

            Console.WriteLine("\n Исходный массив D: ");
            for (i = 0; i < 10; i++)
            {
                temp1 = rnd1.Next(-30, 30);
                b2[i] = Convert.ToInt32(temp1);
                Console.Write(" {0}", b2[i]);
            }

            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                if (b2[i] < m)
                {
                    h++;
                    if (h == 2)
                    {
                        q = b2[i];
                        b2[i] = b2[0];
                        b2[0] = q;
                    }
                }

            }

            Console.WriteLine("\n Массив D после перестановки: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write(" {0}", b2[i]);
            }
            Console.WriteLine();
        }
    }
}

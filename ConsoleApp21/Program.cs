using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp21
{
    class Program
    {
        const int n = 2;
        const int m = 5;
        static int[,] field = new int[n, m];

        static void Main(string[] args)
        {
           
            ThreadStart threadStart1 = new ThreadStart(gardener1);
            Thread thread1 = new Thread(threadStart1);
            thread1.Start();
            gardener2();
           
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(field[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void gardener1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (field[i, j] == 0)

                        field[i, j] = 1;
                    
                }
            }
        }
        static void gardener2()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >=0; j--)
                {
                    if (field[j, i] == 0)

                        field[j, i] = 2;
                    
                }
            }
        }
    }
    
    
}

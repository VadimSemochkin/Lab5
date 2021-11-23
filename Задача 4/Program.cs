using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 21;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 1; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int s = 0;
            for (int i = 1; i < n; i++)
            {
                if (i%2==0)
                {
                    if (array[i]>0)
                    {
                        if (array[i]%2!=0)
                        {
                            s++;
                        }
                    }
                }

            }
            Console.WriteLine("Количество положительных нечетных чисел, стоящих на четных местах равно {0}",s);
            
            Console.ReadKey();
        }
    }
}

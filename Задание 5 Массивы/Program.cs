using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5_Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int i = 0; i < 7; i++)
            {
               S += array[i];
            }
            Console.Write("Среднее арифметическое равно {0} ", S/7);
           
            
            Console.ReadKey();
        }
    }
}

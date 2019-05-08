using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int number_3 = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            if (number_1 > 0)
            {
                ++res;
            }
            if (number_2 > 0)
            {
                ++res;
            }
            if (number_3 > 0)
            {
                ++res;
            }
            Console.WriteLine("Количество чисел > 0 - {0}", res);
        }
    }
}

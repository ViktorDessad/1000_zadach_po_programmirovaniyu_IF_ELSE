using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            if (numberOne > numberTwo)
            {
                Console.WriteLine($"Порядковый номер числа {numberTwo} = {i}");
            }
            else
            {
                Console.WriteLine($"Порядковый номер числа {numberOne} = {i}");
            }
        }
    }
}

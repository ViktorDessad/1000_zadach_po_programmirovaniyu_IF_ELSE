using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine($"Число {numberOne} и число {numberTwo}");
            }
            else if (numberTwo > numberOne)
            {
                Console.WriteLine($"Число {numberTwo} и число {numberOne}");
            }
            else
            {
                Console.WriteLine($"Это {numberOne}");
            }
        }
    }
}

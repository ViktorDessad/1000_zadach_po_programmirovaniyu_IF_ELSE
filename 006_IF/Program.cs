using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_IF
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
                Console.WriteLine("Число {0} > за число {1}", numberOne, numberTwo);
            }
            else
            {
                Console.WriteLine("Число {0} < за число {1}", numberOne, numberTwo);
            }
        }
    }
}

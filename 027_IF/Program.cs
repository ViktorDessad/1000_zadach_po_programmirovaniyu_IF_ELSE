using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            Console.Write("x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            if ( x == 0)
            {
                x = 0;
                Console.WriteLine("Результат {0}", x);
            }
            else if ((x >= 0 && x < 1) && (x >= 2 && x < 3))
            {
                x = 1;
                Console.WriteLine("Результат {}", x);
            }
            else if ((x >= 1 && x < 2) && (x >= 3 && x < 4))
            {
                x *= -1;
                Console.WriteLine("Результат {}", x);
            }
        }
    }
}

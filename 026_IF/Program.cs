using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                x = -x;
                Console.WriteLine("Результат {0}", x);
            }
            else if ( x > 0 && x < 2)
            {
                x = (int)Math.Pow(x, 2);
                Console.WriteLine("Результат {0}", x);
            }
            else if (x >= 2)
            {
                x = 4;
                Console.WriteLine("Результат {0}", x);
            }
        }
    }
}

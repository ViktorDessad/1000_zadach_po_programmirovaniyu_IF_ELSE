using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                double res = Math.Sin(x) * 2;
                Console.WriteLine("Результат {0}", res);
            }
            else if (x <= 0)
            {
                double res = 6 - x;
                Console.WriteLine("Результат {}", res);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                ++number;
                Console.WriteLine("Это число {0}", number);
            }
            else
            {
                number -= 2;
                Console.WriteLine("Это число {0}", number);
            }
        }
    }
}

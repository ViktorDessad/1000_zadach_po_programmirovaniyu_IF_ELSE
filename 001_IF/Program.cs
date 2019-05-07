using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_IF
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
                Console.WriteLine("Это число {0}", number);
            }
        }
    }
}

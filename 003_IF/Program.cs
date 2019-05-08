using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                ++number;
                Console.WriteLine("Это число больше 0 - {0}", number);
            }
            else if (number < 0)
            {
                number -= 2;
                Console.WriteLine("Это число меньше 0 - {0}", number);
            }
            else if (number == 0)
            {
                number = 10;
                Console.WriteLine("Это число равно = 0 и будет заменено на {0}", number);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 999");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10 && num % 2 == 0)
                Console.WriteLine("Четное единичное число {0}", num);
            else if (num < 10 && num % 2 > 0)
                Console.WriteLine("Нечетное единичное число {0}", num);
            else if (num >= 10 && num < 100 && num % 2 == 0)
                Console.WriteLine("Четное двухзначное число {0}", num);
            else if (num >= 10 && num < 100 && num % 2 > 0)
                Console.WriteLine("Нечетное двухзначное число {0}", num);
            else if (num >= 100 && num < 1000 && num % 2 == 0)
                Console.WriteLine("Четное трехзначное число {0}", num);
            else if (num >= 100 && num < 1000 && num % 2 > 0)
                Console.WriteLine("Нечетное трехзначное число {0}", num);
        }
    }
}

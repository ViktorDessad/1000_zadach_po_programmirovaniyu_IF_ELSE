using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Веедите число");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 && num % 2 == 0)
                Console.WriteLine("Положительное четное число");
            else if (num > 0 && num % 2 == 1)
                Console.WriteLine("Положительное нечетное число");
            else if (num == 0)
                Console.WriteLine("Число равно {0}", num);
            else if (num < 0 && num % (-2) == 0)
                Console.WriteLine("Отрицательное четное число");
            else if (num < 0 && num % (-2) < 0)
                Console.WriteLine("Отрицательное нечетное число");

        }
    }
}

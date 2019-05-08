using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            Console.Write("A:");
            int number_A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:");
            int number_B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C:");
            int number_C = Convert.ToInt32(Console.ReadLine());

            if ((number_B > number_A && number_A > number_C) || (number_B < number_A && number_A < number_C))
            {
                Console.WriteLine("Среднее число это А={0}", number_A);
            }
            else if ((number_A > number_B && number_B > number_C) || (number_A < number_B && number_B < number_C))
            {
                Console.WriteLine("Среднее число это B={0}", number_B);
            }
            else if ((number_C > number_B && number_C < number_A) || (number_C < number_B && number_C > number_A))
            {
                Console.WriteLine("Среднее число это C={0}", number_C);
            }
        }
    }
}

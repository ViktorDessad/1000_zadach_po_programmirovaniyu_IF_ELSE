using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            Console.Write("A:");
            double number_A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B:");
            double number_B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C:");
            double number_C = Convert.ToDouble(Console.ReadLine());
            Console.Write("D:");
            double number_D = Convert.ToDouble(Console.ReadLine());

            int counter = 0;

            if (number_B == number_C && number_B == number_D)
                Console.WriteLine("Порядковый номер числа А = {0} - {1}", number_A, counter);
            else if (number_C == number_A && number_C == number_D)
                Console.WriteLine("Порядковый номер числа B = {0} - {1}", number_B, ++counter);
            else if (number_A == number_B && number_A == number_D)
                Console.WriteLine("Порядковый номер числа C = {0} - {1}", number_C, counter + 2);
            else if (number_A == number_B && number_A == number_C)
                Console.WriteLine("Порядковый номер числа D = {0} - {1}", number_D, counter + 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_IF
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

            if (number_A < number_B && number_A < number_C)
            {
                Console.WriteLine("Самое маленькое число это А = {0}", number_A);
                if (number_B > number_C)
                    Console.WriteLine("Самое большое число В = {0}", number_B);
                else
                    Console.WriteLine("Самое большое число С = {0}", number_C);
            }
            else if (number_B < number_A && number_B < number_C)
            {
                Console.WriteLine("Самое маленькое число это B = {0}", number_B);
                if (number_A > number_C)
                    Console.WriteLine("Самое большое число А = {0}", number_A);
                else
                    Console.WriteLine("Самое маленькое число С = {0}", number_C);
            }
            else if (number_C < number_A && number_C < number_B)
            {
                Console.WriteLine("Самое маленькое число это C = {0}", number_C);
                if (number_A > number_B)
                    Console.WriteLine("Самое большое число А = {0}", number_A);
                else
                    Console.WriteLine("Самое большое число В = {0}", number_B);
            }
        }
    }
}

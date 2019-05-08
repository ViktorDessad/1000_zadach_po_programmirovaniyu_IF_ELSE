using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            Console.Write("A: ");
            int number_A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int number_B = Convert.ToInt32(Console.ReadLine());

            if (number_A > number_B)
            {
                int buffer = 0;
                buffer = number_A;
                number_A = number_B;
                number_B = buffer;

                Console.WriteLine($"Число A = {number_A}  B = {number_B}");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так:)");
            }
            

        }
    }
}

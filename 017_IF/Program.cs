using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_IF
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

            double buff_A = number_A;
            double buff_B = number_B;
            double buff_C = number_C;

            if ((number_C > number_B && number_B > number_A) || (number_A > number_B && number_B > number_C))
            {
                number_A *= 2;
                number_B *= 2;
                number_C *= 2;

                Console.WriteLine("Было A = {0}, B = {1}, C = {2}, стало A = {3}, B = {4}, C = {5}",
                    buff_A, buff_B, buff_C, number_A, number_B, number_C);
            }
            else
            {
                number_A *= -1;
                number_B *= -1;
                number_C *= -1;
                Console.WriteLine("Было A = {0}, B = {1}, C = {2}, стало A = {3}, B = {4}, C = {5}",
                    buff_A, buff_B, buff_C, number_A, number_B, number_C);
            }
        }
    }
}

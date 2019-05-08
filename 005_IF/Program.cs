using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа");
            int number_0 = Convert.ToInt32(Console.ReadLine());
            int number_1 = Convert.ToInt32(Console.ReadLine());
            int number_2 = Convert.ToInt32(Console.ReadLine());

            int res_plus = 0;
            int res_minus = 0;

            // First variant with (else if)
            if (number_0 > 0)
                ++res_plus;
            else if (number_0 < 0)
                ++res_minus;
            if (number_1 > 0)
                ++res_plus;
            else if (number_1 < 0)
                ++res_minus;
            if (number_2 > 0)
                ++res_plus;
            else if (number_2 < 0)
                ++res_minus;
            Console.WriteLine("Количество чисел > 0 - {0}, а чисел < 0 - {1},", res_plus, res_minus);

            // Second variant without (else if)
            if (number_0 > 0)
                ++res_plus;
            if (number_1 > 0)
                ++res_plus;
            if (number_2 > 0)
                ++res_plus;
            Console.WriteLine($"Количество чисел > 0 - {res_plus}, а чисел < 0 - {3-res_plus}");







        }
    }
}

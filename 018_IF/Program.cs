using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_IF
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

            int counter = 0;

            if (number_B == number_C)
                Console.WriteLine("Порядковый номер числа А = {0} - {1}",number_A, counter);
            else if (number_C == number_A)
                Console.WriteLine("Порядковый номер числа B = {0} - {1}",number_B, ++counter);
            else if (number_A == number_B)
                Console.WriteLine("Порядковый номер числа C = {0} - {1}",number_C, counter + 2);
        }
    }
}
            
           


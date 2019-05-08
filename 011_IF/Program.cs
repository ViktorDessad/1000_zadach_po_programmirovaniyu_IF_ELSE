using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 переменные");
            Console.Write("A: ");
            int number_A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int number_B = Convert.ToInt32(Console.ReadLine());

            if (number_A != number_B)
            {
                if (number_A > number_B)
                {
                    number_B = number_A;
                    Console.WriteLine("Теперь А = В - {0}", number_B);
                }
                else if (number_B > number_A)
                {
                    number_A = number_B;
                    Console.WriteLine("Теперь B = A - {0}", number_A);
                }
            }
            else if (number_A == number_B)
            {
                number_A = 0;
                number_B = number_A;
                Console.WriteLine("Число А={0} и число В={1}", number_A, number_B);
            }
               
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки А числа");
            Console.Write("A:");
            double number_A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Координата точки B: ");
            double number_B = Convert.ToDouble(Console.ReadLine());

            if (number_A > number_B)
            {
                Console.Write("Координата точки C:");
                double number_С = Convert.ToDouble(Console.ReadLine());
                if (number_С > number_A)
                {
                    Console.WriteLine("Error 404");
                }
                else if (number_С > number_B)
                {
                    double res = number_A - number_С;
                    Console.WriteLine("Ближе к точке А - {0} находится точка С - {1}, расстояние до точки А = {2}",number_A, number_С, res);
                }
                else if (number_B > number_С)
                {
                    double res = number_A - number_B;
                    Console.WriteLine("Ближе к точке А - {0} находится точка B - {1}, расстояние до точки А = {2}",number_A, number_B, res);
                }               
            }
            else
            {
                Console.WriteLine("Error 404");
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек");
            Console.Write("Введите x1,y1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2,y2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x3,y3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            int x4 = 0;
            int y4 = 0;

            if (x1 == x2)
            {
                x4 = x3;
                Console.WriteLine("Точка x = {0}", x4);
            }
            else if (x1 == x3)
            {
                x4 = x2;
                Console.WriteLine("Точка x = {0}", x4);
            }
            else if (x2 == x3)
            {
                x4 = x1;
                Console.WriteLine("Точка x = {0}", x4);
            }

            if (y1 == y2)
            {
                y4 = y3;
                Console.WriteLine("Точка y = {0}", y4);
            }
            else if (y1 == y3)
            {
                y4 = y2;
                Console.WriteLine("Точка y = {0}", y4);
            }
            else if (y2 == y3)
            {
                y4 = y1;
                Console.WriteLine("Точка y = {0}", y4);
            }

        }
    }
}

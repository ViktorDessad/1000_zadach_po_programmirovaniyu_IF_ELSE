using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точки координат х и у");
            Console.Write("x: ");
            int point_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            int point_y = Convert.ToInt32(Console.ReadLine());

            if (point_x == 0 && point_y == 0)
                Console.WriteLine("Точки лежат на 0");
            else if (point_x > 0 && point_y > 0)
                Console.WriteLine("Точки лежат на I чветри");
            else if (point_x < 0 && point_y > 0)
                Console.WriteLine("Точки лежат на II чветри");
            else if (point_x < 0 && point_y < 0)
                Console.WriteLine("Точки лежат на III чветри");
            else if (point_x > 0 && point_y < 0)
                Console.WriteLine("Точки лежат на IV чветри");
            else
                Console.WriteLine("Одна из точек лежит на оси");

        }
    }
}

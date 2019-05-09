using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_IF
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

            if (point_x == 0 && point_y == 0 )
            {
                Console.WriteLine($"Координаты x = {point_x} и y = {point_y} совпадают с началом координат {0}");  
            }
            else if (point_x != 0 && point_y == 0)
            {
                Console.WriteLine($"Координаты точек x= {point_x} y = {point_y} лежат на оси ОХ {1}");
            }
            else if (point_y != 0 && point_x == 0)
            {
                Console.WriteLine($"Координаты точек x= {point_x} y = {point_y} лежат на оси ОY {2}");
            }
            else if (point_x != 0 && point_y != 0)
            {
                Console.WriteLine($"Координаты точек x= {point_x} y = {point_y} не лежат на осях ОХ и ОY {3}");
            }
        }
    }
}

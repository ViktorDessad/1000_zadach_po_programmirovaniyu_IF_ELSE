using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года");
            UInt32 year = Convert.ToUInt32(Console.ReadLine());

            if (year % 4 == 0 && ((year % 100 != 0) || (year % 400 == 0)))
                Console.WriteLine("366");
            else
                Console.WriteLine("365");
            
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Lab1_2
    {
        static void Main(string[] args)
        {
            double L, d;
            const double PI = 3.14;
            Console.WriteLine("Введите диаметр окружности");
            d = double.Parse(Console.ReadLine());
            L = PI * d;
            Console.WriteLine("Длина окружности:{0}", L);
        }
    }
}

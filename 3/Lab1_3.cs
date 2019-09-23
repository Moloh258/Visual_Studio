using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Lab1_3
    {
        static void Main(string[] args)
        {
            float a, b, C;
            Console.WriteLine("Введите числа");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            C = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое:{0}", C);
        }
    }
}

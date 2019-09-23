using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Lab1_4
    {
        static void Main(string[] args)
        {
            float a, b, sum, sub1, sub2, pro, div1, div2;
            Console.WriteLine("Введите первое число");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = float.Parse(Console.ReadLine());
            a = a * a;
            b = b * b;
            sum = a + b;
            sub1 = a - b;
            sub2 = b - a;
            pro = a * b;
            div1 = a / b;
            div2 = b / a;
            Console.WriteLine("Сумма квадратов:{0}", sum);
            Console.WriteLine("Разность квадрата первого числа и квадрата второго числа:{0}", sub1);
            Console.WriteLine("Разность квадрата второго числа и квадрата первого числа:{0}", sub2);
            Console.WriteLine("Произведение квадратов:{0}", pro);
            Console.WriteLine("Частное деления квадрата первого числа на квадрат второго:{0}", div1);
            Console.WriteLine("Частное деления квадрата второго числа на квадрат первого:{0}", div2);
        }
    }
}

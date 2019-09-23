using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Lab1_5
    {
        static void Main(string[] args)
        {
            float a, b, sum, sub1, sub2, pro, div1, div2;
            Console.WriteLine("Введите первое число");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = float.Parse(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            sum 
            sub1 = a - b;
            sub2 = b - a;
            pro = a * b;
            div1 = a / b;
            div2 = b / a;
            Console.WriteLine("Сумма модулей:{0}", sum);
            Console.WriteLine("Разность модуля первого числа и модуля второго числа:{0}", sub1);
            Console.WriteLine("Разность модуля второго числа и модуля первого числа:{0}", sub2);
            Console.WriteLine("Произведение модулей:{0}", pro);
            Console.WriteLine("Частное деления модуля первого числа на модуль второго:{0}", div1);
            Console.WriteLine("Частное деления модуля второго числа на модуль первого:{0}", div2);
        }
    }
}

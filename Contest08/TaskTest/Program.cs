using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simpson_cs
{
    class Program
    {
        static double Y(double p)
        {
            return Math.Tan(p);
        }
        static void Main(string[] args)
        {
            double x, a, b, h, s;
            int n;
            Console.Write("Отрезок интегрирования [a,b] --> (a) =");
            a = double.Parse(Console.ReadLine());
            Console.Write("Отрезок интегрирования [a,b] --> (b) =");
            b = double.Parse(Console.ReadLine());
            Console.Write("На сколько частей нужно разделить отрезок? n=");
            n = int.Parse(Console.ReadLine());

            h = (b - a) / n;
            s = 0; x = a + h;
            while (x < b)
            {
                s = s + 4 * Y(x);
                x = x + h;
                s = s + 2 * Y(x);
                x = x + h;
            }
            s = h / 3 * (s + Y(a) - Y(b));
            Console.WriteLine("Интеграл = {0}", s);
            Console.ReadKey();
        }
    }
}
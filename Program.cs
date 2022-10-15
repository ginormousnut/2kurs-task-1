using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main()
        {
            int n;
            double x;
            double s=Math.PI/2;
            double e;
            double a;
            Console.WriteLine("Введите переменную>");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество членов ряда>");
            n= Convert.ToInt32(Console.ReadLine());
            for(double i=1; i<=n; i++)
            {
                s += Math.Pow(-1, i) * Math.Pow(x, 2 * i - 1) / (2 * i - 1);
            }
            Console.Write("Полученная частичная сумма ");
            Console.WriteLine(s);
            e = Math.Abs(s - (Math.PI/2 - Math.Atan(x)));
            Console.Write("Полученная погрешность ");
            Console.WriteLine(e);
            a = Math.Pow(-1, n) * Math.Pow(x, 2 * n - 1) / (2 * n - 1);
            Console.Write("Полученная последний член ");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}

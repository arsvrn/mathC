using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Triangle1
    {
        private int v; private double a; private double b; private double h; private double al; private double c; private double p;
        public Triangle1()
        {
            Console.WriteLine("Выберите как искать площадь");
            Console.WriteLine("1.Через сторону и высоту, проведенную к ней");
            Console.WriteLine("2.Через две стороны и угол между ними");
            Console.WriteLine("3.Через формулу Герона");
            this.v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Введите сторону");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту");
                this.h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("S=" + (0.5 * a * h));
            }
            if (v == 2)
            {
                Console.WriteLine("Введите первую сторону");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону");
                this.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите угол между ними");
                this.al = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("S=" + (0.5*a*b* Math.Sin(al)));
            }
            if (v == 3)
            {
                Console.WriteLine("Введите первую сторону");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону");
                this.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третью сторону");
                this.c = Convert.ToDouble(Console.ReadLine());
                this.p = (a+b+c)/2;
                Console.WriteLine("S=" + (Math.Sqrt(p - a) * (p - c) * (p - b)));
            }
        }
    }
}

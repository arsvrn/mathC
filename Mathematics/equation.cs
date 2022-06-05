using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class equation
    {
        private double a; private double b; private double c; private double D; private double x1; private double x2;
        public equation ()
        {
            Console.WriteLine("Введите а");
            this.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            this.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            this.c = Convert.ToInt32(Console.ReadLine());
            D = b * b + 4 * a * c;
            D=Math.Sqrt(D);
            x1 = (-b + D) / (2 * a);
            x2 = (-b - D) / (2 * a);
            Console.WriteLine("Корни уровнения X={0},X={1}",x1,x2);
        }
    }
}

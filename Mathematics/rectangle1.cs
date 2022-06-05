using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class rectangle1
    {
        private double a; private double b;
        public rectangle1 ()
        {
            Console.WriteLine("Введите сторону а");
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            this.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("S=" + (a * b));
        }
    }
}

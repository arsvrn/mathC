using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class vector
    {
        private double ax; private double ay; private double bx; private double by;
        public vector () {
            Console.WriteLine("Введите координаты точки A");
            this.ax = Convert.ToDouble(Console.ReadLine());
            this.ay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B");
            this.bx = Convert.ToDouble(Console.ReadLine());
            this.by = Convert.ToDouble(Console.ReadLine());
    }
        public double dlina(double D = 0)
        {
            D = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
            Console.WriteLine("P={0}", D);
            return D;
        }
    }
}

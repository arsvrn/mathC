using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class rectangle
    {
        private double Ax1; private double Ay1; private double Cx1; private double Cy1; private double a; private double b;
        public rectangle()
        {
            Console.WriteLine("Введите координаты точки А прямоугольника");
            this.Ax1 = Convert.ToDouble(Console.ReadLine());
            this.Ay1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C прямоугольника");
            this.Cx1 = Convert.ToDouble(Console.ReadLine());
            this.Cx1 = Convert.ToDouble(Console.ReadLine());
        }
        public double perimeter(double P = 0)
        {
            a = Math.Abs(Cx1 - Ax1);
            b = Math.Abs(Ay1 - Cy1);
            P = 2 * (a + b);
            Console.WriteLine("P={0}", P);
            return P;
        }
        public double area(double S = 0)
        {
            S = a * b;
            Console.WriteLine("S={0}", S);
            return S;
        }
        public void squart(bool sq = false)
        {
            if (a == b)
                sq = true;
            else sq = false;
            Console.WriteLine("Квадрат - {0}", sq);
        }
    }
}

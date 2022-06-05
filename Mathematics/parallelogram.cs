using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class parallelogram
    {
        private double Ax1; private double Ay1; private double Cx1; private double Cy1; private double Bx1; private double By1; private double Dx1; private double Dy1; private double a; private double b;
        public parallelogram()
        {
            Console.WriteLine("Введите координаты точки А параллелограмма");
            this.Ax1 = Convert.ToDouble(Console.ReadLine());
            this.Ay1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B параллелограмма");
            this.Bx1 = Convert.ToDouble(Console.ReadLine());
            this.By1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C параллелограмма");
            this.Cx1 = Convert.ToDouble(Console.ReadLine());
            this.Cy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки D параллелограмма");
            this.Dx1 = Convert.ToDouble(Console.ReadLine());
            this.Dy1 = Convert.ToDouble(Console.ReadLine());

        }
        public double perimeter(double P = 0)
        {
            this.a = Math.Abs(Cx1 - Ax1);
            this.b = Math.Abs(Ay1 - Cy1);
            P = 2 * (a + b);
            Console.WriteLine("P={0}", P);
            return P;
        }
        public double area(double S = 0, double c = 0, double St = 0, double p = 0)
        {
            c = Math.Sqrt(Math.Pow((Cx1 - Ax1), 2) + Math.Pow((Cy1 - Ay1), 2));
            p = (a + b + c) / 2;
            St = Math.Sqrt(p * (p - a) * (p - c) * (p - b));
            S = St * 2;
            Console.WriteLine("S={0}", S);
            return S;
        }
        public void rhombus(bool sq = false)
        {
            if (a == b)
                sq = true;
            else sq = false;
            Console.WriteLine("Ромб - {0}", sq);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class trapeze
    {
        private double Ax1; private double Ay1; private double Cx1; private double Cy1; private double Bx1; private double By1; private double Dx1; private double Dy1; private double a; private double b; private double c; private double d;
        public trapeze()
        {
            Console.WriteLine("Введите координаты точки А трапеции");
            this.Ax1 = Convert.ToDouble(Console.ReadLine());
            this.Ay1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B трапеции");
            this.Bx1 = Convert.ToDouble(Console.ReadLine());
            this.By1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C трапеции");
            this.Cx1 = Convert.ToDouble(Console.ReadLine());
            this.Cy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки D трапеции");
            this.Dx1 = Convert.ToDouble(Console.ReadLine());
            this.Dy1 = Convert.ToDouble(Console.ReadLine());

        }
        public double perimeter(double P = 0)
        {
            this.a = Math.Sqrt(Math.Pow((Bx1 - Ax1), 2) + Math.Pow((By1 - Ay1), 2));
            this.b = Math.Sqrt(Math.Pow((Cx1 - Bx1), 2) + Math.Pow((Cy1 - By1), 2));
            this.c = Math.Sqrt(Math.Pow((Cx1 - Dx1), 2) + Math.Pow((Cy1 - Dy1), 2));
            this.d = Math.Sqrt(Math.Pow((Dx1 - Ax1), 2) + Math.Pow((Dy1 - Ay1), 2));
            P = a + b + c + d;
            Console.WriteLine("P={0}", P);
            return P;
        }
        public double area(double S = 0, double St = 0, double p = 0, double ac = 0, double St2 = 0, double p2 = 0)
        {
            ac = Math.Sqrt(Math.Pow((Cx1 - Ax1), 2) + Math.Pow((Cy1 - Ay1), 2));
            p = (a + b + ac) / 2;
            St = Math.Sqrt(p * (p - ac) * (p - a) * (p - b));
            p2 = (d + c + ac) / 2;
            St2 = Math.Sqrt(p * (p - ac) * (p - d) * (p - c));
            S = St + St2;
            Console.WriteLine("S={0}", S);
            return S;
        }
        public void isosceles(bool sq = false)
        {
            if (d == b)
                sq = true;
            else sq = false;
            Console.WriteLine("Равнобокая трапеция - {0}", sq);
        }
    }
}

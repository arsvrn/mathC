using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Triangle
    {
        private double Ax1; private double Ay1; private double Cx1; private double Cy1; private double Bx1; private double By1; private double a1; private double b1; private double c1;
        public Triangle()
        {
            Console.WriteLine("Введите координаты точки А треугольника");
            this.Ax1 = Convert.ToDouble(Console.ReadLine());
            this.Ay1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B треугольника");
            this.Bx1 = Convert.ToDouble(Console.ReadLine());
            this.By1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C треугольника");
            this.Cx1 = Convert.ToDouble(Console.ReadLine());
            this.Cy1 = Convert.ToDouble(Console.ReadLine());
        }
        public double perimeter(double P = 0)
        {
            this.a1 = Math.Sqrt(Math.Pow((Bx1 - Ax1), 2) + Math.Pow((By1 - Ay1), 2));
            this.b1 = Math.Sqrt(Math.Pow((Cx1 - Bx1), 2) + Math.Pow((Cy1 - By1), 2));
            this.c1 = Math.Sqrt(Math.Pow((Cx1 - Ax1), 2) + Math.Pow((Cy1 - Ay1), 2));
            P = a1 + b1 + c1;
            Console.WriteLine("P={0}", P);
            return P;
        }
        public double area(double S = 0, double p = 0)
        {
            p = (a1 + b1 + c1) / 2;
            S = Math.Sqrt(p * (p - c1) * (p - b1) * (p - a1));
            Console.WriteLine("S={0}", S);
            return S;
        }
        public void type(bool t1 = false, bool t2 = false, bool t3 = false)
        {
            if (a1 != b1 && b1 != c1 && c1 != a1)
                t1 = true;
            else t1 = false;
            if (a1 == b1 && b1 == c1 && c1 == a1)
                t3 = true;
            else t3 = false;
            if ((a1 == b1 || b1 == c1 || c1 == a1) && (a1 != b1 || b1 != c1 || c1 != a1))
                t2 = true;
            else t2 = false;
            Console.WriteLine("Треугольник разносторонний - {0}", t1);
            Console.WriteLine("Треугольник равнобедренный - {0}", t2);
            Console.WriteLine("Треугольник равносторонний - {0}", t3);
        }

    }
}

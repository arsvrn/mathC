using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class trapeze1
    {
        private double a; private double h; private int v; double b;private double al;private double c; private double d;private double m;
        public trapeze1 (){
            Console.WriteLine("Выберите как искать площадь");
            Console.WriteLine("1.Через основания и высоту");
            Console.WriteLine("2.Через диагонали и угол между ними");
            Console.WriteLine("3.Через четыре стороны");
            this.v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Введите нижнее основание");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите верхнее основание");
                this.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту");
                this.h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("S=" + (((a + b) / 2) * h));
            }
            if (v == 2)
            {
                Console.WriteLine("Введите первую диоганаль");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую диоганаль");
                this.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите угол между диагоналями");
                this.al = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("S=" + (((a * b) / 2) * Math.Sin(al)));
            }
            if (v == 3)
            {
                Console.WriteLine("Введите нижнее основание");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите верхнее основание");
                this.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите первую сторону");
                this.c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону");
                this.d = Convert.ToDouble(Console.ReadLine());
                m = (((a - b) * (a - b) + c * c - d * d)) / (2 * (a - b));
                m = Math.Pow(m, 2);
                Console.WriteLine("S=" + (((a + b) / 2) * Math.Sqrt(c * c - m)));
            }
        }

        }
        
    }


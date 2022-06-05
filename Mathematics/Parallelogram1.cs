using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Parallelogram1
    {
        private double a; private double h; private int v; double b; private double al;
        public Parallelogram1 (){
            Console.WriteLine("Выберите как искать площадь");
            Console.WriteLine("1.Через основание и высоту");
            Console.WriteLine("2.Через две стороны и угол между ними");
            this.v = Convert.ToInt32(Console.ReadLine());

        }
        public void are()
        {
           if (v==1) 
           {
               Console.WriteLine("Введите основание");
               this.a=Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("Введите высоту");
               this.h=Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("S="+(a*h));
           }
           if (v == 2)
           {
               Console.WriteLine("Введите первую сторону");
               this.a = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("Введите вторую сторону");
               this.b = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("Введите угол");
               this.al = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("S=" + (a * b * Math.Sin(al)));
           }
            
        }
  
    }
}

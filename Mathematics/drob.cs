using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class drob
    {
        private double a1; private double a2; private double b1; private double b2; private double c1; private double c2;
        public drob ()
        {
            Console.WriteLine("Введите числитель первой дроби");
            this.a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            this.a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби");
            this.b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби");
            this.b2 = Convert.ToDouble(Console.ReadLine());
            if (this.a2==this.b2)  {
                 this.c2=a2;
                 c1=a1+b1;
            }
            else
            {
              c2=a2*b2;
              c1=a1*b2+a2*a1;
             }
            Console.WriteLine("Сумма = {0}\\{1}", c1, c2);
        }
    }
}

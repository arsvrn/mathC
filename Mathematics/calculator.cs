using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class calculator
    {
        private double a; private double b; private double v; private double s; private double y; private double d; private int x;
        public calculator ()
        {

            Console.WriteLine("Выберите операцию");
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычитание");
            Console.WriteLine("3.Умножение");
            Console.WriteLine("4.Деление");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine("Сумма={0}", a + b); break;
                case 2: Console.WriteLine("Разность={0}", a - b); break;
                case 3: Console.WriteLine("Произведение={0}", a * b); break;
                case 4: Console.WriteLine("Разность={0}", a / b); break;
            }
            
        }
    }
}

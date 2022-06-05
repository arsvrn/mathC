using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            Console.WriteLine(" Введите номер операции");
            Console.WriteLine("1. Калькулятор");
            Console.WriteLine("2. Сложение дроби");
            Console.WriteLine("3. Решение квадратного уравнения");
            Console.WriteLine("4. Площадь фигур");
            Console.WriteLine("5. Площадь фигур через координаты");
            Console.WriteLine("6. Формулы сокращённого умнажения");

            a = Convert.ToInt32(Console.ReadLine());
            if (a==1)
            {
                calculator c = new calculator();
            }
            if (a == 2)
            {
                drob tr = new drob();
            }
            if (a == 3)
            {
                equation r = new equation();
            }
            if (a == 6)
            {
                Console.WriteLine("1. Квадрат суммы: (a+b)^2=a^2+2ab+b^2");
                Console.WriteLine("2. Квадрат разности: (a-b)^2=a^2-2ab+b^2");
                Console.WriteLine("3. Куб суммы: (a+b)^3=a^3+3a^2b+3ab^2+b^3");
                Console.WriteLine("4. Куб разности: (a-b)^3=a^3-3a^2b+3ab^2-b^3");
                Console.WriteLine("5. Разность квадратов: a^2-b^2=(a-b)(a+b)");
                Console.WriteLine("6. Сумма кубов: a^3+b^3=(a+b)(a^2-ab+b^2)");
                Console.WriteLine("7. Разность кубов: a^3-b^3=(a-b)(a^2+ab+b^2)");
            }
            if (a > 6 || a < 1)
            {
                Console.WriteLine("Error"); ;
            }
            if (a == 4)
            {
                int b = 0;
                Console.WriteLine("Введите фигуру");
                Console.WriteLine("1. Треугольник");
                Console.WriteLine("2. Трапеция");
                Console.WriteLine("3. Прямоугольник");
                Console.WriteLine("4. Параллелограм");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Triangle1 c = new Triangle1();
                }
                if (b == 2)
                {
                    trapeze1 tr = new trapeze1();
                }
                if (b == 3)
                {
                    rectangle1 r = new rectangle1();
                }
                if (b == 4)
                {
                    Parallelogram1 r = new Parallelogram1();
                }
                if (b > 4 || b < 1)
                {
                    Console.WriteLine("Error"); ;
                }
            }
            if (a==5)
            {
                int b=0;
                Console.WriteLine("Введите фигуру");
                Console.WriteLine("1. Треугольник");
                Console.WriteLine("2. Трапеция");
                Console.WriteLine("3. Прямоугольник");
                Console.WriteLine("4. Параллелограм");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Triangle c = new Triangle();
                }
                if (b == 2)
                {
                    trapeze tr = new trapeze();
                }
                if (b == 3)
                {
                    rectangle r = new rectangle();
                }
                if (b == 4)
                {
                    parallelogram r = new parallelogram();
                }
                if (b > 4 || b < 1)
                {
                    Console.WriteLine("Error"); ;
                }
           }
           
            Console.ReadKey();
        }
    }
}

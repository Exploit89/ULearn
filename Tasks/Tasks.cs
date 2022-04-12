using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Tasks
    {
        /* Expr1. 
         * Как поменять местами значения двух переменных? 
         * Можно ли это сделать без ещё одной временной переменной. 
         * Стоит ли так делать?
        */
        public static void Expr1()
        {
            int a = 1;
            int b = 2;
            (a, b) = (b, a);
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
        /*Expr2.
         *Задается натуральное трехзначное число (гарантируется, что трехзначное).
         *Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
        */
        public static void Expr2()
        {
            int number = 123;
            Console.WriteLine(number.ToString().Reverse().ToArray());
        }
        /*Expr3.
         *Задано время Н часов (ровно). 
         *Вычислить угол в градусах между часовой и минутной стрелками. 
         *Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов.
         *Не использовать циклы.
        */
        public static void Expr3()
        {
            int clock = 12;
            int angles = 360;
            int hour = angles / clock;
            Console.WriteLine("Input hours: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a * hour);
        }
        /* Expr4. 
         * Найти количество чисел меньших N,
         * которые имеют простые делители X или Y.
         */
        public static void Expr4()
        {
            Console.WriteLine("Input N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Input X: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Y: ");
            int Y = int.Parse(Console.ReadLine());
            int n = N - 1;
            int result = n / X + n / Y - n / (X * Y);
            Console.WriteLine(result);
        }
        /*Expr5. 
         * Найти количество високосных лет на отрезке [a, b] не используя циклы.
         */
        public static void Expr5()
        {
            int a = 345;
            int b = 1983;
            int result = (b - a) / 4;
            Console.WriteLine(result);
        }
        /*Expr6. 
         * Посчитать расстояние от точки до прямой,
         * заданной двумя разными точками.
         */
        public static void Expr6()
        {
            int x1 = 10;
            int y1 = 10;
            int x2 = 10;
            int y2 = 5;
            int x3 = 3;
            int y3 = 3;
            int a = x2 - x1;
            int b = y2 - y1;
            double result = Math.Abs((b * x3) - (a * y3) - ((b * x1) - (a * y1))) / Math.Sqrt((a * a) + (b * b));
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Expr6();
        }
        // задачи 7 и 8 делать не буду. Тупая геометрия.
    }
}

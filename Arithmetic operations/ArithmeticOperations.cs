﻿using System;

namespace ArithmeticOperations
{
	class ArithmeticOperations
	{
		static void Main()
		{
			int a = 23;
			int b = 45;
			double angle = 1.4;

			// Математические операции записываются естественным образом
			int c = (a + b) / 2;

			//Класс Math содержит полезные методы и константы
			Console.WriteLine(Math.Sin(angle));

			var d = a - b;
			/* часто понятно, какого типа должна быть переменная. В этом случае можно писать var
			 * Компилятор самостоятельно догадается, что именно вы имели в виду
			 */

			// это целое число
			var e = a / 2;
			// это число с плавающей точкой
			var f = a / 2.0;

			c = b = a;
			/* Как это работает? b=a - оператор присвоения, но он имеет собственное 
			 * возвращаемое значение (равное a)
			 * Поэтому c = b = a выполняется так:
			 * - b присваивается a
			 * - c присваивается результату b=a, который также равен a
			 * В итоге все три переменные будут равны
			 */

			a -= 4;
			// То же самое, что a=a-4, аналогично с другими операциями.

			a++;
			//Оператор инкремента
			//То же самое, что a=a+1

			a--;
			//Оператор декремента
			//То же самое, что a=a-1

			++a;
			//То же самое, что a=a+1, но с одним отличием:

			a = 5;
			Console.WriteLine(a++);
			// выведет 5

			a = 5;
			Console.WriteLine(++a);
			// выведет 6

		}
	}
}

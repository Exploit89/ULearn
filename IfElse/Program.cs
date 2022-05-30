using System;

namespace IfElse
{
    internal class Program
    {
		public static void Main()
		{
			var a = int.Parse(Console.ReadLine());

			if (a == 0) Console.WriteLine("A is zero");
			// если действие if состоит из одного оператора, его можно писать без фигурных скобок

			if (a == 1)
			{
				//В противном случае нужно обнести нужные операторы скобками
				Console.Write("Let me think... ");
				Console.WriteLine("A is one!");
			}

			if (a % 2 == 0) Console.WriteLine("A is even"); // тут ошибка на видео: перепутаны odd и even
			else Console.WriteLine("A is odd");

			if (a < 0) Console.WriteLine("A is negative");
			else if (a < 10) Console.WriteLine("A consists of one digit");
			else
			{
				var num = a.ToString().Length;
				Console.WriteLine("The number of digits in A is {0}", num);
				if (a > 1000)
					Console.Write("A is enormous!");
			}
		}
	}
}

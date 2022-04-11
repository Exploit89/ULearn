using System;

namespace Methods
{
	class Methods
	{

		// Это метод, возвращающий значение типа int, принимающий два аргумента типа double.
		// Его можно называть функцией, но это название не очень распространено.
		// Сигнатура метода - это совокупность имени метода и последовательности типов аргументов
		static int DivideAndRound(double a, double b)
		{
			// return указывает, какое значение будет возвращено
			return (int)Math.Round(a / b);
		}

		// Это метод, не возвращающий значения. Вместо типа возвращаемого значения стоит void
		static void WriteNumber(int number)
		{
			Console.WriteLine(number);

			// return указывается без значения, и его следует опускать, когда это возможно
			return;
		}

		static void WriteNumber(int number, int anotherNumber)
		{
			Console.WriteLine(number);
			Console.WriteLine(anotherNumber);
		}

		static void Main()
		{
			WriteNumber(DivideAndRound(10.5, 2.1));
			Console.WriteLine(Math.Ceiling(10.01));
			Print(GetSquare(42));
			Console.WriteLine("\n");
			Console.WriteLine(GetLastHalf("I love CSharp!"));
			Console.WriteLine(GetLastHalf("1234567890"));
			Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
		}

		public static int GetSquare(int number)
		{
			return number * number;
		}
		public static void Print(int numberValue)
		{
			Console.WriteLine(numberValue);
		}

		public static string GetLastHalf(string text)
        {
			int halfText = text.Length / 2;
			string c = text.Substring(halfText, halfText);
			return c.Replace(" ", "");
        }
	}
}

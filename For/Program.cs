using System;

namespace For
{
	public class Program
	{
		public static void Main()
		{
			//Суммируем все числа от 1 до 10
			var sum = 0;
			for (int i = 1; i <= 10; i++)
				sum += i;

			// Чтобы сделать что-то N раз, мы делаем цикл от 0 до N. 
			// В C# принято в таких случаях делать цикл именно от 0 до i<N, 
			// а не от 1 до i<=N, например.
			for (int i = 0; i < 10; i++)
				Console.WriteLine(i);

			// Выводим все символы строки
			string str = "abc";
			for (int i = 0; i < str.Length; i++)
				Console.Write(str[i]);

			//Декремент
			for (int i = 9; i >= 0; i--)
				Console.Write(i + " ");

			Console.WriteLine();
			//Допускается произвольное изменение переменной
			for (int i = 1; i < 100; i *= 2)
				Console.Write(i + " ");

			Console.WriteLine();
			//Не обязательно инициализировать переменную
			int start = int.Parse(Console.ReadLine());
			for (; start >= 0; start--)
				Console.Write(start + " ");

			Console.WriteLine();
			//И условие тоже может быть произвольным
			for (; start * start < 5 * start; start++)
				Console.Write(start + " ");

			Console.WriteLine();

			//Проверка условия осуществляется КАЖДУЮ итерацию цикла! 
			//Поэтому в данном случае лучше ввести переменную var bound=GetBound() 
			//и сравнивать с ней, а не вызывать цикл каждый раз
			for (int i = 0; i < GetBound(); i++)
				Console.Write(i + " ");
		}

		static int GetBound()
		{
			Console.Write("!");
			return 5;
		}
	}
}

using System; //закомментируйте эту строчку, чтобы получить ошибку

namespace Mistakes
{
	class Program
	{
		private static int _number1 = _number2;
		private static int _number2 = 5;

		public static void Main()
		{
			Console.WriteLine(_number1);
		}
	}
}
// Ошибка: The name 'Console' does not exist in the current context
// Решение: правой кнопкой на Console -> Resolve -> using System;
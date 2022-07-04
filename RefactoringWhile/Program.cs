using System;

namespace RefactoringWhile
{
	public class Program
	{
		/* Допустим, мы хотим читать из консоли числа и суммировать их, 
		 * пока не будет введена пустая строка. Как это сделать?
		 * 
		 * Хочется написать как-то так:
			while (line != "")
			{
				string line = Console.ReadLine(); 
				sum += int.Parse(line);
				line = Console.ReadLine();
			}
		 * но нельзя, потому что line видна только внутри блока while, но не в его условии
		 */

		static void FirstWay()
		{
			var sum = 0;
			string line = Console.ReadLine();
			while (line != "")
			{
				sum += int.Parse(line);
				line = Console.ReadLine();
			}
			// неудобное определение переменной + дублирование кода!
		}

		static void SecondWay()
		{
			var sum = 0;
			string line = null;
			while ((line = Console.ReadLine()) != "")
				sum += int.Parse(line);

			// неудобочитаемо
		}

		static void RightWay()
		{
			int sum = 0;
			while (true)
			{
				var line = Console.ReadLine();
				//break прерывает выполнение инструкций цикла и выходит из него:
				if (line == "") break;
				sum += int.Parse(line);
			}
			//Оптимальный вариант - все читаемо и логика цикла понятна
		}
	}
}

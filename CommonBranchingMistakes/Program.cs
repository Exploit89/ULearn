using System;

namespace CommonBranchingMistakes
{
	public enum Color
	{
		Red,
		Green,
		Blue
	}

	public class Program
	{
		static string GetColorNameWrongWay(Color color)
		{
			if (color == Color.Red) return "Красный";
			if (color == Color.Blue) return "Синий";
			if (color == Color.Green) return "Зеленый";

			return "";
			/* 
			компилятор не знает, что это взаимоисключающие возможности!
			Если закомментировать предыдущую строку, то будет ошибка 
			"not all code paths return a value".
			Т.е. существуют некоторые ветви алгоритма, которые не возвращают значения. 
			Но метод должен вернуть значение в любом случае, поэтому это - ошибка. 
			*/
		}

		static string GetColorNameGoodWay(Color color)
		{
			if (color == Color.Red) return "Красный";
			if (color == Color.Blue) return "Синий";
			if (color == Color.Green) return "Зеленый";
			throw new Exception("Unknown color " + color);
			/* 
			В большинстве случаев писать нужно именно так.
			Если появится новый цвет, то "магическая" строка throw new Exception
			сгенерирует исключительную ситуацию, которая прервет работу программы.

			Обычно падение программы в таком случае лучше, чем некорректная работа.
				(Лучше вообще не стрелять, чем стрелять не туда)
			*/
		}

		// Если совершенно точно известно, что новые цвета появляться не будут, можно писать так:
		static string GetColorName(Color color)
		{
			if (color == Color.Red) return "Красный";
			else if (color == Color.Blue) return "Синий";
			else return "Зеленый";
		}

		//Часто встречающиеся стилевые ошибки

		//Допустим, вы решили написать метод, возвращающий отрицание переменной
		static bool Negate(bool argument)
		{
			return !argument;
			// так правильно

			/*
			 * if (argument) return false;
			 * else return true;
			 * - а так - нет.
			 */
		}

		//Или метод, сравнивающий два значения
		static bool LessThan(int arg1, int arg2)
		{
			return arg1 < arg2;
			//так правильно

			/*
			 * if (arg1<arg2) return true;
			 * else return false;
			 * - а так - нет
			 */
		}
	}
}

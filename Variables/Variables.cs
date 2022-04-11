using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
	class Program
	{
		static string globalVariable = "Global variable";

		static void MethodA()
		{
			if (globalVariable == "")
			{
				string temporalVariable = "Temporal variable";
				Console.WriteLine(temporalVariable);
			}

			string localVariable = "Local variable";

			// Так можно — эта переменная используется в той же области, где и объявлена:
			Console.WriteLine(localVariable);

			// Так нельзя — temporalVariable определена только внутри блока if:
			// Console.WriteLine(temporalVariable); 
		}

		static void MethodB()
		{
			// Console.WriteLine(localVariable); //Нельзя — переменная определена в другом методе.
			Console.WriteLine(globalVariable); //Можно — это глобальная переменная

		}
	}

	class Sample1
	{
		static int F()
		{
			i = 1;
			return i;
		}

		static int i = 0;
	}

	class Sample2
	{
		static string who = "class";

		static void F()
		{
			string who = "F";
		}

		static string G()
		{
			F();
			return who;
		}

		static string H()
		{
			string who = "H";
			F();
			return who;
		}
	}

	class Sample3
	{
		static string who = "class";

		static string Mixed()
		{
			Console.Write(who + " ");
			string who = "Mixed";
			Console.Write(who);
			return who;
		}

		public static void Main()
		{
			Console.WriteLine(Mixed());
		}
	}
	class Sample4
	{
		void M1()
		{
			int i = 0;
			{
				int i = 1;
			}
		}
		void M2(int i)
		{
			int i = 0;
		}
		void M3()
		{
			// Фигурными скобками можно группировать операторы (правда почти никогда этого делать не стоит)
			// и каждая пара фигурных скобок создает свою область видимости.
			{
				int i = 0;
			}
			{
				int i = 1;
			}
		}
	}
}

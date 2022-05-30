using System;

namespace While
{
    public class Program
    {
        public static void Main()
        {
            int number = 1;
            while (number < 100)            // пока выполняются условия
            {
                number *= 2;                // делай инструкции в теле цикла
                Console.WriteLine(number);
            }
        }
    }

    public class Program2
    {
        public static void Main()
        {
            int sum = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "") break;
                if (line.Length > 100) continue; //запросить следующую линию
                sum += int.Parse(line);
            }
        }
    }

    public class Program3
    {
        public static void Main()
        {
            //Для выхода из вложенного цикла приходится использовать
            //конструкцию "double break"

            var sum = 0;
            while (true)
            {
                bool stop = false;
                while (true)
                {
                    sum += int.Parse(Console.ReadLine());
                    if (sum > 100)
                    {
                        stop = true;
                        break; //этот break выходит только из внутреннего цикла
                    }
                }
                if (stop)
                {
                    break; //этот break выходит из внешнего цикла по флагу stop
                }
            }
        }
    }
}

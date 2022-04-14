using System;

namespace ConstantsAndEnums
{
    internal class ConstantsAndEnums
    {
        const double Pi = 3.14159;
        enum DayOfTheWeek // Объявление перечисления
        {
            Monday, // Это перечислитель. По умолчанию DayOfTheWeek.Monday = 0;
            Tuesday, // И это перечислитель. DayOfTheWeek.Tuesday = 1;
            Wednesday,
            Thursday,
            Friday,
            Saturday, 
            Sunday
        }

        enum DayOfTheWeek_v2
        {
            Monday, // По умолчанию DayOfTheWeek.Monday = 0;
            Tuesday, // DayOfTheWeek.Tuesday = 1;
            Wednesday = 10, // DayOfTheWeek.Wednesday теперь равен 10, а не 2,
            Thursday, // а значение DayOfTheWeek.Thursday будет равно 11;
            Friday,
            Saturday,
            Sunday
        }

        enum DayOfTheWeek_v3 : short
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DayOfTheWeek.Tuesday);
        }
    }
}

using System;

namespace ArraysAndForeach
{
    internal class Program
    {
        public static void Main()
        {
            //Объявляем переменную array, точно так же, как раньше объявляли переменные других типов.
            //Тип массива чисел - это int[]. Аналогично, есть типы string[], double[], и т.д.
            int[] array;
            int number;

            //Инициализируем переменную array значением "new int[3]" - новый массив длины 3. 
            array = new int[3];
            number = 10;

            //Обращение к элементам массива
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            //Массив, как и остальные типы, имеет собственные свойства и методы
            Console.WriteLine(array.Length); //Выведет 3

            //Обратите внимание, что array.ToString() работает не так, как хотелось бы.
            Console.WriteLine(array.ToString()); //Выведет System.Int32[]

            //Этот код вызовет exception - выход за границы массива
            Console.WriteLine(array[100]);

            var array2 = new[] { 1, 2, 3 };

            //Элементы массива можно пробежать так
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);

            // Но лучше использовать специально предназначенный для этого оператор foreach 
            // Работает он аналогично циклу for выше.
            // Однако исключает любые ошибки в индексах и выглядит понятнее.
            foreach (var e in array2)
                Console.WriteLine(e);

            // Иногда, когда нужны именно индексы, foreach не подходит.
            // Например, в случае присвоения элементов массива 
            for (int i = 0; i < array2.Length; i++)
                array2[i] = 2 * i;
        }
    }
}

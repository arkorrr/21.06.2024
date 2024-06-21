using System.Diagnostics.CodeAnalysis;

namespace _21._06._2024
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 Пользователь вводит длину сторон пятиугольника, длина каждой стороны заносится в массив, необходимо вычислить периметр пятиугольника (периметр – сумма всех сторон). 
            //Решить задачу двумя способами – с помощью соответствующего метода класса System.Array и «вручную».
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter a number: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(arr.Sum());

            //Task2
            //Пользователь вводит в массив прибыль фирмы за год(12 месяцев). 
            //Необходимо определить месяц, в котором прибыль была максимальна, и месяц, в котором прибыль была минимальна.

            int[] Array = new int[12];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Enter a number: ");
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Array.Max());
            Console.WriteLine(Array.Min());

            //Task3
            //Создать массив целых чисел размером 10 элементов.Заполнить его случайными числами в диапазоне от - 9 до 9 включительно.
            //Найти сумму нечетных элементов. Найти сумму элементов с нечетными индексами.
            int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-9, 10);
                }
                int sumOdd = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        sumOdd += array[i];
                    }
                }
                int sumOddIndices = 0;
                for (int i = 1; i < array.Length; i += 2)
                {
                    sumOddIndices += array[i];
                }

                Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
                Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
                Console.WriteLine($"Сумма элементов с нечетными индексами: {sumOddIndices}");
            
        }
    }
}

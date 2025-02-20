using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ввод последовательности чисел
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string output1;
        string output2;
        // Преобразуем строку в массив чисел
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        // Проверка на достаточное количество чисел
        if (numbers.Length < 4)
        {
            Console.WriteLine("Последовательность должна содержать хотя бы 4 элемента.");
            return; // Завершаем выполнение программы, если чисел меньше 4
        }

        var result = Logic.Search(numbers);

        // Вывод результата
        output1 = $"Два наибольших элемента: {result.max1} {result.max2}";
        output2 = $"Два наименьших элемента: {result.min1} {result.min2}";
    }
}

public class Logic
{
    public struct Result
    {
        public int min1;
        public int min2;
        public int max1;
        public int max2;
    }

    public static Result Search(int[] numbers)
    {
        // Сортировка массива чисел
        Array.Sort(numbers);

        // Два наименьших элемента
        int min1 = numbers[0];
        int min2 = numbers[1];

        // Два наибольших элемента
        int max1 = numbers[numbers.Length - 1];
        int max2 = numbers[numbers.Length - 2];

        return new Result { min1 = min1, min2 = min2, max1 = max1, max2 = max2 };
    }
}

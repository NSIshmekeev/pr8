using System;

class Program
{
    static void Main()
    {
        Random rand = new Random()
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение случайного числа: ");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное значение случайного числа: ");
        int maxValue = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Сгенерированные элементы массива:");
        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(minValue, maxValue + 1);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        int maxElement = int.MinValue;
        int minElement = int.MaxValue;
        int firstMaxIndex = -1;
        int lastMinIndex = -1;

        for (int i = 0; i < n; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                firstMaxIndex = i;
            }
            if (array[i] < minElement)
            {
                minElement = array[i];
                lastMinIndex = i;
            }
        }

        if (firstMaxIndex >= lastMinIndex)
        {
            Console.WriteLine("Ошибка: первый максимальный элемент находится после последнего минимального элемента.");
        }
        else
        {
            int sum = 0;
            for (int i = firstMaxIndex + 1; i < lastMinIndex; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Сумма элементов между первым максимальным и последним минимальным элементами: " + sum);
        }
    }
}

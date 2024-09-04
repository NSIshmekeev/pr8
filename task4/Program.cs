using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Введите размер массива (n×n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение случайного числа: ");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное значение случайного числа: ");
        int maxValue = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            jaggedArray[i] = new int[n];
        }

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                jaggedArray[i][j] = rand.Next(minValue, maxValue + 1);
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine();
        }

        int[] lastOddInColumn = new int[n];

        for (int i = 0; i < n; i++)
        {
            lastOddInColumn[i] = -1;
        }

        for (int col = 0; col < n; col++)
        {
            for (int row = n - 1; row >= 0; row--)
            {
                if (jaggedArray[row][col] % 2 != 0)
                {
                    lastOddInColumn[col] = row;
                    break;
                }
            }
        }

        Console.WriteLine("Номера последнего нечетного элемента в каждом столбце:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Столбец {i + 1}: {lastOddInColumn[i]}");
        }
    }
}

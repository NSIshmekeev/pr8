using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение случайного числа: ");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальное значение случайного числа: ");
        int maxValue = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Сгенерированная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(minValue, maxValue + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine(); 
        }

        int matrixNorm = 0;
        for (int i = 0; i < rows; i++)
        {
            int rowMax = int.MinValue; 
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > rowMax)
                {
                    rowMax = matrix[i, j];
                }
            }
            matrixNorm += rowMax; 
        }

        Console.WriteLine("Норма матрицы по формуле A = ∑max(a_i,j) = " + matrixNorm);
    }
}

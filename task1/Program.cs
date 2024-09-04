Random rand = new Random();

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

// Ввод элементов массива
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(1, 100);
}



// Подсчет суммы квадратов четных элементов
int sumOfSquares = 0;
foreach (int num in array)
{
    if (num % 2 == 0)
    {
        sumOfSquares += num * num;
    }
}
PrintMas(array);

Console.WriteLine("Сумма квадратов четных элементов: " + sumOfSquares);

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());


int[,] array2 = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array2[i, j] = rand.Next(1, 100);
    }
}

PrintMas1(array2);

sumOfSquares = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        int num = array2[i, j];
        if (num % 2 == 0)
        {
            sumOfSquares += num * num;
        }
    }
}

Console.WriteLine("Сумма квадратов четных элементов: " + sumOfSquares);

void PrintMas(int[] array)
{
    foreach (int num in array)
    {
        Console.WriteLine(num + " ");
    }
    Console.WriteLine();
}

void PrintMas1(int[,] array)
{
    int rows = array.GetLength(0); 
    int cols = array.GetLength(1); 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine(); 
    }
}
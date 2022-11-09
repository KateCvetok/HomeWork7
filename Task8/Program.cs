// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(min, max + 1);

        }

    }

    return matrix;
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int SumElements(int[,] matrix)
{
    int index = 0;
    int result = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += matrix[i, j];
                result += matrix[i, j];
            }

            else sum += matrix[i, j];
        }
        if (sum < result)
        {
            result = sum;
            index = i;
        }
        sum = 0;
    }

    return index;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
FillMatrix (array2D);


PrintMatrix (array2D);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименшей суммой элементов: {SumElements(array2D)}");
Console.WriteLine();



// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 

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

int SumElements(int[,] matrix)
{
int sum = default;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i == j) sum += matrix[i, j];
}
}
return sum;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, "); // 4 добавили чтобы код в консоли выводился красиво
            else Console.Write($"{matrix[i, j],4}"); // 4 добавили чтобы код в консоли выводился красиво
        }
        Console.WriteLine("]");
    }
}
int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);

int sumElements = SumElements(array2D);
Console.WriteLine(sumElements);

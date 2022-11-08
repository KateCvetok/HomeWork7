// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void ChangeMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i += 2)
    {
        for (int j = 0; j < array2D.GetLength(1); j += 2)

        {
            array2D[i, j] *= array2D[i, j];
        }
    }
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
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2D);

Console.WriteLine();

ChangeMatrix(array2D);
PrintMatrix(array2D);
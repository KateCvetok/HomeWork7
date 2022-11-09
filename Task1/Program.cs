// Показать двумерный массив размером m×n заполненный вещественными числами


double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rndNum = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(rndNum, 2);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
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

double[,] arr1 = CreateMatrixRndDouble(3, 4, -9, 9);
PrintMatrixDouble(arr1);
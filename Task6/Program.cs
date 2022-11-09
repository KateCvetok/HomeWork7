//  Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


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

double[] AverageMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];

            result[j] = sum / matrix.GetLength(0);
        }
    }
    return result;
}


void PrintNewArray (double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}    ");
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

    int[,] array2D = CreateMatrixRndInt(3, 4, 1, 5);

    PrintMatrix(array2D);
    Console.WriteLine();

    double[] averageMatrix = AverageMatrix(array2D);
    PrintNewArray(averageMatrix);


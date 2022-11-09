// Показать позиции  элемента в двумерном массиве, и возвращать значение этого элемента или же указать,  что такого элемента нет.


Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

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

void ElementsMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)

        {
            if (row >= 0 && row < array2D.GetLength(0) && column >= 0 && column < array2D.GetLength(1))
            {
                Console.WriteLine(array2D[row, column]);
              
            }
            else Console.WriteLine ("Такого элемента не существует");
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2D);

ElementsMatrix(array2D);

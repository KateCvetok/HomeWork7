// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] matr, int m, int n)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindIndex(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i, j] == number) Console.Write($"Данное число находится на позиции: {i}; {j}; ");
}
bool FindNumber(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)

        for (int j = 0; j < matr.GetLength(1); j++)

            if (matr[i, j] == number) return true;
    return false;
}


Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[n, m];
Console.WriteLine("Массив: ");
FillArray(matrix);
PrintArray(matrix, m, n);
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
if (FindNumber(matrix, num)) FindIndex(matrix, num);
else Console.WriteLine("Такого элемента нет");
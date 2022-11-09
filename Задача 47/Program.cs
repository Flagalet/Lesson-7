// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (10 + 10) - 10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите колличество строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(line, colums);
PrintArray(array);

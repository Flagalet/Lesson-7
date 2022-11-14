// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            array[i, j] = new Random(). Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void AverageArray(int[,] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {    
            sum += array[j, i];
        }
        sum = sum / array.GetLength(0);
        if(i != array.GetLength(1)-1)
        {
            Console.Write($"{sum:f1}; ");
        }
        if(i == array.GetLength(1)-1)
        {
            Console.Write($"{sum:f1}. ");
        }
    }
    
}


Console.Clear();
int[,] array = GetArray(4, 4);
PrintArray(array);
AverageArray(array);
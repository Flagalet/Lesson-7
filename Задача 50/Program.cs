// Задача 50. Напишите программу, которая на вход принимает число и 
// возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.

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
                                        
int SearchNumI(int[,] array, int n)
{
    int i = 0;
    int j = 0;
        for(i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
                {
                    if(n == array[i, j])
                    {
                        return i;
                        break;   
                    }
                }
        }
        return -1;
}

int SearchNumJ(int[,] array, int n)
{
    int i = 0;
    int j = 0;
        for(i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
                {
                    if(n == array[i, j])
                    {
                        return j;
                        break;   
                    }
                }
        }
        return -1;
}
void PrintSearchArray(int a, int b, int n)
{
    
        if(a > -1 && b > -1)
            {
                Console.WriteLine($"Индекс элемента {a}, {b}");
            }
        else
        {
            Console.WriteLine($"Число: {n} отсутствует в данном массиве");
        }
}
    
Console.Clear();
int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine("Введите число для поиска: ");
int num = int.Parse(Console.ReadLine()!);
int a = SearchNumI(array, num);
int b = SearchNumJ(array, num);
PrintSearchArray(a, b, num);

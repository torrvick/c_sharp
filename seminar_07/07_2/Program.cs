// Задача 2 (50). Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

Console.WriteLine();
int[,] array = GetRandArray(7, 7, 100);
PrintArray(array);

Console.Write("Введите индекс строки искомого элемента: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите индекс столбца искомого элемента: ");
int col = int.Parse(Console.ReadLine()!);

if(row <= array.GetLength(0) && col <= array.GetLength(1))
    Console.WriteLine($"Искомый элемент: {array[row, col]}");
else
    Console.WriteLine("Заданная позиция выходит за пределы массива");


int[,] GetRandArray(int m, int n, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],4}");      
        Console.WriteLine();
    }
Console.WriteLine();
}

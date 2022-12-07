// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] rand2DArray = GetArray(3, 5, 0, 11);

Console.WriteLine();
PrintArray(rand2DArray);
int sum,row;
FindMinRow(rand2DArray, out row, out sum);
Console.WriteLine($"Наименьшая сумма элементов {sum} в строке {row}");
Console.WriteLine();

void FindMinRow(int[,] array, out int row, out int sum)
{
    sum = 0;
    int sum_current = 0;
    row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum_current += array[i, j];
        if (i == 0)
            sum = sum_current;
        if (sum_current < sum)
        {
            sum = sum_current;
            row = i;
        }
        sum_current = 0;
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
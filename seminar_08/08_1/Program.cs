// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] rand2DArray = GetArray(5, 5, -10, 11);

Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(rand2DArray);
Sort2DArrayDesc(rand2DArray);
Console.WriteLine("Отсортированный массив:");
PrintArray(rand2DArray);

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

void Sort2DArrayDesc(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxValue = array[i, 0];
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    maxValue = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = maxValue;
                }
            }

        }
    }
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
// Задача 1(47). Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальный элемент массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

Console.WriteLine();
PrintArray(GetRandDoubleArray(rows, cols, maxValue));

double[,] GetRandDoubleArray(int m, int n, int maxValue)
{
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble() * maxValue;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],6:f2}");      
        Console.WriteLine();
    }
Console.WriteLine();
}
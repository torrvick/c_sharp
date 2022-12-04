// Задача 3 (52). Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = GetRandArray(7, 7, 10);

Console.WriteLine();
PrintArrayWAvg(array);
Console.WriteLine();

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

void PrintArrayWAvg(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        //Console.Write("\t");
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],6}");      
        Console.WriteLine();
    }

    for(int i = 0; i < array.GetLength(1); i++)
        Console.Write("------");
    Console.WriteLine();

    for(int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            summ += array[i,j];
        Console.Write($"{summ/array.GetLength(0),6:f1}");
    }

Console.WriteLine();
}

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine();
Print3DArray(Get3DArray(2, 2, 2), true);

int[,,] Get3DArray(int m, int n, int z)
{
    int[,,] array = new int[m, n, z];
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) 
                array[i, j, k] = new Random().Next(10, 100);
        }
    }
    return array;
}

void Print3DArray(int[,,] array, bool printCoord = false)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k],4}");
                if (printCoord == true) Console.Write($" ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

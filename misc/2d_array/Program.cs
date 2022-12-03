Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine();
PrintArray(array);
//Console.WriteLine("--------------------");
//Console.WriteLine(MainDiagSumm(array));
//ArrayMod(array);

PrintArray(SortArrayCol(array));
// ------------------Методы-----------------------


// Метод создания двумерного массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(10);
        }
    }
    return result;
}


// Метод печати двумерного масссива
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],4}");      
        Console.WriteLine();
    }

    for(int i = 0; i < array.GetLength(1); i++)
        Console.Write("----");
    Console.WriteLine();
}

// Удвоение элементов с четными индексами
int[,] ArrayMod(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i,j] *= array[i,j];
        }
    }
    return array;
}


// Сумма элементов главной диагонали
int MainDiagSumm(int[,] array)
{   
    int result = 0;
    for(int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); i++, j++)
    {
        //Console.WriteLine(array[i,j]);
        result += array[i,j];
    }
    return result;
}

// Сортировка элементов столбца

int[,] SortArrayCol(int[,] array)
{
    for(int j = 1; j < array.GetLength(1); j += 2)
    {   
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int k = i + 1; k < array.GetLength(0); k++)
            {
                if (array[i,j] > array[k,j])
                {
                    int buff = array[i,j];
                    array[i,j] = array[k,j];
                    array[k,j] = buff;
                }
            }
        }
    }
    return array;
}

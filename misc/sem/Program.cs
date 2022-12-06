/* int[,] array = GetRandArray(4, 4, 10);
PrintArray(array);
RowsChange(array);
Console.WriteLine();
PrintArray(array);


void RowsChange(int[,] array)
{
    int temp;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0,j];
        array[0,j] = array [array.GetLength(0) - 1, j];
        array [array.GetLength(0) - 1, j] = temp;
    }
} */


void RowsColsChange(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Разное количество строк и столбцов");
    else
    {
        int temp;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = i+1; j < array.GetLength(1); j++)
            {
                temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
} 

/* int[,] array = GetRandArray(5, 5, 10);
PrintArray(array);
//RemoveColRow(array);
Console.WriteLine();
PrintArray(RemoveColRow(array));

int[,] RemoveColRow(int[,] array)
{
    int min = array[0,0];
    int row = 0;
    int col = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i,j];
                row = i;
                col = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{row}  {col}");
    Console.WriteLine();
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for(int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    { 
            if(i == row)
            {
                x--;
                continue;
            }
            else
            {
                for(int j = 0, y = 0; j < array.GetLength(1); j++, y ++)
                {
                    if(j == col)
                    {
                        y--;
                        continue;
                    }
                    else newArray[x,y] = array[i,j];
                }
            }
    }
    return newArray;

} */




int[,] GetRandArray(int m, int n, int max)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(max);
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
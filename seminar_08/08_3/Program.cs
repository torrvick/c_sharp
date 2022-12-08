// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] matrix1 = GetMatrix(2, 3, 1, 6);
int[,] matrix2 = GetMatrix(4, 3, 1, 6);

Console.WriteLine();
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("Результат перемножения матриц:");
try
{
    int[,] matrixMult = MatrixMult(matrix1,matrix2);
    PrintMatrix(matrixMult);
}
catch (Exception e) 
{
    Console.WriteLine($"Ошибка: {e.Message}");
}
//PrintMatrix(MatrixMult(matrix1,matrix2));


int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
        throw new Exception("Эти матрицы нельзя перемножить");
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
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

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
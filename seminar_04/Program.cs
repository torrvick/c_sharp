// Задача 1 (25)
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {A} в степени {B} равно {CustomPow(A,B)}");


int CustomPow(int A, int B)
{
    int pow = A;
    for (int i = 1; i < B; i++) pow *= A;
    return pow;
}


//----------------------------------------------------------------
// Задача 2 (27)
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр равна {DigSum(number)}");

int DigSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }    
    return sum;
} */


//----------------------------------------------------------------
// Задача 3 (29)
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/* Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите максимальный элемент массива: ");
int max_num = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Массив из {size} случайных элементов, максимальный из которых может быть раввен {max_num} выглядит так:");
Console.WriteLine($"[{String.Join(", ", FillRandArray(size, max_num))}]");

int[] FillRandArray(int size, int max_num) //size - размер массива, max_num - максимальное значение элемента в массиве
{
    int[] array = new int[size];
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(0, max_num + 1);
    }
    return array;
} */
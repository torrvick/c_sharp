// Задача 1 (2)
// Находим максимальное из двух чисел

int number1, number2;
Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else if (number2 > number1)
{
    Console.WriteLine($"max = {number2}");
}
else 
{
    Console.WriteLine("Числа равны");
}

//----------------------------------------------------------------
// Задача 2 (4)
// Находим максимальное из трех чисел

/* int number1, number2, number3;
Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите третье число: ");
number3 = Convert.ToInt32(Console.ReadLine()!);

int max;

if (number2 > number1)
{
    if (number3 > number2) max = number3;
    else max = number2;
}
else 
{
    if (number1 > number3) max = number1;
    else max = number3;
}

Console.WriteLine(max); */

//----------------------------------------------------------------
// Задача 3 (6)
// Проверка четности числа

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет"); */

//----------------------------------------------------------------
// Задача 4 (8)
// Запись четных чисел от 1 до N

/* Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);

int current_number = 1;

while (current_number <= N)
{   
    if (current_number % 2 == 0)
    {
        Console.Write(current_number);
        if (current_number < N-1) Console.Write(", ");
    }
    
    current_number++;
} */

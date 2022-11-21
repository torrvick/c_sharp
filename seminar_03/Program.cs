// Задача 1 (19)
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).
string number = "";
Console.Write("Введите число: ");

while (number.Length < 2)
{
    number = Console.ReadLine()!;
    if (number.Length > 1) break;
    if (number.Length == 0) 
    {
        Console.WriteLine("А это вообще не число! ");
        Console.Write("Введите число: ");
        continue;
    }
    Console.Write("Давайте что-нибудь подлиннее: ");
}

for (int index = 0; index < number.Length / 2; index++)
{
    if (number[index] != number[number.Length - index - 1])
    {
        Console.Write("Число не является палиндромом");
        break;
    }
        
    if (index == number.Length / 2 - 1) Console.Write("Число является палиндромом");
}


//----------------------------------------------------------------
// Задача 2 (21)
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

/* Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"Расстояние между этими точками равно {Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2)):f2}"); */


//----------------------------------------------------------------
// Задача 3 (23)
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

/* Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);

for (int current_number = 1; current_number <= N; current_number++)
{
    Console.WriteLine(Math.Pow(current_number,3));
} */
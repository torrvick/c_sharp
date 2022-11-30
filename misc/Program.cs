/* //Десятичное в двоичное
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

string DecToBin(int dec)
{
    string bin = string.Empty;
    while (dec > 0)
    {
        bin = Convert.ToString(dec % 2) + bin;
        dec /= 2;
    }

    return bin;
}
Console.WriteLine(DecToBin(num)); */

//--------------------------------------------------------------------------
/* // Фибоначчи

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"[{String.Join(", ", Fib(num))}]");

int[] Fib(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
        array[i] = array[i-1] + array[i-2];
    
    return array;
} */
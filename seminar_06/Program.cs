// Задача 1 (41)
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

Console.WriteLine($"Введите числа, каждое с новой строки. Для окончания ввода нажмите Enter без ввода числа.");
int[] array = GetArray();
Console.WriteLine($"Введено {PosCount(array)} {NumCompletion(PosCount(array))} больше ноля");

int[] GetArray()
{
    string get_curr = Console.ReadLine()!;
    string str = get_curr;

    while (get_curr != "")
    {
        get_curr = Console.ReadLine()!;
        if (get_curr == "") break;
        str = str + "," + get_curr;
    }

    string[] array = str.Split(new char[] { ',' });
    int[] int_array = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        int_array[i] = Convert.ToInt32(array[i]);

    return int_array;
}

int PosCount(int[] array)
{
    int count = 0;
    foreach (int el in array)    
        if (el > 0) count++;

    return count;
}

string NumCompletion(int number)
{
    switch (number)
    {
        case 1: 
            return "число";
        case 2: case 3: case 4:
            return "числа";
        default:
            return "чисел";
    }
}


//----------------------------------------------------------------
// Задача 2 (43)
// Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).
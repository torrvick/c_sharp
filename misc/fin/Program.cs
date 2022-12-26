string[] array = {"abc", "defg", "hi", "g", "klmn", "opqrst", "uv", "wxyz"};
Console.WriteLine();
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[\"{String.Join("\", \"", array)}\"]");
Console.WriteLine();

string[] ArrayFilter(string[] array)
{
    string str_temp = "";
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) str_temp += array[i] + ",";
    str_temp = str_temp.Trim(',');
    string[] array_filtered = str_temp.Split(',');
    return array_filtered;
}

Console.WriteLine("Отфильтрованный массив:");
Console.WriteLine($"[\"{String.Join("\", \"", ArrayFilter(array))}\"]");
Console.WriteLine();
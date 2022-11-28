// Задача 1 (34)
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = FillRandArray(10,100,999);
PrintArray(array);

int count = 0;
foreach(int elem in array) 
    if (elem % 2 == 0)
        count ++;

Console.WriteLine($"Количество четных элементов в массиве равно {count}");


//----------------------------------------------------------------
// Задача 2 (36)
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).

/* int[] array = FillRandArray(8,-10,10);
PrintArray(array);

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
    sum += array[i];

Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}"); */


//----------------------------------------------------------------
// Задача 3 (37)
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

/* int[] array = FillRandArray(7,1,10);
int[] mult_array = new int[array.Length / 2 + array.Length % 2];
PrintArray(array);

for (int i = 0; i < mult_array.Length; i++)
{
    mult_array[i] = array[i] * array[array.Length - 1 - i];
    if (i == array.Length - 1 - i)
        mult_array[i] = array[i]; 
}

Console.WriteLine($"Массив с произведениями: \n{String.Join(' ',mult_array)}"); */



//----------------------------------------------------------------
// Задача 4 (38)
// Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.

/* int[] array = FillRandArray(10,-10,10);
PrintArray(array);

int min = array[0];
int max = array[0];

foreach(int elem in array)
{
    if (elem < min) min = elem;
    if (elem > max) max = elem;
}

Console.WriteLine($"Разница между максимальным и минимальным элементами равна {max - min}");
 */
// -----------------------------Методы----------------------------

int[] FillRandArray(int size, int min_num, int max_num) // Размер массива, минимальное значение элемента, максимальное значение элемента
{
    int[] array = new int[size];
    for (int i = 0; i< array.Length; i++)
        array[i] = new Random().Next(min_num, max_num + 1);
    return array;
}

void PrintArray(int[] array, string sep = " ") // Массив, разделитель массива (пробел по умолчанию)
{ 
    Console.WriteLine($"Сгенерированный массив:\n[{String.Join(sep, array)}]"); 
}
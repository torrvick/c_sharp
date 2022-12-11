// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

string Rec(int N)
{
    if (N == 1) return N.ToString();
    return (N + " " + Rec(N - 1));
}
Console.WriteLine(Rec(8));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int Rec(int M, int N)
// {
//     if (M == N) return N;
//     //return (N += Rec(M,N-1));
//     return(M += Rec(M+1,N));
// }
// Console.WriteLine(Rec(4, 8));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Accerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//         if ((n != 0) && (m == 0))
//             return Accerman(n - 1, 1);
//         else
//             return Accerman(n - 1, Accerman(n, m - 1));
// }
// Console.WriteLine(Accerman(3,2));
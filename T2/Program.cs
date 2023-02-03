// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

using static System.Console;
Clear();

WriteLine("Введите начальное число M:");
int M = int.Parse(ReadLine());

WriteLine("Введите конечное число N:");
int N = int.Parse(ReadLine());

int Accermanfunc = acc(M, N);

Write($"Функция Аккермана равняется: {Accermanfunc} ");

int acc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return acc(m - 1, 1);
    else return acc(m - 1, acc(m, n - 1));
}
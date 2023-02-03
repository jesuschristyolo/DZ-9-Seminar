
using static System.Console;
Clear();


Write("Введите натуральное число: ");
int number = int.Parse(ReadLine());


void NumberCounter (int num)
{
    if (num < 0) Write($"{num} не натуральное число");
    if (num == 0 + 1) return;
    Write($"{num - 1} ");
    NumberCounter (num - 1);
}

NumberCounter(number);
using static System.Console;
Clear();


WriteLine("Введите начальное число M:");
int M = int.Parse(ReadLine());

WriteLine("Введите конечное число N:");
int N = int.Parse(ReadLine());


void SumELEMENTS(int numM, int numN, int sum)
{
    if (numM > numN)
    {
        WriteLine($"Сумма всех элементов от M до N: {sum}");
        return;
    }
    sum += (numM++);
    SumELEMENTS(numM, numN, sum);
}

SumELEMENTS(M, N, 0);
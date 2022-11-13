// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine($"Введите M и N: ");
int M;
int.TryParse(Console.ReadLine()!, out M);
int N;
int.TryParse(Console.ReadLine()!, out N);

void SumNatNumbers(int numM, int numN, int sum)
{
    if (numM > numN)
    {
        Console.WriteLine($"{M} {N} -> {sum}");
        return;
    }
    sum = sum + (numM++);
    SumNatNumbers(numM, numN, sum);
}

SumNatNumbers(M, N, 0);

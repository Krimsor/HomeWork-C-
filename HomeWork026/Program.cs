// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int N;

Console.WriteLine($"Введите N: ");
int.TryParse(Console.ReadLine()!, out N);

NumbersSort(N);

//Output(N);
//Console.Write(OutputStr(N));

void NumbersSort(int N, int i = 1)
{
    if (i > N)
    {
        return;
    }
    else
    {
        NumbersSort(N, i + 1);
        Console.Write(i + " ");
    }
}
/*
void Output(int N, int i = 1) //Рекурсия
{
    if (i == N)
    {
        Console.WriteLine(i);
        return;
    }
    Console.Write($"{i} ");
    Output(N, i + 1);
}*/
/*
string OutputStr(int N, int i = 1)
{
    if (i == N)
        return i.ToString() + "\n";
    return $"{i} {OutputStr(N, i + 1)}";
}*/
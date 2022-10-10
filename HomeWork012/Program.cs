// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Сумма цифр в числе {a} = {Summa(a)}");

int Summa(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a /= 10;
    }
    return sum;       
}


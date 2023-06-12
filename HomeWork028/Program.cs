// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine($"Введите m и n: ");
int m;
int.TryParse(Console.ReadLine()!, out m);
int n;
int.TryParse(Console.ReadLine()!, out n);

funAckermann(m, n);
Console.Write(funAckermann(m, n));

int funAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0 && m > 0)
    {
        return funAckermann(m - 1, 1);
    }
    else
    {
        return (funAckermann(m - 1, funAckermann(m, n - 1)));
    }
}


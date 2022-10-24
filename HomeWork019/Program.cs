// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
/*
void PrintArray(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int  j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] tab)
{
    for (int  i = 0; i < tab.GetLength(0); i++)
    {
        for (int  j = 0; j < tab.GetLength(1); j++)
        {
            tab[i,j] = Convert.ToDouble (new Random().Next(-100,100))/10;
        }
    }
}

Console.Write($"Введите размер массива: ");
int  m = int.Parse(Console.ReadLine()!);
int  n = int.Parse(Console.ReadLine()!);
double[,] table = new double[m, n];

FillArray(table);
Console.WriteLine();
PrintArray(table);*/

Console.Write($"Введите размер массива: ");
int n;
int m;
int.TryParse(Console.ReadLine()!, out n);
int.TryParse(Console.ReadLine()!, out m);
double[,] array = new double[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = (new Random().Next(200) - 100) / (double)10;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            tab[i,j] = new Random().Next(-10,10);
        }
    }
}
Console.Write($"Введите размер массива: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int[,] table = new int[m, n];

PrintArray(table);
FillArray(table);
Console.WriteLine();
PrintArray(table);
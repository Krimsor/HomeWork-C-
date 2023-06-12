//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine($"Введите размер массива: ");
int a;
int.TryParse(Console.ReadLine()!, out a);
int b;
int.TryParse(Console.ReadLine()!, out b);
int row;
Console.WriteLine($"Индекс элемента: ");
int.TryParse(Console.ReadLine()!, out row);
int column;
int.TryParse(Console.ReadLine()!, out column);

int[,] array = new int[a, b];

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

if (row < a && column < b)

Console.WriteLine($"-> {array[row,column]}");

else 

Console.WriteLine($"-> такого числа в массиве нет");

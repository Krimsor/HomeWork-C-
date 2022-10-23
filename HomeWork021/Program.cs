// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine($"Введите размер массива: ");
int a;
int.TryParse(Console.ReadLine()!, out a);
int b;
int.TryParse(Console.ReadLine()!, out b);


int[,] array = new int[a, b];

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Среднее арифметическое каждого столбца : ");

for (int j = 0; j < b; j++)
{
    double avg = 0; // avg - arithmeticmean.
    
    for (int i = 0; i < a; i++)
    {
        avg = (avg + array[i, j]);
    }
    avg = avg / a;
    Console.Write(avg + " ");
}

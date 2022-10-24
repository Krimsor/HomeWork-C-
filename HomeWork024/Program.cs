// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine($"Введите размер массива: ");
int a;
int.TryParse(Console.ReadLine()!, out a);
int b;
int.TryParse(Console.ReadLine()!, out b);

int[,] array = new int[a, b];
int[,] secondArray = new int[a, b];
int[,] resultArray = new int[a, b];

FillArray(array);
PrintArray2A(array);

Console.WriteLine();

FillArray(secondArray);
PrintArray2A(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Нельзя перемножать ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2A(resultArray);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2A(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
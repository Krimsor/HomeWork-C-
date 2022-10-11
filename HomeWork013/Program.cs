// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
/*
int[] array = CreateArray();

foreach (var item in array)
    Console.Write($"{item} ");
{int.Parse(Console.ReadLine()!)}
int[] CreateArray()
{
    int[] _array = new int[8];
    for (int i = 0; i < _array.Length; i++)
        _array[i] = new Random().Next(0, 100);
    return _array;
}*/
/*
int [] arr = new int[8];

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine();
}

PrintArray(arr);*/


Console.Write($"Введите количество элементов массива: ");

int elementscount = int.Parse(Console.ReadLine()!);

int [] numbers = new int[elementscount];

Console.WriteLine($"Ввод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine()!); 
}

Console.WriteLine ($"Вывод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} "); 
}

Console.Write ($"-> [");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" {numbers[i]} ");

}
Console.Write ($"]");

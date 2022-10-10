// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int[] array = CreateArray();

foreach (var item in array)
    Console.Write($"{item} ");

int[] CreateArray()
{
    int[] _array = new int[8];
    for (int i = 0; i < _array.Length; i++)
        _array[i] = new Random().Next(0, 100);
    return _array;
}

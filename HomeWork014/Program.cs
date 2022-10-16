// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write($"Введите количество элементов массива: ");

int elementscount = int.Parse(Console.ReadLine()!);

int [] numbers = new int[elementscount];

int count = 0;

Console.WriteLine($"Ввод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(99,1000); 
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine ($"Вывод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" {numbers[i]} ");

}
Console.WriteLine($"-> {count}");

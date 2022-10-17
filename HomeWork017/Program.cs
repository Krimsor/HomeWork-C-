// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите количество элементов массива: ");

int elementscount = int.Parse(Console.ReadLine()!);

int [] numbers = new int [elementscount];

Console.WriteLine($"Ввод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine()!); 
}

int result = 0;

Console.WriteLine ($"Вывод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" {numbers[i]} ");

    if (numbers[i] > 0)
    {
        result++;
    }
}
Console.Write($"-> {result}");
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
Console.Write($"Введите количество элементов массива: ");

int elementscount = int.Parse(Console.ReadLine()!);

double [] numbers = new double[elementscount];

Console.WriteLine($"Ввод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = double.Parse(Console.ReadLine()!); 
}

double min = numbers[0];
double max = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine ($"Вывод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" {numbers[i]} ");

}
double result = max - min;
Console.WriteLine($"-> {result}");
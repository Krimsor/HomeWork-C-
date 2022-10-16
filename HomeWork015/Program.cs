// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write($"Введите количество элементов массива: ");

int elementscount = int.Parse(Console.ReadLine()!);

int [] numbers = new int[elementscount];

int count = 0;

Console.WriteLine($"Ввод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-10,100); 
}

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
    {
        count = numbers[i] + count;
    }
}

Console.WriteLine ($"Вывод массива: ");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" {numbers[i]} ");

}
Console.WriteLine($"-> {count}");

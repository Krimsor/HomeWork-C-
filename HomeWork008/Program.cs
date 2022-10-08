// Напишите программ, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*int a = new Random().Next(10000,100000);
Console.Write($"{a} -> ");*/
Console.Write($"Введите число: ");
string number = Console.ReadLine()!;
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} -> Палиндром");
    }
    else
    {
       Console.WriteLine($"{number} -> НЕ палиндром"); 
    }
}
else
{
    Console.WriteLine($"{number} -> не является пятизначным");
}
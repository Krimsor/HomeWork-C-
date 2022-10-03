// Задача №6 : Напишите программу, которая на вход принимает число и выдает, является ли число четным(делится ли оно на два без остатка).

int a = 0;
Console.Write($"Введите число: ");
string userEnter = Console.ReadLine()!;

a = int.Parse(userEnter);

if (a % 2 == 0)
    {
    Console.WriteLine("число четное");
    }
else 
    {
    Console.WriteLine("чило нечетное");
    }




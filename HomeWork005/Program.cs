// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает ВТОРУЮ цифру этого числа.

int a = new Random().Next(99,1000);

Console.Write($"{a} -> ");

int b2 = a / 10 % 10; /* либо - a % 100 / 10;*/  

Console.Write($"{b2}");


/*
int a = new Random().Next(100,1000);

Console.Write($"{a} -> ");

int b1 = a / 100; //b1 - левое число
int b2 = a % 10; //b2 - правое число 

Console.Write($"{b1}{b2}");

  Интерполяция 
Console.Write($"{a} ");*/
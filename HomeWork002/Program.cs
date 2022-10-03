//Задача №4 : Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

int a = int.Parse(Console.ReadLine()!); 
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

int max = 0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);

/*int a = 2, b = 3, c = 7;
int max = c;
Console.WriteLine(max = c);

int a = 44, b = 5, c = 78;
int max = c;
Console.WriteLine(max = c);

int a = 22, b = 3, c = 9;
int max = a;
Console.WriteLine(max = a);*/
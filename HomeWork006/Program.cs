// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a = new Random().Next();

if (a >= 100)
{
    int b = a % 10;
    Console.Write($"{a} -> {b}");
}

else 
{
    Console.Write($"{a} -> Третьей цифры нет");
}

/*
int a = new Random().Next(0,1000);

if (a >= 100)
{
    int b = a % 10;
    Console.Write($"{a} -> {b}");
}

else 
{
    Console.Write($"{a} -> Третьей цифры нет");
}
*/
/*Console.Write($"{a} -> {a3}");*/


/*
int a = new Random().Next(100,1000);

Console.Write($"{a} -> ");

int b1 = a / 100; //b1 - левое число
int b2 = a % 10; //b2 - правое число 

Console.Write($"{b1}{b2}");

Числовой вариант
-int a = new Random().Next(100,1000);
Console.Write($"{a} -> {a / 100 * 10 + a % 10}"); - в одну строку два числа первое и третье.
  Интерполяция 
Console.Write($"{a} ");

Текстовый Вариант :
При помощи удаления чисел:
int a = new Random().Next(100,1000);

Console.Write($"{a} -> {a.ToString().Remove(1, 1)); - где (1,1) - 1 это допустим (567 - 0 = 5, 6 = 1, 7 = 2 (элемент массива)) 
*/

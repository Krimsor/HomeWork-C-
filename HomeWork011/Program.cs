// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
/*int A, B;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out A);
int.TryParse(Console.ReadLine()!, out B);
int exp = A;

for (int i = 1; i < B; i++)
{
    exp = exp * A;
}
Console.WriteLine($"{A}^{B} -> {exp}");*/

double A, B;
Console.WriteLine($"Введите число: ");
double.TryParse(Console.ReadLine()!, out A);
double.TryParse(Console.ReadLine()!, out B);

double exp = Math.Pow( A, B );
Console.WriteLine($"{A}^{B} -> {exp}");

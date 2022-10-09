// Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = int.Parse(Console.ReadLine()!); 
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!); 
int x2 = int.Parse(Console.ReadLine()!); 
int y2 = int.Parse(Console.ReadLine()!); 
int z2 = int.Parse(Console.ReadLine()!); 

int A = x2 - x1;
int B = y2 - y1;
int C = z1 -z2;


double len = Math.Sqrt( A * A + B * B + C * C );
Console.WriteLine($"Длина отрезка {len}");



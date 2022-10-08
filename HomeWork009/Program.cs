// Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadInt(int x1, int y1, int z1, int x2, int y2, int z2);
{
    Console.Write(A , B , C);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 -z2;

double len = Math.Sqrt( A * A + B * B + C * C );
Console.WriteLine($"Длина отрезка {len}");



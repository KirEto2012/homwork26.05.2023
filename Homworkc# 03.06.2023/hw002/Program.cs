/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Ввидите координату x1,y1,z2");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ввидите координату x2,y2,z2");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine());

int numA = x2 - x1;
int numB = y2 - y1;
int numC = z1 - z2;

double length = Math.Sqrt(numA * numA + numB * numB + numC * numC);
Console.WriteLine($"Растояние между токками = {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите через пробел координаты x,y,z для точки A ");
string koord = Console.ReadLine()!;
string[] parts = koord.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);
int zA = int.Parse(parts[2]);

Console.WriteLine("Введите через пробел координаты x,y,z для точки B ");
koord = Console.ReadLine()!;
parts = koord.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);
int zB = int.Parse(parts[2]);

double R = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB,2) + Math.Pow(zA - zB,2));
Console.WriteLine($"Расстояние между точками A и B = {R:F4}");

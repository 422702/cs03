// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

double cube(int i)
{
    return Math.Pow(i, 3);
}
for (int i = 1; i <= n; i++)
{
   Console.Write($"{cube(i)}");
    if (i < n)
    {
        Console.Write(",");
    }
} 

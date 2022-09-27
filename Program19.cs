// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число ");
        string stroka = Console.ReadLine()!;

        bool palindrom()
        {
            for (int index = 0; index <2; index++)
            {
                if (stroka[index] != stroka[stroka.Length - index - 1])
                {
                    return false;
                }
            }
            return true;
        }

        if (palindrom())
        {
            Console.WriteLine($"Число {stroka} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {stroka} не является палиндромом");
        }
    }
}
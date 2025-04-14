using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 100 && number <= 999) // Проверяем, что число трёхзначное
        {
            int firstDigit = number / 100; // Первая цифра
            int lastDigit = number % 10;   // Последняя цифра

            Console.WriteLine($"Первая цифра: {firstDigit}");
            Console.WriteLine($"Последняя цифра: {lastDigit}");
        }
        else
        {
            Console.WriteLine("Число не является трёхзначным!");
        }
    }
}

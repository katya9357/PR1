using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 100 && number <= 999) // Проверяем, что число трёхзначное
        {
            int firstDigit = number / 100;        // Первая цифра
            int secondDigit = (number / 10) % 10; // Вторая цифра
            int thirdDigit = number % 10;         // Третья цифра

            // Формируем новое число
            int newNumber = firstDigit * 100 + thirdDigit * 10 + secondDigit;

            Console.WriteLine($"Новое число после перестановки второй и третьей цифр: {newNumber}");
        }
        else
        {
            Console.WriteLine("Число не является трёхзначным!");
        }
    }
}

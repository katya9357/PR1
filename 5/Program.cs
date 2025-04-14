using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три целых числа:");

        // Считываем три числа с клавиатуры
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        // Вычисляем произведение чисел
        int product = num1 * num2 * num3;

        // Вывод результата
        Console.WriteLine($"Произведение чисел в прямом порядке: {num1} * {num2} * {num3} = {product}");
        Console.WriteLine($"Произведение чисел в обратном порядке: {num3} * {num2} * {num1} = {product}");
    }
}

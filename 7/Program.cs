using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длины сторон треугольника:");

        // Ввод сторон треугольника
        Console.Write("Сторона a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Сторона b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Сторона c: ");
        double c = double.Parse(Console.ReadLine());

        // Проверка на возможность построения треугольника
        if (a + b > c && a + c > b && b + c > a)
        {
            // Вычисление полупериметра
            double p = (a + b + c) / 2;

            // Формула Герона
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь треугольника: {area}");
        }
        else
        {
            Console.WriteLine("Треугольник с такими сторонами не существует!");
        }
    }
}

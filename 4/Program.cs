using System;

class Program
{
    static void Main()
    {
        // Указанное значение x
        double x = 2.7;

        // Расчет каждого элемента формулы
        double term1 = 3 * Math.Pow(x, 2); // 3x^2
        double term2 = Math.Exp(Math.Sqrt(x)) / (2 * Math.PI); // e^(sqrt(x)) / 2pi
        double term3 = Math.Log(Math.Sqrt(3 - Math.Pow(Math.Sin(x), 2))); // ln(sqrt(3 - sin^2(x)))

        // Общий расчет y
        double y = term1 + term2 - term3;

        // Вывод результата
        Console.WriteLine($"Результат вычисления y при x=2,7: y = {y}");
    }
}

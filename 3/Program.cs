using System;

class Program
{
    static void Main()
    {
        // Подготовка тестовых примеров
        double[] testValues = { 1, 4, 9, 16 }; // Примеры значений m

        foreach (double m in testValues)
        {
            // Расчёт по первой формуле
            double numerator = Math.Sqrt(Math.Pow((3 * m + 2), 2) - 24 * m);
            double denominator = 3 * Math.Sqrt(m) - (2 / Math.Sqrt(m));
            double z1 = numerator / denominator;

            // Расчёт по второй формуле
            double z2 = -Math.Sqrt(m);

            // Вывод результатов
            Console.WriteLine($"Для m = {m}:");
            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");

            // Сравнение результатов
            if (Math.Abs(z1 - z2) < 0.01)
            {
                Console.WriteLine("Результаты совпадают (с учетом погрешности).");
            }
            else
            {
                Console.WriteLine("Результаты не совпадают.");
            }
            Console.WriteLine();
        }
    }
}

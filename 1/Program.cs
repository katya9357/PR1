using System;
class Program
{
   static void Main(string[] args)
   {
        Console.Write("Введите масштаб карты (км в одном см): ");
        double scale = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите расстояние между точками на карте (см): ");
        double distanceOnMap = Convert.ToDouble(Console.ReadLine());

        double distanceBetweenTowns = scale * distanceOnMap;
        Console.WriteLine($"Расстояние между населенными пунктами: {distanceBetweenTowns} км");

   }
}

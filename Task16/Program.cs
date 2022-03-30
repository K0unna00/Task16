using System;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car sayini daxil edin");
            int count = int.Parse(Console.ReadLine());
            Car[] cars = new Car[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Brandi daxil et");
                string brand = Console.ReadLine();
                Console.WriteLine("Color daxil et");
                string color = Console.ReadLine();
                Console.WriteLine("Millage daxil et");
                int millage = int.Parse(Console.ReadLine());
                Console.WriteLine("Hazirki benzini daxil et");
                int currentFuel = int.Parse(Console.ReadLine());
                Console.WriteLine("1km e ne qeder benzin lazimdir ?");
                int fuelFor1km = int.Parse(Console.ReadLine());
                cars[i] = new Car()
                {
                    Color = color,
                    CurrentFuel = currentFuel,
                    FuelFor1km = fuelFor1km,
                    Brand = brand,
                    Millage = millage
                };
            }
            Console.WriteLine("1. Maşınları millage-e göre filtirlə \n2.Bütün maşınları göstər \n3.Prosesi bitir");
            byte answer = byte.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Min ve max Millage deyerlerini yazin");
                    int minMillage = int.Parse(Console.ReadLine());
                    int maxMillage = int.Parse(Console.ReadLine());
                    FilterForMillage(cars, minMillage, maxMillage);
                    break;
                case 2:
                    ShowAllCars(cars);
                    break;
                default:
                    break;
            }
        }
        static void FilterForMillage(Car[] cars, int millageMin, int millageMax)
        {
            foreach (var item in cars)
            {
                if (item.Millage >= millageMin && item.Millage < millageMax)
                {
                    item.ShowInfo();
                }
            }
        }
        static void ShowAllCars(Car[] cars)
        {
            foreach (Car item in cars)
            {
                item.ShowInfo();
            }
        }

    }
}

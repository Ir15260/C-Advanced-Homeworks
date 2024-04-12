using Homework.C_ADV.Class7.Domain.Database;


namespace Homework.C_ADV.Class7.Domain.Models
{
    public static class CarDataProcessor
    {
        public static void PrintCarsFromEurope()
        {
            List<Car> europeCars = CarDatabase.Cars.Where(car => car.Origin == "Europe").ToList();
            PrintCars(europeCars);
        }

        public static void PrintFilteredCars()
        {
            List<Car> filteredCars = CarDatabase.Cars.Where(car => car.Cylinders > 6 && car.Cylinders != 6)
                                                     .Union(CarDatabase.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110.0))
                                                     .ToList();
            PrintCars(filteredCars);
        }

        public static void PrintCarCountsByOrigin()
        {
            var carCountsByOrigin = CarDatabase.Cars.GroupBy(car => car.Origin)
                                                    .Select(group => $"{group.Key} {group.Count()} models");
            foreach (var count in carCountsByOrigin)
            {
                Console.WriteLine(count);
            }
        }

        public static void PrintPowerfulCarsStats()
        {
            List<Car> powerfulCars = CarDatabase.Cars.Where(car => car.HorsePower > 200).ToList();
            if (powerfulCars.Any())
            {
                double lowestMPG = powerfulCars.Min(car => car.MilesPerGalon);
                double highestMPG = powerfulCars.Max(car => car.MilesPerGalon);
                double averageMPG = powerfulCars.Average(car => car.MilesPerGalon);
                Console.WriteLine($"Lowest Miles per gallon: {lowestMPG}");
                Console.WriteLine($"Highest Miles per gallon: {highestMPG}");
                Console.WriteLine($"Average Miles per gallon: {averageMPG}");
            }
            else
            {
                Console.WriteLine("No cars with more than 200 HorsePower found.");
            }
        }

        public static void PrintTop3FastestCars()
        {
            List<Car> top3FastestCars = CarDatabase.Cars.OrderBy(car => car.AccelerationTime)
                                                         .Take(3)
                                                         .ToList();
            PrintCars(top3FastestCars);
        }

        public static double CalculateTotalWeightOfHighCylinderCars()
        {
            return CarDatabase.Cars.Where(car => car.Cylinders > 6).Sum(car => car.Weight);
        }

        public static double CalculateAverageMPGForEvenCylinderCars()
        {
            return CarDatabase.Cars.Where(car => car.Cylinders % 2 == 0).Average(car => car.MilesPerGalon);
        }

        private static void PrintCars(IEnumerable<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

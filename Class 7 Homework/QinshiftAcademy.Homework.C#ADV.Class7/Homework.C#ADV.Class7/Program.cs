using Homework.C_ADV.Class7.Domain.Database;
using Homework.C_ADV.Class7.Domain.Models;

CarDatabase.LoadCars();

Console.WriteLine("Cars from Europe:");
CarDataProcessor.PrintCarsFromEurope();

Console.WriteLine("\nCars with more than 6 Cylinders (excluding 6) and with 4 Cylinders and HorsePower more than 110.0:");
CarDataProcessor.PrintFilteredCars();

Console.WriteLine("\nCar counts by origin:");
CarDataProcessor.PrintCarCountsByOrigin();

Console.WriteLine("\nStatistics for powerful cars with more than 200 HorsePower:");
CarDataProcessor.PrintPowerfulCarsStats();

Console.WriteLine("\nTop 3 fastest accelerating cars:");
CarDataProcessor.PrintTop3FastestCars();

Console.WriteLine($"\nTotal weight of cars with more than 6 cylinders: {CarDataProcessor.CalculateTotalWeightOfHighCylinderCars()}");

Console.WriteLine($"\nAverage MilesPerGalon for cars with even number of cylinders: {CarDataProcessor.CalculateAverageMPGForEvenCylinderCars()}");
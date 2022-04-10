using System;
using System.Collections.Generic;
using System.Linq;

namespace E3._03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = carsInfo[0];
                int mileage = int.Parse(carsInfo[1]);
                int fuel = int.Parse(carsInfo[2]);
                Car Car = new Car(model, mileage, fuel);
                cars.Add(model, Car);
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] instructions = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = instructions[0];
                if (action == "Drive")
                {
                    string carModel = instructions[1];
                    int distance = int.Parse(instructions[2]);
                    int fuel = int.Parse(instructions[3]);
                   
                    if (cars[carModel].Fuel >= fuel)
                    {
                        cars[carModel].Mileage += distance;
                        cars[carModel].Fuel -= fuel;
                        Console.WriteLine($"{carModel} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (cars[carModel].Mileage >= 100000)
                        {
                            cars.Remove(carModel);
                            Console.WriteLine($"Time to sell the {carModel}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }

                }
                else if (action == "Refuel")
                {
                    string carModel = instructions[1];
                    int fuel = int.Parse(instructions[2]);
                    int startFuel = cars[carModel].Fuel;
                    cars[carModel].Fuel += fuel;
                    if (cars[carModel].Fuel > 75)
                    {
                        fuel = 75 - startFuel;
                        cars[carModel].Fuel = 75;
                    }
                    Console.WriteLine($"{carModel} refueled with {fuel} liters");
                }
                else if (action == "Revert")
                {
                    string carModel = instructions[1];
                    int kilometers = int.Parse(instructions[2]);
                    cars[carModel].Mileage -= kilometers;
                    Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");
                    if (cars[carModel].Mileage < 10000)
                    {
                        cars[carModel].Mileage = 10000;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
    class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}

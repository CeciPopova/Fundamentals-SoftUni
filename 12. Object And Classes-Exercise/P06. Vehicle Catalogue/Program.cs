using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vehicleData=Console.ReadLine();
            List<Vehicles> vehicles = new List<Vehicles>();
            while (vehicleData != "End")
            {
                string[] vehicleArgs = vehicleData.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = vehicleArgs[0];
                string model = vehicleArgs[1];  
                string color = vehicleArgs[2];  
                int hoursePower = int.Parse(vehicleArgs[3]);

                Vehicles vehicle = new Vehicles(type, model, color, hoursePower);
                vehicles.Add(vehicle);  

                vehicleData = Console.ReadLine();
            }

            string command = Console.ReadLine();
            while (command != "Close the Catalogue")
            {
                Vehicles currVehicle = vehicles.First(v => v.Model == command);
                Console.WriteLine(currVehicle);
                command = Console.ReadLine();   
            }

            List<Vehicles> cars=vehicles.Where(v => v.Type == "car").ToList();
            List<Vehicles> trucks = vehicles.Where(v => v.Type == "truck").ToList();

            double sumCarsHorsepower = cars.Sum(v => v.Horsepower);
            double sumTrucksHorsepower = trucks.Sum(v => v.Horsepower);

            double averageCarsHorsepower = 0.00;
            double averageTrucksHorsepower = 0.00;

            if (cars.Count>0)
            {
                averageCarsHorsepower = sumCarsHorsepower / cars.Count;
            }
            if (trucks.Count>0)
            {
                averageTrucksHorsepower = sumTrucksHorsepower / trucks.Count;
            }
           
           
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
        }
    }
    class Vehicles
    {
        public Vehicles(string type,string model,string color,int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {(Type=="car" ? "Car" :"Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");
            return sb.ToString().TrimEnd();
        }
    }
}

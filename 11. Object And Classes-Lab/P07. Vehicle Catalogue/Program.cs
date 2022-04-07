using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();

            List<Car> cars=new List<Car>();
            List<Truck> trucks=new List<Truck>();
            Catalog vehicles=new Catalog(cars,trucks);

            while (command!="end")
            {
                string[] input = command.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type=input[0];
                string brand = input[1];    
                string model = input[2];    
                int powerOrWeight=int.Parse(input[3]);
                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, powerOrWeight);
                    vehicles.Cars.Add(newCar);
                }
                if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, powerOrWeight);
                    vehicles.Trucks.Add(newTruck);
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine("Cars:");
           
            List<Car> orderedCars=vehicles.Cars.OrderBy(c => c.Brand).ToList();
            if (vehicles.Cars.Count>0)
            {
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
                }
            }
           
            Console.WriteLine("Trucks:");
            List<Truck> orderedTrucks = vehicles.Trucks.OrderBy(t => t.Brand).ToList();

            if (vehicles.Trucks.Count>0)
            {
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
           

        }
    }
    class Truck
    {
        public Truck(string brand,string model,int weight)
        {
            this.Brand = brand;
            this.Model = model; 
            this.Weight = weight;   
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }


    }
    class Car
    {
        public Car(string brand,string model,int horsepower)
        {
            this.Brand=brand;
            this.Model=model;   
            this.Horsepower = horsepower;   

        }
        public string Brand { get; set; }

        public string Model { get; set; }
        public int Horsepower { get; set; }
    }
    class Catalog
    {
        public Catalog(List<Car> cars,List<Truck> trucks)
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();   
        }
        public List<Car> Cars { get; set; }
       
        public List<Truck> Trucks { get; set; }

       
    }
}

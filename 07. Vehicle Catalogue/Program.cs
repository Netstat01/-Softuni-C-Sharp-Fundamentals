using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string commant = Console.ReadLine();

                if (commant == "end" )
                {
                    break;
                }

                string[] tokens = commant.Split("/");

                string type = tokens[0];

                switch (type)
                {
                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            Weight = int.Parse(tokens[3])
                        };
                        catalogue.Truck.Add(truck);
                        break;
                    case "Car":
                        Car car = new Car
                        {
                            Brand = tokens[1],
                            Model = tokens[2],
                            HorPower = int.Parse(tokens[3])
                        };
                        catalogue.Cars.Add(car);
                        break;
                }
            }
            if (catalogue.Cars.Count > 0 )
            {
                List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Cars:");
                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorPower}hp");
                }
            }
            if (catalogue.Truck.Count > 0)
            {
                List<Truck> orderedTruck = catalogue.Truck.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Trucks:");
                foreach (var truck in orderedTruck)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorPower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Truck= new List<Truck>();

        }
        public  List<Car> Cars { get; set;}
        public  List<Truck> Truck { get; set; }       
    }
}

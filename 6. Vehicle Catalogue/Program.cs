using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            TypeOfVehicle AllVeachles = new TypeOfVehicle();

            while (true)
            {
                if (command == "End" || (AllVeachles.Cars.Count + AllVeachles.Trucks.Count >50))
                {
                    break;
                    
                }
                string[] parameters = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Vehicle tempParameters = new Vehicle();
                tempParameters.typeOfVehicle = parameters[0];
                tempParameters.modelOfVehicle = parameters[1];
                tempParameters.colorOfVehicle = parameters[2];
                tempParameters.horsepowerOfVehicle = int.Parse(parameters[3]);

                if ((tempParameters.horsepowerOfVehicle <= 1000) &&
                    (tempParameters.typeOfVehicle == "car" || tempParameters.typeOfVehicle == "truck") &&
                    (!AllVeachles.Cars.Select(x => x.modelOfVehicle).Contains(tempParameters.modelOfVehicle) &&
                    !AllVeachles.Trucks.Select(x => x.modelOfVehicle).Contains(tempParameters.modelOfVehicle)))
                {
                    if (parameters[0] == "car")
                    {
                        AllVeachles.Cars.Add(tempParameters);
                    }
                    if (parameters[0] == "truck")
                    {
                        AllVeachles.Trucks.Add(tempParameters);
                    }
                }

                command = Console.ReadLine();
            }


            while (true)
            {
                if (command == "Close the Catalogue")
                {
                    break;
                }
                if (AllVeachles.Cars.Select(x => x.modelOfVehicle).Contains(command))
                {
                    var tepm = AllVeachles.Cars.Find(x => x.modelOfVehicle == command);
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {tepm.modelOfVehicle}");
                    Console.WriteLine($"Color: {tepm.colorOfVehicle}");
                    Console.WriteLine($"Horsepower: {tepm.horsepowerOfVehicle}");
                }

                if (AllVeachles.Trucks.Select(x => x.modelOfVehicle).Contains(command))
                {
                    var tepm = AllVeachles.Trucks.Find(x => x.modelOfVehicle == command);
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {tepm.modelOfVehicle}");
                    Console.WriteLine($"Color: {tepm.colorOfVehicle}");
                    Console.WriteLine($"Horsepower: {tepm.horsepowerOfVehicle}");
                }

                command = Console.ReadLine();
            }
            double tempSumHP = AllVeachles.Cars.Count > 0 ? AllVeachles.Cars.Average(x => x.horsepowerOfVehicle) : 0.00 ;//(double)AllVeachles.Cars.Select(x => x.horsepowerOfVehicle).Sum() / AllVeachles.Cars.Count;
            Console.WriteLine($"{nameof(AllVeachles.Cars)} have average horsepower of: {tempSumHP:f2}.");

            tempSumHP = AllVeachles.Trucks.Count > 0 ? AllVeachles.Trucks.Average(x => x.horsepowerOfVehicle) : 0.00;//(double)AllVeachles.Trucks.Select(x => x.horsepowerOfVehicle).Sum() / AllVeachles.Trucks.Count;
            Console.WriteLine($"{nameof(AllVeachles.Trucks)} have average horsepower of: {tempSumHP:f2}.");
        }
    }
    class TypeOfVehicle
    {
        public List<Vehicle> Cars { get; set; } = new List<Vehicle>();
        public List<Vehicle> Trucks { get; set; } = new List<Vehicle>();
    }
    class Vehicle
    {
        public string typeOfVehicle { get; set; }
        public string modelOfVehicle { get; set; }
        public string colorOfVehicle { get; set; }
        public int horsepowerOfVehicle { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                Box box = new Box
                {
                    SerialNumber = tokens[0],
                    Item = new Item(tokens[1], decimal.Parse(tokens[3])),
                    ItemQuantity = int.Parse(tokens[2])
                };

                boxes.Add(box);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.Price).ToList();

            foreach (var item in orderedBoxes)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.Price:f2}");
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }

    }
}

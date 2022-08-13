using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] infomation = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person temp = new Person(infomation[0], infomation[1], int.Parse(infomation[2]));

                if (Persons.Select(x => x.Id).Contains(infomation[1]))
                {
                    temp = Persons.Find(x => x.Id == infomation[1]);
                    temp.Name = infomation[0];
                    temp.Age = int.Parse(infomation[2]);
                }
                else
                {
                    Persons.Add(temp);
                }
                command = Console.ReadLine();
            }

            Persons.OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x));
            //Persons.Where(x => x.Id == "78911" || x.Id == "123456").OrderBy(x => x.Id).ToList().ForEach(x => Console.WriteLine(x));
           

        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {Id} is {Age} years old.";
        
    }
}

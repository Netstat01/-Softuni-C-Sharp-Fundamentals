using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                string[] studentProps = command.Split(" ");

                Student student = new Student
                {
                    FirstName = studentProps[0],
                    LastName = studentProps[1],
                    Age = int.Parse(studentProps[2]),
                    HomeTown = studentProps[3]
                };

                students.Add(student);
            }
            string cityName = Console.ReadLine();

            foreach (var item in students)
            {
                if (item.HomeTown == cityName)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public int Age { get; set; }
    }
}



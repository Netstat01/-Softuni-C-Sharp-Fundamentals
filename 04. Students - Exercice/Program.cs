using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students___Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> student = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] abautStudent = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                student.Add(new Student
                    (
                    abautStudent[0],
                    abautStudent[1], 
                    abautStudent[2]
                    ));
            }

            student = student.OrderByDescending(student => student.Grade).ToList();

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
    class Student
    {
        public Student(string FirstName, string LastName, string Grade)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Grade = Grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public override string ToString() => $"{FirstName} {LastName}: {Grade}";
        
    }
}


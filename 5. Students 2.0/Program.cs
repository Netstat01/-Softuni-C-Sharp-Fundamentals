using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Students_2._0
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

                Student student = new Student();

                if (isMemberPresent(students, studentProps[0], studentProps[1]))
                {
                    student = studentExist(students, studentProps[0], studentProps[1], int.Parse(studentProps[2]), studentProps[3]);
                    int indexOF = students.IndexOf(indexOfStudent(students, studentProps[0], studentProps[1]));
                    students.RemoveAt(indexOF);
                    students.Insert(indexOF, student);                   
                }

                else
                {
                    student = new Student
                    {
                        FirstName = studentProps[0],
                        LastName = studentProps[1],
                        Age = int.Parse(studentProps[2]),
                        HomeTown = studentProps[3]
                    };
                    students.Add(student);
                }


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

        static Student indexOfStudent(List<Student> students, string v1, string v2)
        {
            foreach (var student in students)
            {
                if (student.FirstName == v1 && student.LastName == v2)
                {
                    return student;
                }
            }
            return null;
        }

        static Student studentExist(List<Student> students, string v1, string v2, int v3, string v4)
        {
            Student studentPresent = null;

            foreach (var student in students)
            {
                if (student.FirstName == v1 && student.LastName == v2)
                {
                    studentPresent = new Student()
                    {
                        FirstName = v1,
                        LastName = v2,
                        HomeTown = v4,
                        Age = v3
                    };

                    return studentPresent;
                }
            }

            return studentPresent;

        }

        static bool isMemberPresent(List<Student> students, string v1, string v2)
        {
            foreach (var student in students)
            {
                if (student.FirstName == v1 && student.LastName == v2)
                {
                    return true;
                }
            }
            return false;
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






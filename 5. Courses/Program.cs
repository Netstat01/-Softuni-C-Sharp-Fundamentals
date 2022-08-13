using System;
using System.Collections.Generic;

namespace _5._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> informationCources = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] info = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = info[0];
                string studentName = info[1];

                if (!informationCources.ContainsKey(courseName))
                {
                    informationCources.Add(courseName,new List<string>());
                }
                informationCources[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            foreach (var item in informationCources)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var names in item.Value)
                {
                    Console.WriteLine($"-- {names}");
                }
            }

        }
    }
}

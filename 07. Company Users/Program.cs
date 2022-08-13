using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployee = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] information = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = information[0];
                string employeeId = information[1];

                if (!companyEmployee.ContainsKey(companyName))
                {
                    companyEmployee.Add(companyName,new List<string>(){employeeId});
                }
                else if(!companyEmployee[companyName].Contains(employeeId))
                {
                    companyEmployee[companyName].Add(employeeId);
                }
                command = Console.ReadLine();
            }

            foreach (var item in companyEmployee)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> usersNumbers = new Dictionary<string, string>();

            for (int i = 0; i < countCommands; i++)
            {
                string[] commandInformation = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = commandInformation[1];
                string subCommand = commandInformation[0];                                          

                switch (subCommand)
                {
                    case "register":
                        string regNum = commandInformation[2];
                        RegisterUser(usersNumbers, name, regNum);
                        break;
                    case "unregister":
                        UnRegisterUser(usersNumbers, name);
                        break;                    
                }
            }
            PrintDictionary(usersNumbers);
        }

        private static void PrintDictionary(Dictionary<string, string> usersNumbers)
        {
            foreach (KeyValuePair<string, string> keyValuePair in usersNumbers)
            {
                Console.WriteLine($"{keyValuePair.Key} => {keyValuePair.Value}");
            }
        }
        private static void UnRegisterUser(Dictionary<string, string> usersNumbers, string name)
        {
            if (usersNumbers.ContainsKey(name))
            {
                usersNumbers.Remove(name);
                Console.WriteLine($"{name} unregistered successfully");
                return;
            }
            Console.WriteLine($"ERROR: user {name} not found");
        }

        private static void RegisterUser(Dictionary<string, string> usersNumbers, string name, string regNum)
        {

            if (usersNumbers.ContainsKey(name))
            {                
                Console.WriteLine($"ERROR: already registered with plate number {usersNumbers[name]}");
            }            
            else 
            {                
                usersNumbers.Add(name,regNum);
                Console.WriteLine($"{name} registered {usersNumbers[name]} successfully");
            }
        }
    }
}

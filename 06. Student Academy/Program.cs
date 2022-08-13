using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studenInformation = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string studenName = Console.ReadLine();
                double studenGrade = double.Parse(Console.ReadLine());

                if (!studenInformation.ContainsKey(studenName))
                {
                    //studenInformation.Add(studenName, new List<double>());
                    studenInformation[studenName] = new List<double>() { studenGrade};
                }
                else
                {
                    studenInformation[studenName].Add(studenGrade);
                }
            }

            foreach (var item in studenInformation)
            {
                if (item.Value.Average() >= 4.5 )
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}

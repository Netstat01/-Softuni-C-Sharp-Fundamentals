using System;
using System.Linq;

namespace Problem_1___SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberStudents = new int[3];           

            for (int i = 0; i < 3; i++)
            {
                numberStudents[i] = int.Parse(Console.ReadLine());
            }
            int allStudent = int.Parse(Console.ReadLine());

            double timeRestNeed = Math.Floor(((double)allStudent / (numberStudents.Sum() * 3)));

            double timeAnswering = Math.Ceiling((double)allStudent / numberStudents.Sum());

            Console.WriteLine($"Time needed: {timeAnswering + timeRestNeed}h.");
        }
    }
}

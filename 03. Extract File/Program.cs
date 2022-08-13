using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\",StringSplitOptions.RemoveEmptyEntries);

            string[] fileName = path[path.Length - 1].Split(".", StringSplitOptions.RemoveEmptyEntries);

            string name = fileName[0];
            string extencion = fileName[1];            

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extencion}");
        }
    }
}

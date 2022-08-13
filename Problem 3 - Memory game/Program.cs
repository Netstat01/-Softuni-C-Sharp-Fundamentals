using System;
using System.Collections.Generic;

namespace Problem_3___Memory_game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = new List<string>(Console.ReadLine().Split(" "));

            int turns = 0;

            while (true)
            {                
                string exit = Console.ReadLine();                

                if (exit == "end")
                {
                    break;
                }

                turns += 1;
                List<string> sequence = new List<string>(exit.Split(" ",StringSplitOptions.RemoveEmptyEntries));

                if (sequence[0] == sequence[1] || 
                    (int.Parse(sequence[0]) > input.Count -1 || int.Parse(sequence[0]) < 0) ||
                    (int.Parse(sequence[1]) > input.Count - 1 || int.Parse(sequence[1]) < 0))
                {
                    int indexToInsert = input.Count / 2;
                    string[] prp = new string[] {$"-{turns}a",$"-{turns}a"};
                    input.InsertRange(indexToInsert,prp);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (input[int.Parse(sequence[0])] == input[int.Parse(sequence[1])])
                    {
                        string temp = input[int.Parse(sequence[0])];
                        Console.WriteLine($"Congrats! You have found matching elements - {temp}!");
                        input.RemoveAll(x => x == temp);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                    if (input.Count <= 1)
                    {
                        Console.WriteLine($"You have won in {turns} turns!");
                        break;
                    }
                }
            }
            if (input.Count > 1)
            {
                Console.WriteLine($"Sorry you lose :( \n{string.Join(" ",input)}");
            }
        }
    }
}

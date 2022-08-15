using System;

namespace SoftUni_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	0 - 2 – baby
            //•	3 - 13 – child
            //•	14 - 19 – teenager
            //•	20 - 65 – adult
            //•	>= 66 – elder
            //•	All the values are inclusive.

            int input = int.Parse(Console.ReadLine());

            if (input <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (input >= 3 && input <= 13)
            {
                Console.WriteLine("child");
            }
            else if (input >= 14 && input <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (input >= 20 && input <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (input >= 65)
            {
                Console.WriteLine("elder");
            }         
            
        }
    }
}

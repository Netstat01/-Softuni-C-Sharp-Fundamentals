using System;
using System.Text;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string big_Number = Console.ReadLine();
            int singleNumber = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            if (singleNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = big_Number.Length -1; i >= 0; i--)
            {
                char lastNUm = big_Number[i];
                int lastNUmDigit = int.Parse(lastNUm.ToString());

                int result = lastNUmDigit * singleNumber + remainder;                

                sb.Append(result%10);

                remainder = result / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }
                     
            Console.WriteLine(stringRevers(sb));     
            
                      
        }

        public static string stringRevers(StringBuilder sb)
        {
            StringBuilder message = new StringBuilder();
            for (int i = sb.Length -1; i >= 0; i--)
            {
                message.Append(sb[i]);
            }
           return message.ToString();
        }
    }
}

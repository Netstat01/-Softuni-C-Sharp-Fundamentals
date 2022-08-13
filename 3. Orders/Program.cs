using System;
using System.Collections.Generic;

namespace _3._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productProp = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!productsPrice.ContainsKey(productProp[0]) && !productsQuantity.ContainsKey(productProp[0]))
                {
                    productsPrice.Add(productProp[0], double.Parse(productProp[1]));
                    productsQuantity.Add(productProp[0], int.Parse(productProp[2]));
                }
                else if( productsQuantity.ContainsKey(productProp[0]))
                {
                    if (productsPrice[productProp[0]] != double.Parse(productProp[1]))
                    {
                        productsPrice[productProp[0]] = double.Parse(productProp[1]);
                    }
                    productsQuantity[productProp[0]] += int.Parse(productProp[2]);
                }
                input = Console.ReadLine();
            }
            foreach (var item in productsPrice)
            {
                Console.WriteLine($"{item.Key} -> {(double)item.Value * productsQuantity[item.Key]:f2}");
            }
        }
    }
}

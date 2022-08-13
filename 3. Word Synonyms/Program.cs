using System;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> synonyms = new List<string>();
            Dictionary <string, List<string> >dictSynonims = new Dictionary<string,List<string>>();

            int count = int.Parse(Console.ReadLine());           

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string sinonym = Console.ReadLine();

                if (!dictSynonims.ContainsKey(word))
                {
                    dictSynonims.Add(word, new List<string>());
                }
                dictSynonims[word].Add(sinonym);            
            }

            foreach (var item in dictSynonims)
            {
                synonyms = item.Value;
                Console.WriteLine($"{item.Key} - {string.Join(", ",synonyms)}");
            }
        }
    }
}

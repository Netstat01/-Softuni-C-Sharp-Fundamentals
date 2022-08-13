using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int intCount = int.Parse(Console.ReadLine());
            List<Teams> listTeams = new List<Teams>();

            for (int i = 0; i < intCount; i++)
            {
                List<string> listTeam = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (teamCreated(listTeams, listTeam))
                {                  
                    listTeams.Add(new Teams {Team = listTeam[1], Creator = new Creator { Kreator = listTeam[0]}});                                                                                                
                                                
                    Console.WriteLine($"Team {listTeam[1]} has been created by {listTeam[0]}!");
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of assignment")
                {
                    break;
                }

                List<string> listTeam = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (ifTeamExistAndUserNotExist(listTeams, listTeam))
                {
                    for (int i = 0; i <= listTeams.Count - 1; i++)
                    {
                        if (listTeams[i].Team == listTeam[1])
                        {
                            listTeams[i].Creator.Members.Add(listTeam[0]);

                        }
                    }
                }
            }


            List<Teams> disband = new List<Teams>();
            List<Teams> validTeams = new List<Teams>();
            foreach (var item in listTeams)
            {
                if (item.Creator.Kreator != "" && item.Creator.Members.Count == 0)
                {
                    disband.Add(item);
                }
                else
                {
                    validTeams.Add(item);
                }
            }

            disband.Sort();
            List<Teams> otuput = new List<Teams>(validTeams.OrderByDescending(x=>x.Team));

            foreach (var item in otuput)
            {
                Console.WriteLine(item.Team);
                Console.WriteLine($"- {item.Creator.Kreator}");
                foreach (var item1 in item.Creator.Members)
                {
                    Console.WriteLine($"-- {item1}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in disband)
            {
                Console.WriteLine(item.Team);
            }
           
        }
        private static bool teamCreated(List<Teams> listTeams, List<string> listTeam)
        {
            foreach (var item in listTeams)
            {
                if (item.Team == listTeam[1])
                {
                    Console.WriteLine($"Team {listTeam[1]} was already created!");
                    return false;
                }
                else if (item.Creator.Kreator == listTeam[0])
                {
                    Console.WriteLine($"{listTeam[0]} cannot create another team!");

                    return false;
                }
            }
            return true;
        }
        private static bool ifTeamExistAndUserNotExist(List<Teams> listTeams, List<string> listTeam)
        {
            foreach (var item in listTeams)
            {
                if (item.Creator.Members.Count != 0 || item.Creator.Kreator != "")
                {
                    if (item.Creator.Kreator != "")
                    {
                        if (item.Creator.Kreator == listTeam[0])
                        {
                            Console.WriteLine($"Member {listTeam[0]} cannot join team {listTeam[1]}!");
                            return false;
                        }
                        
                    }
                    foreach (var items in item.Creator.Members)
                    {
                        if (items == listTeam[0] && item.Team == listTeam[1])
                        {
                            Console.WriteLine($"Member {listTeam[0]} cannot join team {listTeam[1]}!");

                            return false;
                        }
                    }
                }

                if (item.Team == listTeam[1])
                {
                    return true;
                }
            }
            Console.WriteLine($"Team {listTeam[1]} does not exist!");
            return false;
        }
    }

    class Teams
    {
        public Creator Creator { get; set; } = new Creator();
        public string Team { get; set; }
    }
    class Creator
    {
        public string Kreator { get; set; }
        public List<string> Members { get; set; } = new List<string>();
    }
}

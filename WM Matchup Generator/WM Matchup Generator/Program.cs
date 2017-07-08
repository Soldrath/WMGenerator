using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM_Matchup_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Scenario scenario = new Scenario();

            string selectedTier = TierSelect();

            Casters casters = new Casters(selectedTier);

            Console.WriteLine();
            Terrain terrain = new Terrain();
            Console.WriteLine();
            Console.WriteLine("The chosen scenario is {0}", scenario.ScenarioSelect());
            Console.WriteLine();            
        }

        public static string TierSelect()
        {
            Random roller = new Random();

            Console.WriteLine("Select Game Tier (1-4), 1 being best or ENTER for Random");
            string tier = Console.ReadLine();

            if (tier == "")
            {
                int random = roller.Next(1, 5);

                switch (random)
                {
                    case 1:
                        tier = "1";
                        break;
                    case 2:
                        tier = "2";
                        break;
                    case 3:
                        tier = "3";
                        break;
                    case 4:
                        tier = "4";
                        break;
                }

                Console.WriteLine("Selected Tier is {0}", tier);
            }

            return tier;
        }
    }
}

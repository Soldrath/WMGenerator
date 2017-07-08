using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM_Matchup_Generator
{
    public class Circle
    {
        Random roller = new Random();

        public string SelectedCaster { get; private set; }

        string[] circleTier1 = new string[] { "Tanith", "Wurmwood", "Una2" };
        string[] circleTier2 = new string[] { "Baldur2", "Kaya2", "Kromac2", "Kaya3" };
        string[] circleTier3 = new string[] { "Baldur1", "Bradigus", "Kaya1", "Krueger2" };
        string[] circleTier4 = new string[] { "Grayle", "Krueger1", "Kromac1","Mohsar","Morvahna1","Morvahna2" };

        public Circle()
        {
            SelectedCaster = AnyCaster();
        }

        public Circle(string tier)
        {
            switch (tier)
            {
                case "1":
                    SelectedCaster = Tier1Caster();
                    break;

                case "2":
                    SelectedCaster = Tier2Caster();
                    break;

                case "3":
                    SelectedCaster = Tier3Caster();
                    break;

                case "4":
                    SelectedCaster = Tier4Caster();
                    break;

                default:
                    SelectedCaster = AnyCaster();
                    break;
            }
        }

        public string Tier1Caster()
        {
            int roll = roller.Next(0, 3);
            string selection = circleTier1[roll];

            return selection;
        }

        public string Tier2Caster()
        {
            int roll = roller.Next(0, 4);
            string selection = circleTier2[roll];

            return selection;
        }

        public string Tier3Caster()
        {
            int roll = roller.Next(0, 4);
            string selection = circleTier3[roll];

            return selection;
        }

        public string Tier4Caster()
        {
            int roll = roller.Next(0, 6);
            string selection = circleTier4[roll];

            return selection;
        }

        public string AnyCaster()
        {
            int roll = roller.Next(1, 5);
            string caster = null;

            switch (roll)
            {
                case 1:
                    caster = Tier1Caster();
                    break;

                case 2:
                    caster = Tier2Caster();
                    break;

                case 3:
                    caster = Tier3Caster();
                    break;

                case 4:
                    caster = Tier4Caster();
                    break;
            }

            return caster;
        }
    }
}

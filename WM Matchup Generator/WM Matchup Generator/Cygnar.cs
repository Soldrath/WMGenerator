using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM_Matchup_Generator
{
    public class Cygnar
    {
        Random roller = new Random();

        public string SelectedCaster { get; private set; }

        string[] cygnarTier1 = new string[] { "Haley2", "Haley3", "Nemo3" };
        string[] cygnarTier2 = new string[] { "Caine2", "Caine3", "Kara Sloan", "Haley1", "Stryker1", "Stryker2", "Maddox" };
        string[] cygnarTier3 = new string[] { "Jakes2", "Darius", "Kraye", "Nemo1", "Nemo2", "Caine1", "Stryker3", "Siege" };
        string[] cygnarTier4 = new string[] { "Constance Blaize", "Sturgis1"};

        public Cygnar()
        {
            SelectedCaster = AnyCaster();
        }

        public Cygnar(string tier)
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
            string selection = cygnarTier1[roll];

            return selection;
        }

        public string Tier2Caster()
        {
            int roll = roller.Next(0, 7);
            string selection = cygnarTier2[roll];

            return selection;
        }

        public string Tier3Caster()
        {
            int roll = roller.Next(0, 8);
            string selection = cygnarTier3[roll];

            return selection;
        }

        public string Tier4Caster()
        {
            int roll = roller.Next(0, 2);
            string selection = cygnarTier4[roll];

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

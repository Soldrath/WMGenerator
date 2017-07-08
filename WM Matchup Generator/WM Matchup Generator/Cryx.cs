using System;

namespace WM_Matchup_Generator
{
    public class Cryx
    { 
        Random roller = new Random();

        public string SelectedCaster { get; private set; }

        string[] cryxTier1 = new string[] { "Deneghra1", "Skarre1", "Witch Coven" };
        string[] cryxTier2 = new string[] { "Asphyxious3", "Skarre2", "Goreshade3" };
        string[] cryxTier3 = new string[] { "Venethrax", "Asphyxious1", "Terminus", "Goreshade2", "Scaverous", "Agathea", "Aiakos2", "Deneghra3", "Mortenebra2" };
        string[] cryxTier4 = new string[] { "Sturgis2", "Asphyxious2", "Goreshade1", "Deneghra2", "Mortenebra1" };

        public Cryx()
        {
            SelectedCaster = AnyCaster();
        }

        public Cryx(string tier)
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
            string selection = cryxTier1[roll];

            return selection;
        }

        public string Tier2Caster()
        {
            int roll = roller.Next(0, 3);
            string selection = cryxTier2[roll];

            return selection;
        }

        public string Tier3Caster()
        {
            int roll = roller.Next(0, 9);
            string selection = cryxTier3[roll];

            return selection;
        }

        public string Tier4Caster()
        {
            int roll = roller.Next(0, 5);
            string selection = cryxTier4[roll];

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

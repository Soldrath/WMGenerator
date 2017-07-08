using System;

namespace WM_Matchup_Generator
{
    public class Trollbloods
    {
        Random roller = new Random();

        public string SelectedCaster { get; private set; }

        string[] trollbloodsTier1 = new string[] { "Madrak2", "Calandra", "Doomshaper2" };
        string[] trollbloodsTier2 = new string[] { "Horgle2", "Doomshaper1", "Doomshaper3", "Grim2", "Ragnor", "Gunnbjorn" };
        string[] trollbloodsTier3 = new string[] { "Borka1", "Grissel2", "Grim1", "Madrak3" };
        string[] trollbloodsTier4 = new string[] { "Jarl", "Madrak1", "Grissel1", "Borka2" };

        public Trollbloods()
        {
            SelectedCaster = AnyCaster();
        }

        public Trollbloods(string tier)
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
            string selection = trollbloodsTier1[roll];

            return selection;
        }

        public string Tier2Caster()
        {
            int roll = roller.Next(0, 6);
            string selection = trollbloodsTier2[roll];

            return selection;
        }

        public string Tier3Caster()
        {
            int roll = roller.Next(0, 4);
            string selection = trollbloodsTier3[roll];

            return selection;
        }

        public string Tier4Caster()
        {
            int roll = roller.Next(0, 4);
            string selection = trollbloodsTier4[roll];

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

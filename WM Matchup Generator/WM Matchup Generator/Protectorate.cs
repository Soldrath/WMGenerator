using System;

namespace WM_Matchup_Generator
{
    public class Protectorate
    {
        Random roller = new Random();

        public string SelectedCaster { get; private set; }

        string[] protectorateTier1 = new string[] { "Amon","Severius2","High Reclaimer" };
        string[] protectorateTier2 = new string[] { "Durst", "Severius1", "Feora3", "Reznik2", "Kreoss1","Thyra" };
        string[] protectorateTier3 = new string[] { "Reznik1", "Testament","Durant2", "Kreoss3", "Vindictus", "Malekus"};
        string[] protectorateTier4 = new string[] { "Kreoss2","Feora1","Feora2", "Harbinger"};

        public Protectorate()
        {
            SelectedCaster = AnyCaster();
        }

        public Protectorate(string tier)
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
            string selection = protectorateTier1[roll];

            return selection;
        }

        public string Tier2Caster()
        {
            int roll = roller.Next(0, 6);
            string selection = protectorateTier2[roll];

            return selection;
        }

        public string Tier3Caster()
        {
            int roll = roller.Next(0, 6);
            string selection = protectorateTier3[roll];

            return selection;
        }

        public string Tier4Caster()
        {
            int roll = roller.Next(0, 4);
            string selection = protectorateTier4[roll];

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

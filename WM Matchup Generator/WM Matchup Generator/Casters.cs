using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM_Matchup_Generator
{
    class Casters
    {
        Random roller = new Random();

        #region Properties
        public string CasterTier { get; private set; }
        public string Player1Faction { get; private set; }
        public string Player2Faction { get; private set; }
        public string Player1Caster { get; private set; }
        public string Player2Caster { get; private set; }
        #endregion

        public Casters(string tier)
        {
            this.CasterTier = tier;
            Player1Select();
            Player2Select();

            Console.WriteLine("Game Tier: {0}",CasterTier);
            Console.WriteLine("Player 1 Faction: {0}  ***  Player 1 Caster: {1}", Player1Faction, Player1Caster);
            Console.WriteLine("Player 2 Faction: {0}  ***  Player 2 Caster: {1}", Player2Faction, Player2Caster);
        }

        public void Player1Select()
        {
            Console.WriteLine("Select Player 1 Faction:");
            Console.WriteLine("1. Protectorate, 2. Cryx, 3. Trollbloods, 4. Random");
            string player1Select = Console.ReadLine();

            switch (player1Select)
            {
                case "1":
                    Player1Faction = "Protectorate";
                    Protectorate protectorate = new Protectorate(CasterTier);
                    Player1Caster = protectorate.SelectedCaster;
                    Console.WriteLine("Selected Caster is {0}", protectorate.SelectedCaster);
                    break;

                case "2":
                    Player1Faction = "Cryx";
                    Cryx cryx = new Cryx(CasterTier);
                    Player1Caster = cryx.SelectedCaster;
                    Console.WriteLine("Selected Caster is {0}", cryx.SelectedCaster);
                    break;

                case "3":
                    Player1Faction = "Trollbloods";
                    Trollbloods trollbloods = new Trollbloods(CasterTier);
                    Player1Caster = trollbloods.SelectedCaster;
                    Console.WriteLine("Selected Caster is {0}", trollbloods.SelectedCaster);
                    break;

                case "4":
                    Player1Faction = RandomPlayer1Faction();
                    if (Player1Faction == "Protectorate")
                    {
                        goto case "1";
                    }
                    else if (Player1Faction == "Cryx")
                    {
                        goto case "2";
                    }
                    else
                    {
                        goto case "3";
                    }

                default:
                    Player1Select();
                    break;
            }

            Console.WriteLine();
        }

        public void Player2Select()
        {           
            Console.WriteLine("Select Player2 Faction:");
            Console.WriteLine("1. Cygnar, 2. Circle, 3. Khador, 4. Random");
            string player2Select = Console.ReadLine();

            switch (player2Select)
            {
                case "1":
                    Player2Faction = "Cygnar";
                    Cygnar cygnar = new Cygnar(CasterTier);
                    Player2Caster = cygnar.SelectedCaster;
                    Console.WriteLine("Selected Caster is {0}", cygnar.SelectedCaster);
                    break;

                case "2":
                    Player2Faction = "Circle";
                    Circle circle = new Circle(CasterTier);
                    Player2Caster = circle.SelectedCaster;
                    Console.WriteLine("Selected Caster is {0}", circle.SelectedCaster);
                    break;

                case "3":
                    //No Khador yet
                    //Player2Faction = "Khador";
                    int selection = roller.Next(1, 3);
                    if (selection == 1)
                    {
                        goto case "1";
                    }
                    else
                    {
                        goto case "2";
                    }

                case "4":
                    Player2Faction = RandomPlayer2Faction();
                    if (Player2Faction == "Cygnar")
                    {
                        goto case "1";
                    }
                    else if (Player2Faction == "Circle")
                    {
                        goto case "2";
                    }
                    else
                    {
                        goto case "3";
                    }

                default:
                    Player2Select();
                    break;
            }

            Console.WriteLine();
        }

        public string RandomPlayer1Faction()
        {
            int random = roller.Next(0, 3);

            string[] faction = new string[] { "Protectorate", "Cryx", "Trollbloods" };

            return faction[random];
        }

        public string RandomPlayer2Faction()
        {
            int random = roller.Next(0, 3);

            string[] faction = new string[] { "Cygnar", "Circle", "Khador" };

            return faction[random];
        }
    }
}

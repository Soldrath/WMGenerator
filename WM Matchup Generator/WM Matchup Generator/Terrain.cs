using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM_Matchup_Generator
{
    public class Terrain
    {
        Random roller = new Random();

        #region Variables
        //maximum limits for each terrain type
        private int terrainMax = 8;
        private int forestMax = 2;
        private int houseMax = 1;
        private int rubbleMax = 2;
        private int trenchMax = 2;
        private int wallMax = 3;
        private int hillMax = 2;
        private int waterMax = 1;

        //counters for current terrain types
        private int terrainCount;
        private int forestCount;
        private int houseCount;
        private int rubbleCount;
        private int trenchCount;
        private int wallCount;
        private int hillCount;
        private int waterCount;
        #endregion

        public Terrain()
        {
            GenerateTerrain();
        }

        #region Methods
        public void GenerateTerrain()
        {
            while (terrainCount < terrainMax)
            {
                RollTerrain();
            }
        }

        public void RollTerrain()
        {
            int terrainRoll;

            terrainRoll = roller.Next(1, 8);

            switch (terrainRoll)
            {
                case 1:
                    if (forestCount >= forestMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        forestCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is a forest deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], RollOrientation());
                    }                
                    break;

                case 2:
                    if (houseCount >= houseMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        houseCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is a house deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], RollOrientation());
                    }
                    break;

                case 3:
                    if (rubbleCount >= rubbleMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        rubbleCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is a rubble deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], RollOrientation());
                    }
                    break;

                case 4:
                    if (trenchCount >= trenchMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        trenchCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is a trench deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], RollOrientation());
                    }
                    break;

                case 5:
                    if (wallCount >= wallMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        wallCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is a wall deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], WallOrientation());
                    }
                    break;

                case 6:
                    if (hillCount >= hillMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        hillCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is a hill deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], RollOrientation());
                    }
                    break;

                case 7:
                    if (waterCount >= waterMax)
                    {
                        RollTerrain();
                    }
                    else
                    {
                        waterCount++;
                        terrainCount++;
                        int[] deviation = RollDeviation();
                        Console.WriteLine("Terrain {0} is water deviating {1} to the {2} and oriented at {3}", terrainCount, deviation[0], deviation[1], RollOrientation());
                    }
                    break;
            }
        }

        public int[] RollDeviation()
        {
            int[] deviation = new int[2];

            //distance
            deviation[0] = roller.Next(1, 7);

            //direction
            deviation[1] = roller.Next(1, 7);

            return deviation;
        }

        public int RollOrientation() //need to handle cases with wall orienting at 1 or 4
        {
            int orientation = roller.Next(1, 7);

            return orientation;
        }

        public int WallOrientation()
        {
            int[] validOrientations = new int[4] {2,3,5,6};
            int orientationIndex = roller.Next(0, 4);
            int orientation = validOrientations[orientationIndex];

            return orientation;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM_Matchup_Generator
{
    public class Scenario
    {
        Random roller = new Random();

        public string ScenarioSelect()
        {
            string[] scenarios = new string[] { "Entrenched", "Line Breaker", "Take And Hold (Killbox)", "The Pit (Killbox)", "Extraction (Killbox)", "Incursion", "Outlast", "Recon" };

            int scenarioRoll = roller.Next(0, 8);

            return scenarios[scenarioRoll];
        }
    }
}

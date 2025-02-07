using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaaa
{
    internal class Agent
    {
        private string name;
        private string country;
        private int dangerLevel;
        private int winningChance;

        public Agent(string name, string country, int dangerLevel, int winningChance)
        {
            this.name = name;
            this.country = country;
            this.dangerLevel = dangerLevel;
            this.winningChance = winningChance;
        }

        public Agent(string name, string country)
        {
            this.name = name;
            this.country = country;
            this.dangerLevel = 5;
            this.winningChance = 50;
        }

        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public int DangerLevel { get => dangerLevel; set => dangerLevel = value; }
        public int WinningChance { get => winningChance; set => winningChance = value; }

        public string start()
        {
            return "a küldetés elkezdődött";
        }

        public int dangerinc(int increase)
        {
            return dangerLevel + increase;
        }

        public int winninginc(int increase2)
        {
            return winningChance + increase2;
        }

        public override string ToString()
        {
            return $"{name} - {country} / {dangerLevel} / {winningChance}";
        }
    }
}

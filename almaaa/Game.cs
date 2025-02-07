using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaaa
{
    internal class Game
    {
        Random random = new Random();
        private string name;
        private int level;
        private int health;
        private int power;

        public Game(string name, int level, int health, int power)
        {
            this.name = name;
            this.level = level;
            this.health = health;
            this.power = power;
        }

        public Game(string name, int power = 0)
        {
            this.name = name;
            this.level = 1;
            this.health = 100;
            this.power = power;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Health { get => health; set => health = value; }
        public int Power { get => power; set => power = value; }

        public string attack()
        {
            return $"támadás ereje: {power}";
        }

        public int heal(int heel)
        {
            return health + heel;
        }

        public int levelup()
        {
            return level + 1 & power + random.Next(10);
        }

        public override string ToString()
        {
            return $"{name} - {level} - {health}";
        }
    }
}

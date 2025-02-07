using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaaa
{
    internal class SpaceShip
    {
        private string name;
        private int speed;
        private int capacity;
        private int fuelLevel;

        public SpaceShip(string name, int speed, int capacity, int fuelLevel)
        {
            this.name = name;
            this.speed = speed;
            this.capacity = capacity;
            this.fuelLevel = fuelLevel;
        }

        public SpaceShip(string name, int capacity)
        {
            this.name = name;
            this.speed = 0;
            this.capacity = capacity;
            this.fuelLevel = 100;
        }

        public string Name { get => name; set => name = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int FuelLevel { get => fuelLevel; set => fuelLevel = value; }


        public int start()
        {
            return speed + 55 & fuelLevel - 13;
        }

        public int fueling(int amount)
        {
            return fuelLevel + amount;
        }

        public int land()
        {
            this.speed = 0;
            return speed;
        }

        public override string ToString()
        {
            return $"{name} - {speed} / {capacity} / {fuelLevel}";
        }

    }
}

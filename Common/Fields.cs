using System;

namespace Common
{
    public class Fields
    {
        private string name, faction;
        private int health, level, abilityPoints;

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            } 
        }
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                this.abilityPoints = value;
            }
        }


        public Fields()
            :this("Megan", "Sub Human"){}

        public Fields(string name, string faction)
            : this("Michael", "Human", 100, 10, 20){}
        public Fields(string name, string faction, int health, int level, int abilityPoints) 
        {
            this.Name = name;
            this.Faction = faction;
            this.Health = health;
            this.Level = level;
            this.AbilityPoints = abilityPoints;
        }

        public void Character()
        {
            Console.WriteLine(
                $"--------Character------\n" +
                $"Character Name: {this.Name}\n" +
                $"Character Faction: {this.Faction}\n" +
                $"Character Health: {this.Health}\n" +
                $"Character Level: {this.Level}\n" +
                $"Character Ability Points {this.AbilityPoints}\n"+
                $"--------Character------\n");
        }
    }
}

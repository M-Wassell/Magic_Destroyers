using Enumerations;
using Interfaces;
using MagicDestroyers.Armours;
using MagicDestroyers.Weapons;
using MagicDestroyers.Weapons.Sharp;
using Melee;
using System;


namespace Common
{
    public abstract class Character : IAttack, IDefend
    {

        private Faction faction;
        private string name;
        private int level, age, healthPoints;
        private Weapon weapon;
        private Armour bodyArmour;

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
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >=1 || value <=101)
                {
                    this.healthPoints = value;
                }
                throw new ArgumentOutOfRangeException(string.Empty, "Health Points need to be between 1 - 100");

            }
        }

        public Faction Factions
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
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armour BodyArmour 
        {
            get
            { 
                return this.bodyArmour;
            }
            set
            {
                this.bodyArmour = value;
            } 
        }

        public void Greeting(string name)
        {
            Console.WriteLine($"Hi from: {name}");
        }

        protected void CharacterAttributes()
        {

            Console.WriteLine($"Name: {Name}\n" +
                $"Level: {Level}\n" +
                $"Age: {Age}\n" +
                $"Health: {HealthPoints}");
        }

        public abstract int Addition(int firstNum, int secondNum);


        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        
    }
}

using Enumerations;
using Interfaces;
using MagicDestroyers.Weapons.Sharp;
using Melee;
using System;

namespace Common
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private Sword weapon;
        private string name;
        private int level, age, healthPoints;

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
                return this.level;
            }
            set
            {
                if (value >=1 || value <=101)
                {
                    this.level = value;
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
        public Sword Sword
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


        public abstract void Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();
    }
}

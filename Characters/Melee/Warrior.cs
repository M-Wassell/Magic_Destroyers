
using Common;
using Enumerations;
using MagicDestroyers.Weapons.Sharp;

using System;
using System.Runtime.InteropServices;

namespace Melee
{
    public class Warrior : Melee
    {

        private readonly Sword DEFAULT_SWORD = new Sword();
        private const string DEFAULT_NAME = "Uther";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private static int idCounter;
        private readonly int id;

        public int ID 
        {
            get 
            {
                return this.id;
            }  
        }

        public static int IdCount
        {
            get
            {
                return Warrior.idCounter;
            }
            set
            {
                Warrior.idCounter = value;
            }
        }

        public Warrior()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
                
        }
        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS) { }

        public Warrior(string name, int level, int healthPoints)
        {
            IdCount++;
            this.id = idCounter;
            base.Factions = Faction.Melee;
            base.Weapon = DEFAULT_SWORD;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Name = name;
        }




        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Warrior sum = {sum}");
            return sum;
        }

        public int Strike()
        {
            return base.Weapon.WeaponDamage + 10;
        }

        public int Execute()
        {
            return base.Weapon.WeaponDamage + 10;
        }
        public int SkinHarden()// Armour class required
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}

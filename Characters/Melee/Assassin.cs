using MagicDestroyers.Weapons;
using Enumerations;
using System;
using MagicDestroyers.Weapons.Sharp;

namespace Melee
{
    public class Assassin : Melee
    {
        

        private readonly Weapon DEFAULT_SWORD_WEAPON = new Sword();
        private const string DEFAULT_NAME = "Uther";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private Sword swordWeapon;


        public Sword SwordWeapons
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        public Assassin()
            :this(DEFAULT_NAME, DEFAULT_LEVEL) {}
        public Assassin(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS) {}
        public Assassin(string name, int level, int healthPoints)
        {
            base.Factions = Faction.Melee;
            base.Weapon = DEFAULT_SWORD_WEAPON;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Name = name;

        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        public int Raze()
        {
            return base.Weapon.WeaponDamage + 10;
        }
        public int BleedToDeath()
        {
            return base.Weapon.WeaponDamage + 10;
        }
        public int Survival()
        {
            throw new NotImplementedException(); // needs armour class
        }

        public override int Attack()
        {
            throw new System.NotImplementedException();
        }

        public override int SpecialAttack()
        {
            throw new System.NotImplementedException();
        }

        public override int Defend()
        {
            throw new System.NotImplementedException();
        }
    }
}

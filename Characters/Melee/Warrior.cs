using Common;
using Sharp;
using System;

namespace Melee
{
    public class Warrior
    {
        private int strikeDamageOffensive, skinHardenDefensive, executionerDamageOffensive;
        private Sword swordWeapon;
        private Fields genericFields;

        public int StrikeDamageOffensive
        {
            get
            {
                return strikeDamageOffensive;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    strikeDamageOffensive = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Strike Damage too powerful");
                }

            }
        }
        public int ExecutionerDamageOffensive
        {
            get
            {
                return this.executionerDamageOffensive;
            }
            set
            {
                this.executionerDamageOffensive = value;
            }
        }
        public int SkinHardenDefensive
        {
            get
            {
                return this.skinHardenDefensive;
            }
            set
            {
                this.skinHardenDefensive = value;
            }
        }
        public Fields GenericFields
        {
            get
            {
                return this.genericFields;
            }
            set
            {
                this.genericFields = value;
            }
        }
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

        public Warrior()
            :this(10, 50){}

        public Warrior(int strikeDamageOffensive, int skinHardenDefensive)
            :this("Jamie", "Sub Human", 5000, "The Brown", 1000, 50, 80){}
        public Warrior(string name, string faction, int damage, string swordName, int health, int level, int abilityPoints)
        {
            this.SwordWeapons = new Sword(swordName, damage);
            this.GenericFields = new Fields(name, faction, health, level, abilityPoints);
            this.StrikeDamageOffensive = strikeDamageOffensive;
            this.ExecutionerDamageOffensive = executionerDamageOffensive;
            this.SkinHardenDefensive = skinHardenDefensive;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hi from: {this.GenericFields.Name}," +
                              $" My Faction is: {this.GenericFields.Faction}");
        }

        public void SwordDamage(string damage, int swordName)
        {
            Console.WriteLine($"{swordName} damage = {damage}");
        }

    }
}

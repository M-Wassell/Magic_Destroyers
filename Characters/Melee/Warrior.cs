using Common;
using Enumerations;
using Sharp;
using System;
using System.Runtime.ExceptionServices;

namespace Melee
{
    public class Warrior
    {
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private readonly Fields DEFAULT_FIELDS = new Fields();
        private const int DEFAULT_STRIKE_DAMAGE = 50;
        private const int DEFAULT_SKIN_HARDEN = 60;
        private const int DEFAULT_EXICUTIONER_DAMAGE = 70;

        private int strikeDamageOffensive, skinHardenDefensive, executionerDamageOffensive;
        private Sword swordWeapon;
        private Fields genericFields;
        private Faction faction;

        public Faction Faction 
        {
            get { return this.faction; }
            set { this.faction = value; }
        }
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
            :this(DEFAULT_STRIKE_DAMAGE, DEFAULT_SKIN_HARDEN, Faction.Default){}

        public Warrior(int strikeDamageOffensive, int skinHardenDefensive, Faction faction)
            : this("Jamie", Faction.Default, 5000, "The Brown", 1000, 50, 80)
        {
            Faction = faction;
        }
        public Warrior(string name, Faction faction, int damage, string swordName, int health, int level, int abilityPoints)
        {
            this.SwordWeapons = new Sword(swordName, damage);
            this.GenericFields = new Fields();
            this.StrikeDamageOffensive = DEFAULT_STRIKE_DAMAGE;
            this.ExecutionerDamageOffensive = DEFAULT_EXICUTIONER_DAMAGE;
            this.SkinHardenDefensive = DEFAULT_SKIN_HARDEN;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hi from: {this.GenericFields.Name}," +
                              $" My Faction is: {Faction.Melee}");
        }

        public void SwordDamage(string damage, int swordName)
        {
            Console.WriteLine($"{swordName} damage = {damage}");
        }

    }
}

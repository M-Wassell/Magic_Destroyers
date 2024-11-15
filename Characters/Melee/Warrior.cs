
using Common;
using Enumerations;


using Sharp;
using System;

namespace Melee
{
    public class Warrior : Melee
    {
        
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        private const int DEFAULT_STRIKE_DAMAGE = 50;
        private const int DEFAULT_SKIN_HARDEN = 60;
        private const int DEFAULT_EXICUTIONER_DAMAGE = 70;

        private int strikeDamageOffensive, skinHardenDefensive, executionerDamageOffensive;
        private Sword swordWeapon;
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
        public Warrior(string name, int level, int age, int health)
                :base(name, level, age, health)
        {

        }
        public Warrior()
            : this(Faction.Melee) { }

        public Warrior(Faction faction)
        {
            base.Health = Health;
            this.SwordWeapons = DEFAULT_SWORD_WEAPON;
            this.StrikeDamageOffensive = DEFAULT_STRIKE_DAMAGE;
            this.ExecutionerDamageOffensive = DEFAULT_EXICUTIONER_DAMAGE;
            this.SkinHardenDefensive = DEFAULT_SKIN_HARDEN;
        }

        public void SwordDamage(string damage)
        {
            Console.WriteLine($"damage = {damage}");
        }

        public virtual void WarriorAttributes()
        {
            Console.WriteLine($"I am a mighty Warrior");
            base.CharacterAttributes();
        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Warrior sum = {sum}");
            return sum;
        }

    }
}

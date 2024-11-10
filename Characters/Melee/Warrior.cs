
using Enumerations;
//using MagicDestroyers.Enumerations;
using Sharp;
using System;


namespace Melee
{
    public class Warrior
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        //private readonly EnumSwordName DEFAULT_SWORD_NAME = EnumSwordName.Slasher;
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        //private readonly Fields DEFAULT_FIELDS = new Fields();
        private const int DEFAULT_STRIKE_DAMAGE = 50;
        private const int DEFAULT_SKIN_HARDEN = 60;
        private const int DEFAULT_EXICUTIONER_DAMAGE = 70;
        private const string DEFAULT_NAME = "Warrior 1";

        private int strikeDamageOffensive, skinHardenDefensive, executionerDamageOffensive;
        private string name;
        private Sword swordWeapon;
       // private EnumSwordName swordName;
        //private Fields genericFields;
        private Faction faction;
        private HitPoints hitPoints;


        public HitPoints HitPoints
        {
            get { return this.hitPoints; }
            set { this.hitPoints = value; }
        }
        //public EnumSwordName SwordName
        //{
        //    get
        //    {
        //        return this.swordName;
        //    }

        //    set
        //    {
        //        this.swordName = value;
        //    }
        //}
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
        //public Fields GenericFields
        //{
        //    get
        //    {
        //        return this.genericFields;
        //    }
        //    set
        //    {
        //        this.genericFields = value;
        //    }
        //}
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
            :this(DEFAULT_NAME) {}

        public Warrior(string name)
            : this(DEFAULT_NAME, Faction.Melee)
        {

        }
        public Warrior(string name, Faction faction)
        {
            this.HitPoints = DEFAULT_HIT_POINTS;
            this.Name = DEFAULT_NAME;
            this.SwordWeapons = new Sword();
            //this.GenericFields = new Fields();
            this.StrikeDamageOffensive = DEFAULT_STRIKE_DAMAGE;
            this.ExecutionerDamageOffensive = DEFAULT_EXICUTIONER_DAMAGE;
            this.SkinHardenDefensive = DEFAULT_SKIN_HARDEN;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hi from: {DEFAULT_NAME}," +
                              $" My Faction is: {Faction.Melee}");
        }

        public void SwordDamage(string damage, int swordName)
        {
            Console.WriteLine($"{swordName} damage = {damage}");
        }

    }
}


using Enumerations;
using Sharp;
using System.Diagnostics.CodeAnalysis;

namespace Melee
{
    public class Assassin : Melee
    {
        
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private const int DEFAULT_RAZE = 50;
        private const int DEFAULT_BLEED_TO_DEATH = 60;
        private const int DEFAULT_SURVIVAL = 70;

        private int razeOffense, bleedToDeathOffense, survival;
        private Sword swordWeapon;
        private Faction faction;

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
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }
        public int RazeOffense 
        {
            get 
            { 
                return this.razeOffense;
            }

            set 
            { 
                this.razeOffense = value;
            } 
        }
        public int BleedToDeathOffense
        {
            get
            {
                return this.bleedToDeathOffense;
            }

            set
            {
                this.bleedToDeathOffense = value;
            }
        }
        public int Survival
        {
            get
            {
                return this.survival;
            }

            set
            {
                this.survival = value;
            }
        }

        public Assassin(string name, int level, int age, int health)
                : base(name, level, age, health) { }
        public Assassin()
            :this(DEFAULT_RAZE, DEFAULT_BLEED_TO_DEATH) {}
        public Assassin(int razeOffense, int bleedToDeathOffense)
            :this(DEFAULT_RAZE, DEFAULT_BLEED_TO_DEATH, DEFAULT_SURVIVAL) {}
        public Assassin(int razeOffense, int bleedToDeathOffense, int survival)
        {
            this.RazeOffense = DEFAULT_RAZE;
            this.BleedToDeathOffense = DEFAULT_BLEED_TO_DEATH;
            this.Survival = DEFAULT_SURVIVAL;
            this.SwordWeapons = DEFAULT_SWORD_WEAPON;
        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
    }
}

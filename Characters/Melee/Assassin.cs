
using Common;
using Enumerations;
using Sharp;

namespace Melee
{
    public class Assassin
    {
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private readonly Fields DEFAULT_FIELDS = new Fields();
        private const int DEFAULT_RAZE = 50;
        private const int DEFAULT_BLEED_TO_DEATH = 60;
        private const int DEFAULT_SURVIVAL = 70;

        private int razeOffense, bleedToDeathOffense, survival;
        private Sword swordWeapon;
        private Fields genericFields;
        private Faction faction;

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

        public Assassin()
            :this(DEFAULT_RAZE, DEFAULT_BLEED_TO_DEATH) {}
        public Assassin(int razeOffense, int bleedToDeathOffense)
            :this(DEFAULT_RAZE, DEFAULT_BLEED_TO_DEATH, DEFAULT_SURVIVAL) {}
        public Assassin(int razeOffense, int bleedToDeathOffense, int survival)
        {
            this.RazeOffense = DEFAULT_RAZE;
            this.BleedToDeathOffense = DEFAULT_BLEED_TO_DEATH;
            this.Survival = DEFAULT_SURVIVAL;
        }
    }
}



using Enumerations;
using Sharp;

namespace Melee
{
    public class Knight
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        //private readonly Fields DEFAULT_FIELDS = new Fields();
        private const int DEFAULT_HOLY_BLOW = 50;
        private const int DEFAULT_PURIFY_SOUL = 60;
        private const int DEFAULT_RIGHTEOUS_WINGS = 70;

        private int holyBlowOffense, purifySoulOffense, righteousWings;
        private Sword swordWeapon;
        private HitPoints hitPoints;
        //private Fields genericFields;
        private Faction faction;

        public HitPoints HitPoints
        {
            get { return this.hitPoints; }
            set { this.hitPoints = value; }
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
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }

        public int HolyBlowOffense 
        {
            get
            {
                return this.holyBlowOffense;
            }
            set
            {
                this.holyBlowOffense = value;
            } 
        }
        public int PurifySoulOffense
        {
            get
            {
                return this.purifySoulOffense;
            }
            set
            {
                this.purifySoulOffense = value;
            }
        }
        public int RighteousWings
        {
            get
            {
                return this.righteousWings;
            }
            set
            {
                this.righteousWings = value;
            }
        }

        public Knight()
            :this(DEFAULT_HOLY_BLOW) {}

        public Knight(int holyBlowOffense)
            :this(DEFAULT_HOLY_BLOW, DEFAULT_PURIFY_SOUL, DEFAULT_RIGHTEOUS_WINGS) {}

        public Knight(int holyBlowOffense, int purifySoulOffense, int righteousWings) 
        {
            this.HitPoints = DEFAULT_HIT_POINTS;
            this.HolyBlowOffense = DEFAULT_HOLY_BLOW;
            this.PurifySoulOffense = DEFAULT_PURIFY_SOUL;
            this.RighteousWings = DEFAULT_RIGHTEOUS_WINGS;
        }
    }
}

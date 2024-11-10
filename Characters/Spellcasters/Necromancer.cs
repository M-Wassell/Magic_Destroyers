
using Blunt;

using Enumerations;
using Sharp;

namespace Spellcasters
{
    internal class Necromancer
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Faction DEFAULT_FACTION = Faction.Spellcaster;
        private readonly MagicStaff DEFAULT_STAFF_WEAPON = new MagicStaff();
        //private readonly Fields DEFAULT_FIELDS = new Fields();
        private const int DEFAULT_SHADOW_RAGE = 50;
        private const int DEFAULT_VAMPIRE_TOUCH = 60;
        private const int DEFAULT_BONE_SHIELD = 70;

        private int shadowRageOffense, vampireTouchOffense, boneShieldDefense;
        private Faction faction;
        private HitPoints hitPoints;
        //private Fields genericFields;
        private MagicStaff magicStaffWeapon;


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
        public MagicStaff MagicStaffWeapon
        {
            get
            {
                return this.magicStaffWeapon;
            }
            set
            {
                this.magicStaffWeapon = value;
            }
        }
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }
        public int ShadowRageOffense
        {
            get
            {
                return this.shadowRageOffense;
            }
            set
            {
                this.shadowRageOffense = value;
            }
        }
        public int VampireTouchOffense
        {
            get
            {
                return this.vampireTouchOffense;
            }
            set
            {
                this.vampireTouchOffense = value;
            }
        }
        public int BoneShieldDefense
        {
            get
            {
                return this.boneShieldDefense;
            }
            set
            {
                this.boneShieldDefense = value;
            }
        }

        public Necromancer()
            :this(DEFAULT_SHADOW_RAGE) {}

        public Necromancer(int shadowRageOffense)
            :this(DEFAULT_SHADOW_RAGE, DEFAULT_VAMPIRE_TOUCH, DEFAULT_BONE_SHIELD) {}

        public Necromancer(int shadowRageOffense, int vampireTouchOffense, int boneShieldDefense) 
        {
            this.HitPoints = DEFAULT_HIT_POINTS;
            this.ShadowRageOffense = DEFAULT_SHADOW_RAGE;
            this.VampireTouchOffense = DEFAULT_VAMPIRE_TOUCH;
            this.BoneShieldDefense = DEFAULT_BONE_SHIELD;
        }
    }
}

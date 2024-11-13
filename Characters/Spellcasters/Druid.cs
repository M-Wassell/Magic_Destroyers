
using Blunt;

using Enumerations;
using System.Linq.Expressions;

namespace Spellcasters
{
    public class Druid :Spellcaster
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Faction DEFAULT_FACTION = Faction.Spellcaster;
        private readonly MagicStaff DEFAULT_STAFF_WEAPON = new MagicStaff();
        
        private const int DEFAULT_MOON_FIRE = 50;
        private const int DEFAULT_STARBURST = 60;
        private const int DEFAULT_ONE_WITH_NATURE = 70;

        private int moonfireOffensive, starburstOffensive, oneWithTheNatureOffensive;
        private Faction faction;
        private HitPoints hitPoints;
        private MagicStaff magicStaffWeapon;

        public HitPoints HitPoints
        {
            get { return this.hitPoints; }
            set { this.hitPoints = value; }
        }
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
        public int MoonfireOffensive 
        {
            get
            {
                return this.moonfireOffensive;
            }
            set
            {
                this.moonfireOffensive = value;
            } 
        }
        public int StarburstOffensive
        {
            get
            {
                return this.starburstOffensive;
            }
            set
            {
                this.starburstOffensive = value;
            }
        }
        public int OneWithTheNatureOffensive
        {
            get
            {
                return this.oneWithTheNatureOffensive;
            }
            set
            {
                this.oneWithTheNatureOffensive = value;
            }
        }

        public Druid(string name, int level, int age, int manaPoints)
                : base(name, level, age, manaPoints) { }
        public Druid()
            :this(DEFAULT_MOON_FIRE) {}

        public Druid(int moonfireOffensive)
            :this(DEFAULT_MOON_FIRE, DEFAULT_STARBURST, DEFAULT_ONE_WITH_NATURE) {}
        public Druid(int moonfireOffensive, int starburstOffensive, int oneWithTheNatureOffensive)
        {
            this.HitPoints = DEFAULT_HIT_POINTS;
            this.MoonfireOffensive = DEFAULT_MOON_FIRE;
            this.StarburstOffensive = DEFAULT_STARBURST;
            this.OneWithTheNatureOffensive = DEFAULT_ONE_WITH_NATURE;
            this.MagicStaffWeapon = DEFAULT_STAFF_WEAPON;
        }

    }
}

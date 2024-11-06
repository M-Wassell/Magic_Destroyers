
using Blunt;
using Common;
using Enumerations;
using System.Linq.Expressions;

namespace Spellcasters
{
    public class Druid
    {
        private readonly Faction DEFAULT_FACTION = Faction.Spellcaster;
        private readonly MagicStaff DEFAULT_STAFF_WEAPON = new MagicStaff();
        private readonly Fields DEFAULT_FIELDS = new Fields();
        private const int DEFAULT_MOON_FIRE = 50;
        private const int DEFAULT_STARBURST = 60;
        private const int DEFAULT_ONE_WITH_NATURE = 70;

        private int moonfireOffensive, starburstOffensive, oneWithTheNatureOffensive;
        private Faction faction;
        private MagicStaff magicStaffWeapon;
        private Fields genericFields;
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

        public Druid()
            :this(DEFAULT_MOON_FIRE) {}

        public Druid(int moonfireOffensive)
            :this(DEFAULT_MOON_FIRE, DEFAULT_STARBURST, DEFAULT_ONE_WITH_NATURE) {}
        public Druid(int moonfireOffensive, int starburstOffensive, int oneWithTheNatureOffensive)
        {
            this.MoonfireOffensive = DEFAULT_MOON_FIRE;
            this.StarburstOffensive = DEFAULT_STARBURST;
            this.OneWithTheNatureOffensive = DEFAULT_ONE_WITH_NATURE;    
        }

    }
}

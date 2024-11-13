
using Blunt;

using Enumerations;

namespace Spellcasters
{
    public class Mage : Spellcaster
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Faction DEFAULT_FACTION = Faction.Spellcaster;
        private readonly MagicStaff DEFAULT_STAFF_WEAPON = new MagicStaff();
        private const int DEFAULT_ARCANE_WRATH = 50;
        private const int DEFAULT_FIREWALL = 60;
        private const int DEFAULT_MEDITATION = 70;

        private int arcaneWrathOffense, firewallOffense, meditationDeffensive;
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
        public int ArcaneWrathOffense
        {
            get
            {
                return this.arcaneWrathOffense;
            }
            set
            {
                this.arcaneWrathOffense = value;
            }
        }
        public int FirewallOffense
        {
            get
            {
                return this.firewallOffense;
            }
            set
            {
                this.firewallOffense = value;
            }
        }
        public int MeditationDeffensive
        {
            get
            {
                return this.meditationDeffensive;
            }
            set
            {
                this.meditationDeffensive = value;
            }
        }

        public Mage(string name, int level, int age, int manaPoints)
                : base(name, level, age, manaPoints) { }
        public Mage()
            :this(DEFAULT_ARCANE_WRATH) {}

        public Mage(int arcaneWrathOffense)
            :this(DEFAULT_ARCANE_WRATH, DEFAULT_FIREWALL, DEFAULT_MEDITATION) {}
        public Mage(int arcaneWrathOffense, int firewallOffense, int meditationDeffensive)
        {
            this.HitPoints = DEFAULT_HIT_POINTS;
            this.ArcaneWrathOffense = DEFAULT_ARCANE_WRATH;
            this.FirewallOffense = DEFAULT_FIREWALL;
            this.MeditationDeffensive = DEFAULT_MEDITATION;
            this.MagicStaffWeapon = DEFAULT_STAFF_WEAPON;
        }

    }
}

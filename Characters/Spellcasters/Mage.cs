
using Blunt;
using Common;
using Enumerations;
using Interfaces;
using Melee;
using System;
using Weapons;

namespace Spellcasters
{
    public class Mage : Character, ISpellcaster
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
        private Spell mySpell;
        private int mana;

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

        public Spell MySpell 
        {
            get { return this.mySpell; }
            set { this.mySpell = value; }
            
        }
        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                this.mana = value;
            }
        }
        public Mage()
        { 
            this.MySpell = new Spell();
            this.Mana = 100;
        }
        public Mage(string name, int level, int age)
                : base(name, level, age) { }


        public Mage(int arcaneWrathOffense)
            : this(DEFAULT_ARCANE_WRATH, DEFAULT_FIREWALL, DEFAULT_MEDITATION) { }
        public Mage(int arcaneWrathOffense, int firewallOffense, int meditationDeffensive)
        {
            this.HitPoints = DEFAULT_HIT_POINTS;
            this.ArcaneWrathOffense = DEFAULT_ARCANE_WRATH;
            this.FirewallOffense = DEFAULT_FIREWALL;
            this.MeditationDeffensive = DEFAULT_MEDITATION;
            this.MagicStaffWeapon = DEFAULT_STAFF_WEAPON;
        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Warrior sum = {sum}");
            return sum;
        }

        public void CastSpell(Warrior warrior)
        {
            warrior.Health = warrior.Health - this.mySpell.Damage;

            this.mana = this.mana - this.mySpell.ManaCost;
        }
    }
}


using Blunt;
using Common;
using Enumerations;
using Interfaces;
using Melee;
using System;
using System.Linq.Expressions;
using Weapons;

namespace Spellcasters
{
    public class Druid : Character, ISpellcaster
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Faction DEFAULT_FACTION = Faction.Spellcaster;
        private readonly MagicStaff DEFAULT_STAFF_WEAPON = new MagicStaff();
        
        private const int DEFAULT_MOON_FIRE = 50;
        private const int DEFAULT_STARBURST = 60;
        private const int DEFAULT_ONE_WITH_NATURE = 70;

        private int moonfireOffensive, starburstOffensive, oneWithTheNatureOffensive, mana;
        private Faction faction;
        private HitPoints hitPoints;
        private MagicStaff magicStaffWeapon;
        private Spell mySpell;

        
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
        public Spell MySpell
        {
            get
            {
                return this.mySpell;
            }
            set
            {
                this.mySpell = value;
            }
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

        public Druid()
        {
            this.MySpell = new Spell();
            this.Mana = 100;
        }

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

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Warrior sum = {sum}");
            return sum;
        }

        public void CastSpell(Character character)
        {
            Console.WriteLine("Warrior Health Check: " + character.HealthPoints);

            character.HealthPoints = character.HealthPoints - this.MySpell.Damage;
            
            this.mana = this.mana - this.mySpell.ManaCost;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}

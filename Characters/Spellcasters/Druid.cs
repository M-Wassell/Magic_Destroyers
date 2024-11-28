
using MagicDestroyers.Weapons.Blunt;
using Common;
using Enumerations;
using Interfaces;
using Melee;
using System;

using Weapons;
using MagicDestroyers.Weapons;

namespace Spellcasters
{
    public class Druid : Character, ISpellcaster
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Weapon DEFAULT_STAFF_WEAPON = new MagicStaff();
        private const string DEFAULT_NAME = "Hardue";
        private const int DEFAULT_LEVEL = 1;

        private int mana;

        private HitPoints hitPoints;

        private Spell mySpell;

        public HitPoints HitPoints
        {
            get { return this.hitPoints; }
            set { this.hitPoints = value; }
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
            :this(DEFAULT_NAME)
        {
            this.MySpell = new Spell();
            this.Mana = 100;
        }

        public Druid(string name)
            :this(name, DEFAULT_LEVEL) {}
        public Druid(string name, int level)
        {
            base.Factions = Faction.Spellcaster;
            this.HitPoints = DEFAULT_HIT_POINTS;
            base.Weapon = DEFAULT_STAFF_WEAPON;
            base.Level = level;
            base.Name = name;
            base.Factions = Faction.Spellcaster;

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

        public int Moonfire()
        {
            return Weapon.WeaponDamage + 10;
        }
        public int Starburst()
        {
            return Weapon.WeaponDamage + 15;
        }
        public int OneWithTheNature()
        {
            return BodyArmour.ArmourPoints + 10;
        }
        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}

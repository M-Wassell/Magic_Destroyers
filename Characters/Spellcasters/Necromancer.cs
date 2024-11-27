

using Common;
using Enumerations;
using Interfaces;
using MagicDestroyers.Weapons;
using MagicDestroyers.Weapons.Blunt;
using Melee;
using System;
using Weapons;

namespace Spellcasters
{
    internal class Necromancer : Character, ISpellcaster
    {
        private readonly HitPoints DEFAULT_HIT_POINTS = HitPoints.Health;
        private readonly Weapon DEFAULT_STAFF_WEAPON = new MagicStaff();

        private const string DEFAULT_NAME = "Boris";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private HitPoints hitPoints;
        private Spell mySpell;
        private int mana;

        
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

        public Necromancer() 
        { 
            this.MySpell = new Spell();
            this.Mana = 100;
        }
        

        public Necromancer(string name)
            :this(name, DEFAULT_LEVEL) {}

        public Necromancer(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Necromancer(string name, int level, int hitpoints) 
        {
            base.Factions = Faction.Melee;
            base.Weapon = DEFAULT_STAFF_WEAPON;
            base.Level = level;
            this.HitPoints = DEFAULT_HIT_POINTS;
            base.Name = name;

        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Warrior sum = {sum}");
            return sum;
        }


        public void CastSpell(Character character)
        {
            character.HealthPoints = character.HealthPoints - this.mySpell.Damage;
            this.mana = this.mana - this.mySpell.ManaCost;
        }

        public int ShadowRage()
        {
            return base.Weapon.WeaponDamage + 10;
        }
        public int vampireTouch()
        {
            return base.Weapon.WeaponDamage + 10;
        }
        public int boneShield()
        {
            throw new ArgumentOutOfRangeException();// Armour class needed
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.vampireTouch();
        }

        public override int Defend()
        {
            return this.boneShield();
        }

    }
}

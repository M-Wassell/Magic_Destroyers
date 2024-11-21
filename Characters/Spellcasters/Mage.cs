

using Common;
using Enumerations;
using Interfaces;
using MagicDestroyers.Weapons.Blunt;
using Melee;
using System;
using Weapons;

namespace Spellcasters
{
    public class Mage : Spellcaster, ISpellcaster
    {
        private readonly MagicStaff DEFAULT_STAFF_WEAPON = new MagicStaff();
        private const string DEFAULT_NAME = "Hogwarth";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private MagicStaff magicStaffWeapon;
        private Spell mySpell;
        private int mana;

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
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            this.MySpell = new Spell();
            this.Mana = 100;
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS) { }
        public Mage(string name, int level, int healthPoints)
        {
            base.Factions = Faction.Spellcaster;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
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
            character.HealthPoints = character.HealthPoints - this.mySpell.Damage;

            this.mana = this.mana - this.mySpell.ManaCost;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            ArcaneWrath();
        }

        public override void SpecialAttack()
        {
            Firewall();
        }

        public override void Defend()
        {
            Meditation();
        }
    }
}

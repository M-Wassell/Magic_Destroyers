

using Enumerations;
using MagicDestroyers.Weapons.Sharp;


namespace Melee
{
    public class Knight : Melee
    {
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private const string DEFAULT_NAME = "Kane";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 100;

        private Sword swordWeapon;

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

        public Knight()
            :this(DEFAULT_NAME) {}

        public Knight(string name)
            :this(name, DEFAULT_LEVEL, DEFAULT_HEALTH_POINTS) {}

        public Knight(string name, int level, int healthPoints) 
        {
            base.Factions = Faction.Melee;
            base.Weapon = DEFAULT_SWORD_WEAPON;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum * secondNum;
            return sum;
        }

        public int HolyBlow()
        {
            return base.Weapon.WeaponDamage + 10;
        }

        public int PurifySoul()
        {
            return base.Weapon.WeaponDamage + 15;
        }
        public int RighteousWings()
        {
            return base.BodyArmour.ArmourPoints + 10;
        }
        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}



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
            this.SwordWeapons = DEFAULT_SWORD_WEAPON;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum * secondNum;
            return sum;
        }

        public void HolyBlow()
        {
            throw new System.NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new System.NotImplementedException();
        }
        public void RighteousWings()
        {
            throw new System.NotImplementedException();
        }
        public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new System.NotImplementedException();
        }

        public override void Defend()
        {
            throw new System.NotImplementedException();
        }
    }
}

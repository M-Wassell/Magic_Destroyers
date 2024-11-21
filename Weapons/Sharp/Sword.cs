
using System;

namespace MagicDestroyers.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_WEAPON_DAMAGE = 10;

        public Sword()
            :this(DEFAULT_WEAPON_DAMAGE) {}
        public Sword(int weaponDamage)
        {
            this.WeaponDamage = weaponDamage;
        }


    }
}

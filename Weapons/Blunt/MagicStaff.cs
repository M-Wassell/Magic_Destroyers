
namespace MagicDestroyers.Weapons.Blunt
{
    public class MagicStaff : Blunt
    {
        private const int DEFAULT_WEAPON_DAMAGE = 10;


        public MagicStaff()
            :this(DEFAULT_WEAPON_DAMAGE)
        {}
        public MagicStaff(int weaponDamage)
        {
            this.WeaponDamage = weaponDamage;
        }
    }
}

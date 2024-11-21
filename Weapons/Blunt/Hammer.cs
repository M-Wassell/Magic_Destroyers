
namespace MagicDestroyers.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_WEAPON_DAMMAGE = 10;

        public Hammer()
            :this(DEFAULT_WEAPON_DAMMAGE)
        {
            
        }

        public Hammer(int weaponDamage)
        {
            this.WeaponDamage = weaponDamage;
  
        }
    }
}

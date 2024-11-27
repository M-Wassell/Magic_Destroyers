
namespace MagicDestroyers.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_AXE_DAMMAGE = 10;

        public Axe()
            :this(DEFAULT_AXE_DAMMAGE){}

        public Axe(int weaponDamage) 
        { 
            this.WeaponDamage = weaponDamage;

        }
    }
}

using System;
namespace MagicDestroyers.Weapons
{
    public abstract class Weapon
    {
        private int weaponDamage;

        public int WeaponDamage 
        {
            get {  return this.weaponDamage; }
            set
            {
                if (value >=0 && value <=100)
                {
                    this.weaponDamage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Damage need to be between 1-100");
                }
                
            } 
        }
    }
}

using System;

using Common;

namespace Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get 
            { 
                return this.manaPoints; 
            
            }
            set 
            {
                if (value >= 0 && value <=100)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Mana Points must be between 0 - 100");
                }
                 
            }
        }

    }
}

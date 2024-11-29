using Common;
using System;

namespace Melees
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints
        {
            get 
            { 
                return this.abilityPoints; 
            }
            set 
            {
                if (value >= 0 || value <= 100)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability Points needs to be between 0 - 100");
                }
                 
            }
        }

    }
}

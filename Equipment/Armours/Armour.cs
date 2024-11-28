using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armours
{
    public abstract class Armour
    {
        private int armourPoints;

        public int ArmourPoints
        {
            get
            {
                return this.armourPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.armourPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armour POints should be a positive number");
                }
            }

        }
    }
}

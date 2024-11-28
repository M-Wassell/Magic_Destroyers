using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armours.Leather
{
    public class LeatherVest : Leather
    {
        private const int DEFAULT_ARMOUR_POINTS = 10;

        public LeatherVest()
            :this(DEFAULT_ARMOUR_POINTS)
        {
            
        }

        public LeatherVest(int armourPoints)
        {
            this.ArmourPoints = armourPoints;
        }
    }
}

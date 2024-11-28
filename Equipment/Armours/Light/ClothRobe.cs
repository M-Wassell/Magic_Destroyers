using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armours.Light
{
    public class ClothRobe : Light
    {
        private const int DEFAULT_ARMOUR_POINTS = 10;

        public ClothRobe()
            :this(DEFAULT_ARMOUR_POINTS)
        {
                
        }

        public ClothRobe(int armourPoints)
        {
            this.ArmourPoints = armourPoints;
        }
    }
}

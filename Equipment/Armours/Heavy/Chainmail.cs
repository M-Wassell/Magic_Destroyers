using MagicDestroyers.Armours.Heavy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Armours.Heavy.Chainmail
{
    public class Chainmail : Heavy
    {
        private const int DEFAULT_ARMOUR_POINTS = 10;

        public Chainmail()
            :this(DEFAULT_ARMOUR_POINTS)
        {
            
        }

        protected Chainmail(int armourPoints)
        {
            this.ArmourPoints = armourPoints;
        }
    }
}



using Common;
using System.Security.Authentication.ExtendedProtection;

namespace Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get { return this.manaPoints; }
            set { this.manaPoints = value; }
        }

        public Spellcaster()
        {
                
        }

        public Spellcaster(string name, int level, int age, int manaPoints)
            :base(name, level, age)
        {
            this.ManaPoints = manaPoints;
        }
    }
}

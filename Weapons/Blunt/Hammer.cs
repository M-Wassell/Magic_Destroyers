
namespace Blunt
{
    public class Hammer
    {
        private const int DEFAULT_HAMMER_DAMMAGE = 100;
        private const string DEFAULT_HAMMER_NAME = "Power Hammer";

        private int damage;
        private string hammerName;

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                this.damage = value;
            }
        }
        public string HammerName
        {
            get
            {
                return this.hammerName;
            }

            set
            {
                this.hammerName = value;
            }
        }
        public Hammer(int damage, string hammerName)
        {
            this.Damage = DEFAULT_HAMMER_DAMMAGE;
            this.HammerName = DEFAULT_HAMMER_NAME;
        }
    }
}

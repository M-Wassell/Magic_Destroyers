
namespace Blunt
{
    public class Hammer
    {
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
            this.Damage = damage;
            this.HammerName = hammerName;
        }
    }
}

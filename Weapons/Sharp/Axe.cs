
namespace Sharp
{
    public class Axe
    {
        private int damage;
        private string axeName;

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
        public string AxeName
        {
            get
            {
                return this.axeName;
            }

            set
            {
                this.axeName = value;
            }
        }
        public Axe(int damage, string axeName) 
        { 
            this.Damage = damage;
            this.AxeName = axeName;
        }
    }
}


namespace Sharp
{
    public class Axe
    {
        private const int DEFAULT_AXE_DAMMAGE = 100;
        private const string DEFAULT_AXE_NAME = "Power Axe";

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
            this.Damage = DEFAULT_AXE_DAMMAGE;
            this.AxeName = DEFAULT_AXE_NAME;
        }
    }
}

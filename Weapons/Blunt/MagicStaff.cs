
namespace Blunt
{
    public class MagicStaff
    {
        private const int DEFAULT_STAFF_DAMAGE = 100;
        private const string DEFAULT_STAFF_NAME = "Brute";

        private int damage;
        private string staffName;
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

        public string StaffName
        {
            get
            {
                return this.staffName;
            }

            set
            {
                this.staffName = value;
            }
        }

        public MagicStaff()
            :this(DEFAULT_STAFF_DAMAGE, DEFAULT_STAFF_NAME)
        {
                
        }
        public MagicStaff(int damage, string staffName)
        {
            this.Damage = DEFAULT_STAFF_DAMAGE;
            this.StaffName = DEFAULT_STAFF_NAME;
        }
    }
}

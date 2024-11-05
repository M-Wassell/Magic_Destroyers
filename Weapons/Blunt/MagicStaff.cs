
namespace Blunt
{
    public class MagicStaff
    {
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

        public MagicStaff(int damage, string staffName)
        {
            this.Damage = damage;
            this.StaffName = staffName;
        }
    }
}

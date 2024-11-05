
namespace Melee
{
    public class Knight
    {
        private int holyBlowOffense, purifySoulOffense, righteousWings;

        public int HolyBlowOffense 
        {
            get
            {
                return this.holyBlowOffense;
            }
            set
            {
                this.holyBlowOffense = value;
            } 
        }
        public int PurifySoulOffense
        {
            get
            {
                return this.purifySoulOffense;
            }
            set
            {
                this.purifySoulOffense = value;
            }
        }
        public int RighteousWings
        {
            get
            {
                return this.righteousWings;
            }
            set
            {
                this.righteousWings = value;
            }
        }

        public Knight()
            :this(3){}

        public Knight(int holyBlowOffense)
            :this(4,5,6){}

        public Knight(int holyBlowOffense, int purifySoulOffense, int righteousWings) 
        { 
            this.HolyBlowOffense = holyBlowOffense;
            this.PurifySoulOffense = purifySoulOffense;
            this.RighteousWings = righteousWings;
        }
    }
}

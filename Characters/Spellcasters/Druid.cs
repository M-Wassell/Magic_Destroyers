
namespace Spellcasters
{
    public class Druid
    {
        private int moonfireOffensive, starburstOffensive, oneWithTheNatureOffensive;

        public int MoonfireOffensive 
        {
            get
            {
                return this.moonfireOffensive;
            }
            set
            {
                this.moonfireOffensive = value;
            } 
        }
        public int StarburstOffensive
        {
            get
            {
                return this.starburstOffensive;
            }
            set
            {
                this.starburstOffensive = value;
            }
        }
        public int OneWithTheNatureOffensive
        {
            get
            {
                return this.oneWithTheNatureOffensive;
            }
            set
            {
                this.oneWithTheNatureOffensive = value;
            }
        }

        public Druid()
            :this(40){}

        public Druid(int moonfireOffensive)
            :this(20, 30, 80){}
        public Druid( int moonfireOffensive, int starburstOffensive, int oneWithTheNatureOffensive)
        {
            this.MoonfireOffensive = moonfireOffensive;
            this.StarburstOffensive = starburstOffensive;
            this.OneWithTheNatureOffensive = oneWithTheNatureOffensive;    
        }

    }
}

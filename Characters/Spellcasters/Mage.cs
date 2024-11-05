
namespace Spellcasters
{
    public class Mage
    {
        private int arcaneWrathOffense, firewallOffense, meditationDeffensive;

        public int ArcaneWrathOffense
        {
            get
            {
                return this.arcaneWrathOffense;
            }
            set
            {
                this.arcaneWrathOffense = value;
            }
        }
        public int FirewallOffense
        {
            get
            {
                return this.firewallOffense;
            }
            set
            {
                this.firewallOffense = value;
            }
        }
        public int MeditationDeffensive
        {
            get
            {
                return this.meditationDeffensive;
            }
            set
            {
                this.meditationDeffensive = value;
            }
        }

        public Mage()
            :this(0){}

        public Mage(int arcaneWrathOffense)
            :this(60, 60, 70){}
        public Mage(int arcaneWrathOffense, int firewallOffense, int meditationDeffensive)
        {
            this.ArcaneWrathOffense = arcaneWrathOffense;
            this.FirewallOffense = firewallOffense;
            this.MeditationDeffensive = meditationDeffensive;
        }

    }
}

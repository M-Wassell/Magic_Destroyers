
namespace Melee
{
    public class Assassin
    {
        private int razeOffense, bleedToDeathOffense, survival;
        
        public int RazeOffense 
        {
            get 
            { 
                return this.razeOffense;
            }

            set 
            { 
                this.razeOffense = value;
            } 
        }
        public int BleedToDeathOffense
        {
            get
            {
                return this.bleedToDeathOffense;
            }

            set
            {
                this.bleedToDeathOffense = value;
            }
        }
        public int Survival
        {
            get
            {
                return this.survival;
            }

            set
            {
                this.survival = value;
            }
        }

        public Assassin()
            :this(10, 20){}
        public Assassin(int razeOffense, int bleedToDeathOffense)
            :this(1, 2, 100){}
        public Assassin(int razeOffense, int bleedToDeathOffense, int survival)
        {
            this.RazeOffense = razeOffense;
            this.BleedToDeathOffense = bleedToDeathOffense;
            this.Survival = survival;
        }
    }
}

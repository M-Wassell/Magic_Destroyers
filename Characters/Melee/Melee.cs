

using Common;

namespace Melee
{
    public class Melee : Character
    {
        private int health;

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public Melee()
        {
                
        }
        public Melee(string name, int level, int age, int health)
            :base(name, level, age)
        {
            this.Health = health;
        }
    }
}

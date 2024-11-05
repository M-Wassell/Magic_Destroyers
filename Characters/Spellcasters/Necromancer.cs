
namespace Spellcasters
{
    internal class Necromancer
    {
        private int shadowRageOffense, vampireTouchOffense, boneShieldDefense;

        public int ShadowRageOffense
        {
            get
            {
                return this.shadowRageOffense;
            }
            set
            {
                this.shadowRageOffense = value;
            }
        }
        public int VampireTouchOffense
        {
            get
            {
                return this.vampireTouchOffense;
            }
            set
            {
                this.vampireTouchOffense = value;
            }
        }
        public int BoneShieldDefense
        {
            get
            {
                return this.boneShieldDefense;
            }
            set
            {
                this.boneShieldDefense = value;
            }
        }

        public Necromancer()
            :this(2){}

        public Necromancer(int shadowRageOffense)
            :this(20, 20, 50){}

        public Necromancer(int shadowRageOffense, int vampireTouchOffense, int boneShieldDefense) 
        {
            this.ShadowRageOffense = shadowRageOffense;
            this.VampireTouchOffense = vampireTouchOffense;
            this.BoneShieldDefense = boneShieldDefense;
        }
    }
}

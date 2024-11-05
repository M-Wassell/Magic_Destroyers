using System;

namespace Sharp
{
    public class Sword
    {
        private int damage;
        private string swordName;

        public string SwordName
        {
            get
            {
                return this.swordName;
            }

            set
            {
                this.swordName = value;
            }
        }
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

        public Sword(string swordName, int damage)
        {
            this.Damage = damage;
            this.SwordName = swordName;
        }

        public void SwordType1()
        {
            Console.WriteLine($"{this.SwordName} does: {this.Damage} Damage");
        }


    }
}

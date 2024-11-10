//using MagicDestroyers.Enumerations;
using System;

namespace Sharp
{
    public class Sword
    {
        private const string DEFAULT_SWORD_NAME = "Demon";
        private const int DEFAULT_SWORD_DAMAGE = 100;

        private string swordName;
        private int damage;


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

        public Sword()
            :this(DEFAULT_SWORD_NAME, 10){}
        public Sword(string swordName, int damage)
        {
            this.Damage = damage;
            this.SwordName = swordName;
        }

        public void SwordType1()
        {
            Console.WriteLine($"{DEFAULT_SWORD_NAME} does: {DEFAULT_SWORD_DAMAGE} Damage");
        }


    }
}

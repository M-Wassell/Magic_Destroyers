
using Common;
using Enumerations;


using Sharp;
using System;

namespace Melee
{
    public class Warrior : Melee
    {
        private readonly Faction DEFAULT_FACTION = Faction.Melee;
        private readonly Sword DEFAULT_SWORD = new Sword();
        private Faction faction;
        
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }

        public Warrior()
            : this(Faction.Melee) { }

        public Warrior(Faction faction)
        {

            base.Sword = DEFAULT_SWORD;

        }

        public void SwordDamage(string damage)
        {
            Console.WriteLine($"damage = {damage}");
        }

        public virtual void WarriorAttributes()
        {
            Console.WriteLine($"I am a mighty Warrior");
            base.CharacterAttributes();
        }

        public override int Addition(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Warrior sum = {sum}");
            return sum;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            Strike();
        }

        public override void SpecialAttack()
        {
            Execute();
        }

        public override void Defend()
        {
            SkinHarden();
        }
    }
}

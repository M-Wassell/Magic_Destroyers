using Melee;
using Sharp;
using System;
using System.Collections.Generic;
using Enumerations;
using Spellcasters;

namespace MagicDestroyers
{
    internal class EntryPoint
    {

        static void Main()
        {

            Warrior warrior = new Warrior("Mike", 10, 37, 100);

            Druid druid = new Druid();

            Mage mage = new Mage();

            Necromancer necromancer = new Necromancer();

            Console.WriteLine("Entry Point check Necromancer Mana: " + necromancer.Mana);

            Console.WriteLine("Entry Point check Warrior health: " + warrior.Health);

            mage.CastSpell(warrior);

            Console.WriteLine("Entry Point check Mage Mana:  " + mage.Mana);

            Console.WriteLine("Entry Point check Warrior health: " + warrior.Health);

            Console.ReadLine();

        }
    }
}

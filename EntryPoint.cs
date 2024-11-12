using Melee;
using Sharp;
using System;
using System.Collections.Generic;
using Enumerations;

namespace MagicDestroyers
{
    internal class EntryPoint
    {

        static void Main()
        {

            Warrior warrior = new Warrior("Mike", 10, 37, 100);
            warrior.Name = "Brandon";

            Console.WriteLine(warrior.Name);

            warrior.WarriorAttributes();

            Console.ReadLine();

        }
    }
}

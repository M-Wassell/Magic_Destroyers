﻿using MagicDestroyers.Characters.Melee;
using Sharp;
using Common;



using System;
using System.Collections.Generic;


namespace MagicDestroyers
{
    internal class EntryPoint
    {
        
        static void Main()
        {
            //Fields fields = new Fields("Jamie", "Wieners");

            Warrior warrior = new Warrior("Mike", "Big Balls", 500, "Excalibre", 100, 4, 5);

            Sword sword = new Sword("Bob", 300);

            warrior.Greeting();

            warrior.GenericFields.Character();
            Console.WriteLine("^^^^^ Character() called");

            sword.SwordType1();

            Console.WriteLine("^^^^^ Acces Via Sword");

            warrior.SwordWeapons.SwordType1();

            Console.WriteLine("^^^^^ Acces Via Warrior");

            warrior.SwordDamage(warrior.SwordWeapons.SwordName, warrior.SwordWeapons.Damage);

            

            Console.ReadLine();

        }
    }
}
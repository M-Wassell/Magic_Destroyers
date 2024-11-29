

using Common;
using Melees;
using Spellcasters;
using System;
using System.Collections.Generic;

namespace MagicDestroyers
{
    public class EntryPoint
    {

        static void Main()
        {
            bool gameOver = false;

            Random random = new Random();

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            List<Character> charcters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            foreach(var character in charcters)
            {
                if(character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if(character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            PlayersInfo.Initialize(charcters);

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            while(!gameOver)
            {
                currentMelee = meleeTeam[random.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellTeam[random.Next(0, spellTeam.Count)];

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                if (!currentSpellcaster.IsAlive)
                {
                    Tools.ColourfulWriteLine("\nMelee team wins!", ConsoleColor.Red);
                    break;
                }
                else
                {
                    currentSpellcaster = spellTeam[random.Next(0, spellTeam.Count)];

                }

                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Tools.ColourfulWriteLine("\nSpell team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[random.Next(0, meleeTeam.Count)];
                    }
                }
            }

            PlayersInfo.UpdateFullInfo(charcters);
            PlayersInfo.Save(charcters);
            PlayersInfo.PrintFullInfo();
        }
    }
}

using System;


namespace MagicDestroyers
{
    public static class Tools
    {
        public static void ColourfulWriteLine(string message, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void CharacterSpecificMessageColour(string message, string type)
        {
            ConsoleColor colour = ConsoleColor.White;

            switch (type)
            {
                case "MagicDestroyers.Characters.Melee.Warrior":
                    colour = ConsoleColor.Magenta;
                    break;
                case "MagicDestroyers.Characters.Melee.Knight":
                    colour = ConsoleColor.Red;
                    break;
                case "MagicDestroyers.Characters.Melee.Assassin":
                    colour = ConsoleColor.DarkGreen;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Mage":
                    colour = ConsoleColor.DarkBlue;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Necromancer":
                    colour = ConsoleColor.Gray;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Druid":
                    colour = ConsoleColor.DarkYellow;
                    break;
            }

            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

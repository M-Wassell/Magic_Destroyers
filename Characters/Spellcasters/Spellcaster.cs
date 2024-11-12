

using Common;
using System.Security.Authentication.ExtendedProtection;

namespace Spellcasters
{
    public class Spellcaster : Character
    {
        private int mangaPoints;

        public int MangaPoints
        {
            get { return this.mangaPoints; }
            set { this.mangaPoints = value; }
        }
    }
}

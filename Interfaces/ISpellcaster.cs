

using Melee;

namespace Interfaces
{
    public interface ISpellcaster
    {
        int Mana { get; set; }
        void CastSpell(Warrior warrior);
    }
}

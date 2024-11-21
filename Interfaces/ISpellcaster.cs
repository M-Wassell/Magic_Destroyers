
using Common;


namespace Interfaces
{
    public interface ISpellcaster
    {
        int Mana { get; set; }
        void CastSpell(Character character);
    }
}

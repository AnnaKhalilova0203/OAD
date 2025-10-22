using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Marfa : Entity.Character
{
    public Marfa(string name) : base(name, CharacterClass.Marfa)
    {
        Health = 90;
        Strength = 90;
        Intelligence = 80;
        Agility = 150;
        Speed = 50;
        Sexuality = 100;
        Special = "Uderza nożem";
    }
}
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Anna : Entity.Character
{
    public Anna(string name) : base(name, CharacterClass.Anna)
    {
        Health = 80;
        Strength = 40;
        Intelligence = 200;
        Agility = 100;
        Speed = 50;
        Sexuality = 100;
        Special = "Uderza z buta";
    }
}
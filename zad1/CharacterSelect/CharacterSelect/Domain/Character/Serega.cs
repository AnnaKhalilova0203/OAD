using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Serega : Entity.Character
{
    public Serega(string name) : base(name, CharacterClass.Serega)
    {
        Health = 100;
        Strength = 100;
        Intelligence = 80;
        Agility = 100;
        Speed = 50;
        Sexuality = 100;
        Special = "Uderza piszczelami";
    }
}
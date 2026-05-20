using ConsoleApp2.models;

namespace ConsoleApp2.strategies;

public class LevelAccessStrategy: IAccessStrategy
{
    private readonly int _requiredLevel;
    public LevelAccessStrategy(int requiredLevel)
    {
       _requiredLevel = requiredLevel;
    }
    public bool CanAccess(Player player)
    {
      return player.Level >= _requiredLevel;
    }

    public string GetInfo()
    {
       return $"dostęp od poziomu {_requiredLevel}"; 
    }
}
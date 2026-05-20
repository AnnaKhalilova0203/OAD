using ConsoleApp2.models;

namespace ConsoleApp2.strategies;

public class PremiumAccessStrategy: IAccessStrategy
{
    public bool CanAccess(Player player)
    {
        return player.IsPremium;
    }

    public string GetInfo()
    {
        return "dostęp tylko dla graczy premium";
    }
}
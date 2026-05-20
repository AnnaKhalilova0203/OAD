using ConsoleApp2.models;
using ConsoleApp2.strategies;

namespace ConsoleApp2.servises;

public class PayWallService
{
    private readonly IAccessStrategy _strategy;

    public PayWallService(IAccessStrategy strategy)
    {
        _strategy = strategy;
    }

    public bool CheckAccess(Player player)
    {
        return _strategy.CanAccess(player);
    }
    
}
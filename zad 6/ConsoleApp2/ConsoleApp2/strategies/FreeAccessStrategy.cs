using ConsoleApp2.models;

namespace ConsoleApp2.strategies;

public class FreeAccessStrategy: IAccessStrategy
{
    public bool CanAccess(Player player)
    {
        return true;
    }

    public string GetInfo()
    {
        return "Dostęp darmowy dla każdego";
    }
}
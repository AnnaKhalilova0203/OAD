using ConsoleApp2.models;

namespace ConsoleApp2.strategies;

public class DlcAccessStrategy: IAccessStrategy
{
    public bool CanAccess(Player player)
    {
        return player.HasDlc;
    }

    public string GetInfo()
    {
       return "Dostęp tylko dla graczy posiądających DLC";
    }
}
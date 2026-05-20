using ConsoleApp2.models;

namespace ConsoleApp2.strategies;



    public interface IAccessStrategy
    {
        bool CanAccess(Player player);
        string GetInfo();
    }

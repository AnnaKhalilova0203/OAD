using ConsoleApp2.enums;
using ConsoleApp2.models;
using ConsoleApp2.strategies;

namespace ConsoleApp2.factory;

public static class AccessStrategyFactory
{
    public static IAccessStrategy CreateStrategy(AccessType type, int requiredLevel = 0)
    {
        return type switch
        {
            AccessType.Dlc => new DlcAccessStrategy(),
            AccessType.Free => new FreeAccessStrategy(),
            AccessType.Premium => new PremiumAccessStrategy(),
            AccessType.Level => new LevelAccessStrategy(requiredLevel),
            _ => throw new ArgumentException("nieznany typ dostępu")
        };
    }
}
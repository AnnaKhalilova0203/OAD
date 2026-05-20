using ConsoleApp2.enums;
using ConsoleApp2.factory;
using ConsoleApp2.models;
using ConsoleApp2.servises;
using ConsoleApp2.strategies;

namespace PayWallGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var player = new Player
			{
				Name = "ANUKUS",
				Level = 10,
				IsPremium = false,
				HasDlc = true
			};
			AccessType type = AccessType.Level;
			IAccessStrategy strategy = AccessStrategyFactory.CreateStrategy(type, requiredLevel:5);
			var payWallService = new PayWallService(strategy);
			bool canAccess = payWallService.CheckAccess(player);
			Console.WriteLine($"gracz: {player.Name}");
			Console.WriteLine(strategy. GetInfo());
			Console.WriteLine($"Dostęp: {(canAccess?"Tak":"Nie")}");
		}
	}
}
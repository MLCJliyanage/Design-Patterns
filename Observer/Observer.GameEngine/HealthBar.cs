namespace Observer.GameEngine;

public class HealthBar(Player player) : IGameObserver
{
	private readonly Player _player = player;
	public void Update()
	{
		var health = _player.GetHealth();

		Console.WriteLine($"Health: {health}");

	}
}
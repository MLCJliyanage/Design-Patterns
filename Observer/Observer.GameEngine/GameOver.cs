namespace Observer.GameEngine;

public class GameOver(Player player) : IGameObserver
{
	private readonly Player _player = player;
	public void Update()
	{
		var health = _player.GetHealth();
		var score = _player.GetScore();

		if (health == 0)
		{
			Console.WriteLine($"Game over your score is: {score}");
		}
		
	}
}
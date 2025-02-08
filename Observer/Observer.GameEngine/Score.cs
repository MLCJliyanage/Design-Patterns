namespace Observer.GameEngine;

public class Score(Player player) : IGameObserver
{
	private readonly Player _player = player;
	public void Update()
	{
		var score = _player.GetScore();

		Console.WriteLine($"Current score is: {score}");

	}
}
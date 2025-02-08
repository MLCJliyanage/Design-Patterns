namespace Observer.GameEngine;

public class Player : IGameSubject
{
	private readonly List<IGameObserver> _observers = [];
	private int _score;
	private int _health;

	public void SetState(int score, int health)
	{
		_score = score;
		_health = health;
		Notify();
	}

	public int GetScore()
	{
		return _score;
	}

	public int GetHealth()
	{
		return _health;
	}

	public void Attach(IGameObserver observer)
	{
		_observers.Add(observer);
	}

	public void Detach(IGameObserver observer)
	{
		_observers.Remove(observer);
	}

	public void Notify()
	{
		foreach (var observer in _observers)
		{
			observer.Update();
		}
	}
}
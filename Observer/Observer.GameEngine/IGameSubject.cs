namespace Observer.GameEngine;

public interface IGameSubject
{
	void Attach(IGameObserver gameObserver);
	void Detach(IGameObserver gameObserver);
	void Notify();
}
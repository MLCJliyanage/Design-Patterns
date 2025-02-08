﻿namespace Observer.Example;

public class ConcreteObserver(ConcreteSubject subject) : IObserver
{
	private readonly ConcreteSubject _subject = subject;
	public void Update()
	{
		var state = _subject.GetState();
		Console.WriteLine($"Observer reacted to state: {state}");
	}
}
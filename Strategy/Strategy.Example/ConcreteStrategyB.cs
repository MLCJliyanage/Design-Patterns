namespace Strategy.Example;

public class ConcreteStrategyB : IStrategy
{
	public void Execute()
	{
		Console.WriteLine("Called ConcreteStrategyB.Execute()");
	}
}
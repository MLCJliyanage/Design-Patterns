namespace Strategy.Example;

public class ConcreteStrategyA : IStrategy
{
	public void Execute()
	{
		Console.WriteLine("Called ConcreteStrategyA.Execute()");
	}
}
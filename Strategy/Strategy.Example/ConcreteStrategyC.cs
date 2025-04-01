namespace Strategy.Example;

public class ConcreteStrategyC : IStrategy
{
	public void Execute()
	{
		Console.WriteLine("Called ConcreteStrategyC.Execute()");
	}
}
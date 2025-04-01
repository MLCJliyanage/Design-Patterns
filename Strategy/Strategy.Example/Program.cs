// See https://aka.ms/new-console-template for more information

using Strategy.Example;

Context context = new();

context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyC());
context.ExecuteStrategy();

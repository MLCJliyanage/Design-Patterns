using Observer.Example;

ConcreteSubject subject = new ConcreteSubject();

subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));

subject.SetState("State 1");

await Task.Delay(1500);

subject.SetState("State 2");

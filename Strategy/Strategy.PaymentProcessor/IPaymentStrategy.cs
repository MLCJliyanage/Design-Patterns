namespace Strategy.PaymentProcessor;

public interface IPaymentStrategy
{
	void Pay(decimal amount);
}
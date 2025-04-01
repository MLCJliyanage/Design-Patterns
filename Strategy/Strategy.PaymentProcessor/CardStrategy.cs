namespace Strategy.PaymentProcessor;

public class CardStrategy(
	string name,
	string cardNumber,
	string cvv,
	string expireDate) : IPaymentStrategy
{
	private string _name = name;
	private string _cardNumber = cardNumber;
	private string _cvv = cvv;
	private string _expireDate = expireDate;

	public void Pay(decimal amount)
	{
		Console.WriteLine($"Paid {amount} using card.");
	}
}
namespace Strategy.PaymentProcessor;

public class BankTransferStrategy(
	string bankName,
	string accountNumber) : IPaymentStrategy
{
	private readonly string _bankName = bankName;
	private string _accountNumber = accountNumber;
	public void Pay(decimal amount)
	{
		Console.WriteLine($"Transferred {amount} to {_bankName}");
	}
}
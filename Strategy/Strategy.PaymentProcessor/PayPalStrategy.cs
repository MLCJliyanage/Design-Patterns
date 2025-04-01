﻿namespace Strategy.PaymentProcessor;

public class PayPalStrategy(
	string email,
	string password) : IPaymentStrategy
{
	private string _email = email;
	private string _password = password;

	public void Pay(decimal amount)
	{
		Console.WriteLine($"Paid {amount} using paypal.");
	}
}
using Strategy.PaymentProcessor;

ShoppingCart shoppingCart = new();

shoppingCart.SetStrategy(new CardStrategy(
	name:"John P",
	cardNumber:"1234",
	cvv:"123",
	expireDate:"12/26"));
shoppingCart.Checkout(1000.50m);

shoppingCart.SetStrategy(new PayPalStrategy(
	email: "abc@gmail.com",
	password:"password"));
shoppingCart.Checkout(200.50m);

shoppingCart.SetStrategy(new BankTransferStrategy(
	bankName:"HSBC",
	accountNumber:"12345-23456"));
shoppingCart.Checkout(500.50m);

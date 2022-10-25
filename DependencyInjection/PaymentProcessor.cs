namespace DependencyInjection
{
	public interface IPaymentProcessor
	{
		void ChargeCreditCard(string creditCardNumber, string expiryDate);
	}

	public class PaymentProcessor : IPaymentProcessor
	{
		public void ChargeCreditCard(string creditCardNumber, string expiryDate)
		{
			if (string.IsNullOrEmpty(creditCardNumber))
			{
				throw new ArgumentException("Invalid Credit Card");
			}

			if (string.IsNullOrEmpty(expiryDate))
			{
				throw new ArgumentException("Invalid Expiry Date");
			}

			Console.WriteLine("Call To Credit Card API");
		}
	}
}

using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
	public static readonly IServiceProvider Container = new ContainerBuilder().Build();

	private static void Main(string[] args)
	{
		var product = string.Empty;
		var orderManager = Container.GetService<IOrderManager>();

		while (product != "exit")
		{

			Console.WriteLine(@"Enter Product
Keyboard = 0,
Mouse = 1,
Mic = 2,
Speaker = 3");

			product = Console.ReadLine();
			try
			{
				if (Enum.TryParse(product, out Product productEnum))
				{
					Console.WriteLine("Please enter a valid payment method: XXXXXXXXXXXXXXXX;MM/YY");
					var paymentMethod = Console.ReadLine();

					if (string.IsNullOrEmpty(paymentMethod) || paymentMethod.Split(";").Length != 2)
						throw new Exception("Invalid Payment Method");

					orderManager.Submit(productEnum, paymentMethod.Split(";")[0], paymentMethod.Split(";")[1]);
					Console.WriteLine($"{productEnum.ToString()} has been shipped");
				}
				else
				{
					Console.WriteLine("Invalid Product");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine(Environment.NewLine);
		}
	}
}
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
	public class ContainerBuilder
	{
		public IServiceProvider Build()
		{
			var container = new ServiceCollection();

			container.AddSingleton<IOrderManager, OrderManager>();
			container.AddSingleton<IPaymentProcessor, PaymentProcessor>();
			container.AddSingleton<IProductStockRepository, ProductStockRepository>();
			container.AddSingleton<IShippingProcessor, ShippingProcessor>();

			return container.BuildServiceProvider();
		}
	}
}

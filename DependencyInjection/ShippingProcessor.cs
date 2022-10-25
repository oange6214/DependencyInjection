namespace DependencyInjection
{
	public interface IShippingProcessor
	{
		void MailProduct(Product product);
	}

	public class ShippingProcessor : IShippingProcessor
	{
		private readonly IProductStockRepository _productStockRepository;
		public ShippingProcessor(IProductStockRepository productStockRepository)
		{
			_productStockRepository = productStockRepository;
		}

		public void MailProduct(Product product)
		{
			_productStockRepository.ReduceStock(product);

			Console.WriteLine("Call To Shipping API");
		}
	}
}

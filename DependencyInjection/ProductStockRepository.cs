namespace DependencyInjection
{
	public interface IProductStockRepository
	{
		bool IsInStock(Product product);
		void ReduceStock(Product product);
		void AddStock(Product product);
	}

	public class ProductStockRepository : IProductStockRepository
	{
		private static Dictionary<Product, int> _productStockDatabase = Setup();

		private static Dictionary<Product, int> Setup()
		{
			var productStockDatabase = new Dictionary<Product, int>();
			productStockDatabase.Add(Product.Keyboard, 1);
			productStockDatabase.Add(Product.Mic, 1);
			productStockDatabase.Add(Product.Mouse, 1);
			productStockDatabase.Add(Product.Speaker, 1);
			return productStockDatabase;
		}

		public bool IsInStock(Product product)
		{
			Console.WriteLine("Call Get On Database");
			return _productStockDatabase[product] > 0;
		}

		public void ReduceStock(Product product)
		{
			Console.WriteLine("Call Update On Database");
			_productStockDatabase[product]--;
		}

		public void AddStock(Product product)
		{
			Console.WriteLine("Call Update On Database");
			_productStockDatabase[product]++;
		}
	}
}

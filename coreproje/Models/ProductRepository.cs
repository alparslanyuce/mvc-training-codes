namespace coreproje.Models
{
	public class ProductRepository
	{
		private static List<Product> _products = new List<Product>()
		{
		new()
				{
					Id = 1,
					Name = "kalem1",
					Price = 100,
					Stock =300
				},
		new ()
				{
					Id = 2,
					Name = "kalem2",
					Price = 200,
					Stock = 500
				}
		};

		public List<Product> GetAll() => _products;

		public void AddProduct(Product newProduct) => _products.Add(newProduct);

		public void Remove(int id)
		{
			var hasproduct = _products.FirstOrDefault(x => x.Id == id);

			if(hasproduct != null)
			{
				_products.Remove(hasproduct);
			}
			else
			{
				throw new Exception($"bu id({id}'ye sahip ürün bulunamamıştır.)");
			}
		}

		public void Update(Product updateProduct)
		{
			var hasproduct = _products.FirstOrDefault(x=> x.Id== updateProduct.Id);
			if( hasproduct != null)
			{
				hasproduct.Name =updateProduct.Name;
				hasproduct.Price=updateProduct.Price;
				hasproduct.Stock=updateProduct.Stock;

				var index=_products.FindIndex(x=> x.Id == updateProduct.Id);
				_products[index] = hasproduct;
			}
			else
			{
				throw new Exception($"bu id({updateProduct.Id}'ye sahip ürün bulunamamıştır.)");
			}
		}
		

	}
}

using _01_DataAccessLayer.Abstarct;
using _01_DataAccessLayer.Context;
using _01_DataAccessLayer.Repositories;
using _01_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public List<ProductPretty> GetProductsWithCategory()
		{
			var context = new CampContext();
			var values = context.Products.Select(p => new ProductPretty
			{
				ProductId = p.ProductId,
				ProductName = p.ProductName,
				ProductStock = p.ProductStock,
				ProductPrice = p.ProductPrice,
				ProductDescription = p.ProductDescription,
				CategoryName = p.Category.CategoryName,
			}).ToList();

			return values;
		}
	}
}

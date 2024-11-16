using System.Collections.Generic;

namespace _01_EntityLayer.Concrete
{
	public class Category
	{
		public int CategoryId { get; set; } // CodeFirst yaklaşımında primary key olarak alınması için entityNameId şeklinde olmalıdır.
		public string CategoryName { get; set; }
		public bool CategoryStatus { get; set; }
		public List<Product> Products { get; set; }
	}
}

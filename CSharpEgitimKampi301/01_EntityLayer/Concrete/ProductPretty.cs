using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EntityLayer.Concrete
{
	public class ProductPretty
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int ProductStock { get; set; }
		public decimal ProductPrice { get; set; }
		public string ProductDescription { get; set; }
		public string CategoryName { get; set; }
	}
}

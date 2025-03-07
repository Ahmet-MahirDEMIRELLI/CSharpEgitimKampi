﻿using System.Collections.Generic;

namespace _01_EntityLayer.Concrete
{
	public class Customer
	{
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerSurname { get; set; }
		public string CustomerDistrict { get; set; }
		public string CustomerCity { get; set; }
		public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }
    }
}

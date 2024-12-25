using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
	public class CustomerOperations
	{
		public void AddCustomer(Customer customer)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomersCollection();
			var document = new BsonDocument
			{
				{"Name", customer.Name},
				{"Surname", customer.Surname},
				{"City", customer.City},
				{"Balance", customer.Balance},
				{"OrderCount", customer.OrderCount}
			};
			customerCollection.InsertOne(document);
		}
	}
}

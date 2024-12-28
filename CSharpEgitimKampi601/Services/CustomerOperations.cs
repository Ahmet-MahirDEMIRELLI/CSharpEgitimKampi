using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
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

		public List<Customer> GetAllCustomers()
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomersCollection();
			var customers = customerCollection.Find(new BsonDocument()).ToList();
			List<Customer> customerList = new List<Customer>();
			foreach (var customer in customers)
			{
				customerList.Add(new Customer
				{
					CustomerId = customer["_id"].ToString(),
					Name = customer["Name"].ToString(),
					Surname = customer["Surname"].ToString(),
					City = customer["City"].ToString(),
					Balance = decimal.Parse(customer["Balance"].ToString()),
					OrderCount = int.Parse(customer["OrderCount"].ToString()),
				});
			}

			return customerList;
		}

		public void DeleteCustomer(string id)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
			customerCollection.DeleteOne(filter);
		}

		public void UpdateCustomer(Customer customer)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
			var updatedValue = Builders<BsonDocument>.Update
				.Set("Name", customer.Name)
				.Set("Surname", customer.Surname)
				.Set("City", customer.City)
				.Set("Balance", customer.Balance)
				.Set("OrderCount", customer.OrderCount);
			customerCollection.UpdateOne(filter, updatedValue);
		}

		public Customer GetById(string id)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
			var customer = customerCollection.Find(filter).FirstOrDefault();
			return new Customer 
			{
				CustomerId = id,
				Name = customer["Name"].ToString(),
				Surname = customer["Surname"].ToString(),
				City = customer["City"].ToString(),
				Balance = decimal.Parse(customer["Balance"].ToString()),
				OrderCount = int.Parse(customer["OrderCount"].ToString())
			};
		}
	}
}

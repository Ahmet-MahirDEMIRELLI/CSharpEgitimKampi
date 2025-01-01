using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=12345";
		
		void GetAllCustomers()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM Customers";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}
		private void btnList_Click(object sender, EventArgs e)
		{
			GetAllCustomers();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string surname = txtSurname.Text;
			string city = txtCity.Text;
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "INSERT INTO Customers(Name, Surname, City) VALUES(@name, @surname, @city)";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@name", name);
			command.Parameters.AddWithValue("@surname", surname);
			command.Parameters.AddWithValue("@city", city);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Ekleme başarılı");
			GetAllCustomers();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "DELETE FROM Customers WHERE Id = @id";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@Id", id);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Silme başarılı");
			GetAllCustomers();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			string name = txtName.Text;
			string surname = txtSurname.Text;
			string city = txtCity.Text;
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "UPDATE CUSTOMERS SET Name = @name, Surname = @surname, City = @city WHERE Id = @id";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@name", name);
			command.Parameters.AddWithValue("@surname", surname);
			command.Parameters.AddWithValue("@city", city);
			command.Parameters.AddWithValue("@Id", id);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Güncelleme başarılı");
			GetAllCustomers();
		}
	}
}

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
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;password=12345";

		void EmployeeList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM Employees";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connection.Close();
		}

		void DepartmentList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "SELECT * FROM Departments";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			cmbDepartment.DisplayMember = "Name";
			cmbDepartment.ValueMember = "DepartmentId";
			cmbDepartment.DataSource = dt;
			connection.Close();
		}
		private void btnList_Click(object sender, EventArgs e)
		{
			EmployeeList();
		}

		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			EmployeeList();
			DepartmentList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string surname = txtSurname.Text;
			decimal salary = decimal.Parse(txtSalary.Text);
			int depId = int.Parse(cmbDepartment.SelectedValue.ToString());
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "INSERT INTO Employees(Name, Surname, Salary, DepartmentId) VALUES(@name, @surname, @salary, @departmentId)";
			var command = new NpgsqlCommand(query, connection);
			command.Parameters.AddWithValue("@name", name);
			command.Parameters.AddWithValue("@surname", surname);
			command.Parameters.AddWithValue("@salary", salary);
			command.Parameters.AddWithValue("@departmentId", depId);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Ekleme başarılı");
			EmployeeList();
		}
	}
}

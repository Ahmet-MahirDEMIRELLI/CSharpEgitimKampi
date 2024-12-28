using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		CustomerOperations customerOperations = new CustomerOperations();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var customer = new Customer()
			{
				Name = txtName.Text,
				Surname = txtSurname.Text,
				City = txtCity.Text,
				Balance = decimal.Parse(txtBalance.Text),
				OrderCount = int.Parse(txtOrderCount.Text)
			};
			customerOperations.AddCustomer(customer);
			MessageBox.Show("Ekleme başarılı");
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			List<Customer> customerList = customerOperations.GetAllCustomers();
			dataGridView1.DataSource = customerList;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string customerId = txtId.Text;
			customerOperations.DeleteCustomer(customerId);
			MessageBox.Show("Silme işlemi başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var customer = new Customer()
			{
				CustomerId = txtId.Text,
				Name = txtName.Text,
				Surname = txtSurname.Text,
				City = txtCity.Text,
				Balance = decimal.Parse(txtBalance.Text),
				OrderCount = int.Parse(txtOrderCount.Text)
			};
			customerOperations.UpdateCustomer(customer);
			MessageBox.Show("Güncelleme başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			var customerId = txtId.Text;
			Customer customer = customerOperations.GetById(customerId);
			dataGridView1.DataSource = new List<Customer>() { customer };
		}
	}
}

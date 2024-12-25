﻿using CSharpEgitimKampi601.Entities;
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
	}
}

using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=*****; initial Catalog=EgitimKampi501Db; integrated security=true");
		private async void btnList_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM TblProduct;";
			var values = await connection.QueryAsync<ResultProductDto>(query);
			dataGridView1.DataSource = values;
		}

		private async void btnAdd_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TblProduct(ProductName, ProductStock, ProductPrice, ProductCategory) VALUES(@a, @b, @c, @d);";
			var parameters = new DynamicParameters();
			parameters.Add("@a", txtName.Text);
			parameters.Add("@b", txtStock.Text);
			parameters.Add("@c", txtPrice.Text);
			parameters.Add("@d", txtCategory.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Ekleme başarılı.");
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			string query = "DELETE FROM TblProduct WHERE ProductId = @a;";
			var parameters = new DynamicParameters();
			parameters.Add("@a", txtId.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Silme başarılı.");
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			string query = "UPDATE TblProduct SET ProductName=@a, ProductPrice=@b, ProductStock=@c, ProductCategory=@d WHERE ProductId=@e;";
			var parameters = new DynamicParameters();
			parameters.Add("@a", txtName.Text);
			parameters.Add("@b", txtStock.Text);
			parameters.Add("@c", txtPrice.Text);
			parameters.Add("@d", txtCategory.Text);
			parameters.Add("@e", txtId.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Güncelleme başarılı.");
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			string query = "SELECT SUM(ProductStock) FROM TblProduct;";
			var value1 = await connection.QueryFirstOrDefaultAsync<int>(query);
			lblProductCount.Text = value1.ToString();

			query = "SELECT ProductName FROM TblProduct WHERE ProductPrice = (Select MAX(ProductPrice) FROM TblProduct);";
			var value2 = await connection.QueryFirstOrDefaultAsync<string>(query);
			lblPricyName.Text = value2;

			query = "SELECT COUNT(DISTINCT ProductCategory) FROM TblProduct";
			var value3 = await connection.QueryFirstOrDefaultAsync<int>(query);
			lblCategoryCount.Text = value3.ToString();
		}
	}
}

using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
	public partial class FrmCategories : Form
	{
		private int _userId;
		public FrmCategories(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmCategories_Load(object sender, EventArgs e)
		{
			ListCategories();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			ListCategories();
		}

		private void ListCategories()
		{
			var values = db.Categories.Select(x => new { x.CategoryId, x.CategoryName}).ToList();
			dataGridView1.DataSource = values;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			Categories category = new Categories() { CategoryName = name };
			db.Categories.Add(category);
			db.SaveChanges();
			MessageBox.Show("Kategori başarılı bir şekilde sisteme eklendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListCategories();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			string name = txtName.Text;
			var updatedValue = db.Categories.Find(id);
			updatedValue.CategoryName = name;
			db.SaveChanges();
			MessageBox.Show("Ödeme başarılı bir şekilde sistemde güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListCategories();
		}

		private void btnBanksForm_Click(object sender, EventArgs e)
		{
			FrmBanks frm = new FrmBanks(_userId);
			frm.Show();
			this.Close();
		}

		private void btnSpendings_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling(_userId);
			frm.Show();
			this.Close();
		}

		private void btnBankProcesses_Click(object sender, EventArgs e)
		{
			FrmProcesses frm = new FrmProcesses(_userId);
			frm.Show();
			this.Close();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard(_userId);
			frm.Show();
			this.Close();
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			FrmBills frm = new FrmBills(_userId);
			frm.Show();
			this.Close();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			FrmSettings frm = new FrmSettings(_userId);
			frm.Show();
			this.Close();
		}
	}
}

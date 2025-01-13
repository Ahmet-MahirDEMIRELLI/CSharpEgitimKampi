using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmBilling : Form
	{
		private int _userId;
		public FrmBilling(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBilling_Load(object sender, EventArgs e)
		{
			ListBills();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			ListBills();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string title = txtTitle.Text;
			decimal amount = decimal.Parse(txtAmount.Text);
			string period = txtPeriod.Text;
			Bills bills = new Bills()
			{
				BillTitle = title,
				BillAmount = amount,
				BillPeriod = period,
			};

			db.Bills.Add(bills);
			db.SaveChanges();
			MessageBox.Show("Ödeme başarılı bir şekilde sisteme eklendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListBills();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtBillId.Text);
			var removedValue = db.Bills.Find(id);
			db.Bills.Remove(removedValue);
			db.SaveChanges();
			MessageBox.Show("Ödeme başarılı bir şekilde sistemden silindi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListBills();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtBillId.Text);
			string title = txtTitle.Text;
			decimal amount = decimal.Parse(txtAmount.Text);
			string period = txtPeriod.Text;
			var updatedValue = db.Bills.Find(id);
			updatedValue.BillTitle = title;
			updatedValue.BillAmount = amount;
			updatedValue.BillPeriod = period;
			db.SaveChanges();
			MessageBox.Show("Ödeme başarılı bir şekilde sistemde güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ListBills();
		}

		private void ListBills()
		{
			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}

		private void btnBanksForm_Click(object sender, EventArgs e)
		{
			FrmBanks frm = new FrmBanks(_userId);
			frm.Show();
			this.Close();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard(_userId);
			frm.Show();
			this.Close();
		}

		private void btnBankProcesses_Click(object sender, EventArgs e)
		{
			FrmProcesses frm = new FrmProcesses(_userId);
			frm.Show();
			this.Close();
		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frm = new FrmCategories(_userId);
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

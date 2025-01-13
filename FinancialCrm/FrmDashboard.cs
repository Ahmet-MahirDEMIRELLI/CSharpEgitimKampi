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
	public partial class FrmDashboard : Form
	{
		private int _userId;
		public FrmDashboard(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		int count = 0;
		private void FrmDashboard_Load(object sender, EventArgs e)
		{
			lblTotalBalance.Text = db.Banks.Sum(x => x.BankBalance).ToString() + " ₺";
			lblLastBankProcessAmount.Text = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault().ToString() + " ₺";

			// Chart 1
			var bankData = db.Banks.Select(x => new
			{
				x.BankTitle,
				x.BankBalance
			}).ToList();

			var bankSeries = chart1.Series.FindByName("Bakiyeler");
			foreach(var data in bankData)
			{
				bankSeries.Points.AddXY(data.BankTitle, data.BankBalance);
			}

			// Chart 2
			var billData = db.Bills.Select(x => new
			{
				x.BillTitle,
				x.BillAmount
			}).ToList();

			var billSeries = chart2.Series.FindByName("Faturalar");
			foreach (var data in billData)
			{
				billSeries.Points.AddXY(data.BillTitle, data.BillAmount);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count++;
			switch(count % 4)
			{
				case 0:
					lblBillTitle.Text = "Elektrik Faturası";
					lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault().ToString() + " ₺";
					break;
				case 1:
					lblBillTitle.Text = "Doğalgaz Faturası";
					lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault().ToString() + " ₺";
					break;
				case 2:
					lblBillTitle.Text = "Su Faturası";
					lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault().ToString() + " ₺";
					break;
				case 3:
					lblBillTitle.Text = "İnternet Faturası";
					lblBillAmount.Text = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault().ToString() + " ₺";
					break;
			}
		}

		private void btnBanks_Click(object sender, EventArgs e)
		{
			FrmBanks frm = new FrmBanks(_userId);
			frm.Show();
			this.Close();
		}

		private void btnSpendingsForm_Click(object sender, EventArgs e)
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

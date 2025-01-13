using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmBanks : Form
	{
		private int _userId;
		public FrmBanks(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmBanks_Load(object sender, EventArgs e)
		{
			// balances
			lblZiraatBalance.Text =  db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault().ToString() + " ₺";
			lblVakıfBalance.Text = db.Banks.Where(x => x.BankTitle == "Vakıf Bank").Select(y => y.BankBalance).FirstOrDefault().ToString() + " ₺";
			lblIsBalance.Text = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault().ToString() + " ₺";
			// processes
			var lastFiveProcess = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).ToList();
			int index = 0;
			lblProcess1.Text = lastFiveProcess.Count > index ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess2.Text = lastFiveProcess.Count > index ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess3.Text = lastFiveProcess.Count > index ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess4.Text = lastFiveProcess.Count > index ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess5.Text = lastFiveProcess.Count > index ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
		}

		private void btnSpendingsForm_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling(_userId);
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

using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmBanks : Form
	{
		public FrmBanks()
		{
			InitializeComponent();
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
			lblProcess1.Text = lastFiveProcess[index] != null ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess2.Text = lastFiveProcess[index] != null ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess3.Text = lastFiveProcess[index] != null ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess4.Text = lastFiveProcess[index] != null ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
			index++;
			lblProcess5.Text = lastFiveProcess[index] != null ? lastFiveProcess[index].Description + " " + lastFiveProcess[index].Amount + " " + lastFiveProcess[index].ProcessDate : "";
		}

		private void btnSpendingsForm_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling();
			frm.Show();
			this.Hide();
		}
	}
}

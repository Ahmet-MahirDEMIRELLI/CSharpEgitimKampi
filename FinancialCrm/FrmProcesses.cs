using FinancialCrm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
	public partial class FrmProcesses : Form
	{
		private int _userId;
		public FrmProcesses(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void FrmProcesses_Load(object sender, EventArgs e)
		{
			lblTotalIn.Text = db.BankProcesses.Where(x => x.ProcessType == "Gelen Havale").Sum(y => y.Amount).ToString() + " ₺";
			lblTotalOut.Text = db.BankProcesses.Where(x => x.ProcessType == "Giden Havale").Sum(y => y.Amount).ToString() + " ₺";

			var lastFiveInProcess = db.BankProcesses.Where(x => x.ProcessType == "Gelen Havale").OrderByDescending(x => x.BankProcessId).Take(5).ToList();
			var lastFiveOutProcess = db.BankProcesses.Where(x => x.ProcessType == "Giden Havale").OrderByDescending(x => x.BankProcessId).Take(5).ToList();
			int index = 0;
			lblProcessIn1.Text = lastFiveInProcess.Count > index ? lastFiveInProcess[index].Description + " " + lastFiveInProcess[index].Amount + " " + lastFiveInProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			lblProcessOut1.Text = lastFiveOutProcess.Count > index ? lastFiveOutProcess[index].Description + " " + lastFiveOutProcess[index].Amount + " " + lastFiveOutProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			index++;
			lblProcessIn2.Text = lastFiveInProcess.Count > index ? lastFiveInProcess[index].Description + " " + lastFiveInProcess[index].Amount + " " + lastFiveInProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			lblProcessOut2.Text = lastFiveOutProcess.Count > index ? lastFiveOutProcess[index].Description + " " + lastFiveOutProcess[index].Amount + " " + lastFiveOutProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			index++;
			lblProcessIn3.Text = lastFiveInProcess.Count > index ? lastFiveInProcess[index].Description + " " + lastFiveInProcess[index].Amount + " " + lastFiveInProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			lblProcessOut3.Text = lastFiveOutProcess.Count > index ? lastFiveOutProcess[index].Description + " " + lastFiveOutProcess[index].Amount + " " + lastFiveOutProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			index++;
			lblProcessIn4.Text = lastFiveInProcess.Count > index ? lastFiveInProcess[index].Description + " " + lastFiveInProcess[index].Amount + " " + lastFiveInProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			lblProcessOut4.Text = lastFiveOutProcess.Count > index ? lastFiveOutProcess[index].Description + " " + lastFiveOutProcess[index].Amount + " " + lastFiveOutProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			index++;
			lblProcessIn5.Text = lastFiveInProcess.Count > index ? lastFiveInProcess[index].Description + " " + lastFiveInProcess[index].Amount + " " + lastFiveInProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
			lblProcessOut5.Text = lastFiveOutProcess.Count > index ? lastFiveOutProcess[index].Description + " " + lastFiveOutProcess[index].Amount + " " + lastFiveOutProcess[index].ProcessDate.ToString().Split(' ')[0] : "";
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

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			FrmDashboard frm = new FrmDashboard(_userId);
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

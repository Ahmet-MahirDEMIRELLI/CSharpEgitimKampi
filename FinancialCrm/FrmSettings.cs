using FinancialCrm.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancialCrm
{
	public partial class FrmSettings : Form
	{
		private int _userId;
		public FrmSettings(int userId)
		{
			InitializeComponent();
			_userId = userId;
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtUserId.Text);
			string newUserName = txtUserName.Text;
			string newPassword = txtNewPassword.Text;
			var updatedValue = db.Users.Find(id);
			if (!string.IsNullOrEmpty(newUserName))
			{
				updatedValue.UserName = newUserName;
			}
			if (!string.IsNullOrEmpty(newPassword))
			{
				updatedValue.Password = newPassword;
			}
			db.SaveChanges();
			MessageBox.Show("Bilgileriniz başarılı bir şekilde sistemde güncellendi.", "Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			SetUserInfo();
		}

		private void SetUserInfo()
		{
			var user = db.Users.Find(_userId);
			txtUserId.Text = user.UserId.ToString();
			txtUserName.Text = user.UserName;
			txtNewPassword.Text = "";
		}

		private void FrmSettings_Load(object sender, EventArgs e)
		{
			SetUserInfo();
		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			FrmCategories frm = new FrmCategories(_userId);
			frm.Show();
			this.Close();
		}

		private void btnBanksForm_Click(object sender, EventArgs e)
		{
			FrmBanks frm = new FrmBanks(_userId);
			frm.Show();
			this.Close();
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			FrmBills frm = new FrmBills(_userId);
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
	}
}

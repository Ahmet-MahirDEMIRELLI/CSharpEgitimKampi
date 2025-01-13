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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();
		private void btnLogin_Click(object sender, EventArgs e)
		{
			var id = int.Parse(txtId.Text);
			var password = txtPassword.Text;
			if(db.Users.Any(u => u.UserId == id && u.Password == password))
			{
				FrmDashboard frm = new FrmDashboard(id);
				frm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Hatalı bilgi. Tekrar deneyiniz.", "Giriş Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}

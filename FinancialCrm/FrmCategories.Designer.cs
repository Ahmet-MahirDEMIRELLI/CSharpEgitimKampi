namespace FinancialCrm
{
	partial class FrmCategories
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.lblBillId = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBanksForm = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnSpendings = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(741, 233);
			this.dataGridView1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Location = new System.Drawing.Point(213, 248);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(741, 233);
			this.panel4.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.btnAdd);
			this.panel3.Controls.Add(this.btnList);
			this.panel3.Controls.Add(this.txtName);
			this.panel3.Controls.Add(this.lblTitle);
			this.panel3.Controls.Add(this.txtCategoryId);
			this.panel3.Controls.Add(this.lblBillId);
			this.panel3.Location = new System.Drawing.Point(213, 77);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(741, 165);
			this.panel3.TabIndex = 7;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdate.Location = new System.Drawing.Point(568, 36);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(170, 38);
			this.btnUpdate.TabIndex = 24;
			this.btnUpdate.Text = "Kategori Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.DimGray;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAdd.Location = new System.Drawing.Point(363, 91);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(170, 38);
			this.btnAdd.TabIndex = 23;
			this.btnAdd.Text = "Kategori Ekle";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.DimGray;
			this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnList.Location = new System.Drawing.Point(363, 36);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(170, 38);
			this.btnList.TabIndex = 18;
			this.btnList.Text = "Kategori Listesi";
			this.btnList.UseVisualStyleBackColor = false;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtName.Location = new System.Drawing.Point(112, 80);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(202, 32);
			this.txtName.TabIndex = 21;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTitle.Location = new System.Drawing.Point(6, 89);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(100, 21);
			this.lblTitle.TabIndex = 22;
			this.lblTitle.Text = "Kategori Adı:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategoryId.Location = new System.Drawing.Point(112, 42);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(202, 28);
			this.txtCategoryId.TabIndex = 19;
			// 
			// lblBillId
			// 
			this.lblBillId.AutoSize = true;
			this.lblBillId.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillId.Location = new System.Drawing.Point(16, 51);
			this.lblBillId.Name = "lblBillId";
			this.lblBillId.Size = new System.Drawing.Size(90, 21);
			this.lblBillId.TabIndex = 20;
			this.lblBillId.Text = "Kategori Id:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kategoriler Formu";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(968, 71);
			this.panel2.TabIndex = 6;
			// 
			// btnBanksForm
			// 
			this.btnBanksForm.BackColor = System.Drawing.Color.Transparent;
			this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanksForm.Location = new System.Drawing.Point(16, 97);
			this.btnBanksForm.Name = "btnBanksForm";
			this.btnBanksForm.Size = new System.Drawing.Size(163, 34);
			this.btnBanksForm.TabIndex = 1;
			this.btnBanksForm.Text = "Bankalar";
			this.btnBanksForm.UseVisualStyleBackColor = false;
			this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
			// 
			// btnCategories
			// 
			this.btnCategories.BackColor = System.Drawing.Color.Transparent;
			this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategories.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategories.Location = new System.Drawing.Point(16, 57);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Size = new System.Drawing.Size(163, 34);
			this.btnCategories.TabIndex = 0;
			this.btnCategories.Text = "Kategoriler";
			this.btnCategories.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnLogOut);
			this.panel1.Controls.Add(this.btnSettings);
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Controls.Add(this.btnBankProcesses);
			this.panel1.Controls.Add(this.btnSpendings);
			this.panel1.Controls.Add(this.btnBills);
			this.panel1.Controls.Add(this.btnBanksForm);
			this.panel1.Controls.Add(this.btnCategories);
			this.panel1.Location = new System.Drawing.Point(-1, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 422);
			this.panel1.TabIndex = 5;
			// 
			// btnLogOut
			// 
			this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
			this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogOut.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogOut.Location = new System.Drawing.Point(16, 337);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(163, 34);
			this.btnLogOut.TabIndex = 7;
			this.btnLogOut.Text = "Çıkış Yap";
			this.btnLogOut.UseVisualStyleBackColor = false;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.BackColor = System.Drawing.Color.Transparent;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSettings.Location = new System.Drawing.Point(16, 297);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(163, 34);
			this.btnSettings.TabIndex = 6;
			this.btnSettings.Text = "Ayarlar";
			this.btnSettings.UseVisualStyleBackColor = false;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDashboard.Location = new System.Drawing.Point(16, 257);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(163, 34);
			this.btnDashboard.TabIndex = 5;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.UseVisualStyleBackColor = false;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnBankProcesses
			// 
			this.btnBankProcesses.BackColor = System.Drawing.Color.Transparent;
			this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBankProcesses.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankProcesses.Location = new System.Drawing.Point(16, 217);
			this.btnBankProcesses.Name = "btnBankProcesses";
			this.btnBankProcesses.Size = new System.Drawing.Size(163, 34);
			this.btnBankProcesses.TabIndex = 4;
			this.btnBankProcesses.Text = "Banka Hareketleri";
			this.btnBankProcesses.UseVisualStyleBackColor = false;
			this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
			// 
			// btnSpendings
			// 
			this.btnSpendings.BackColor = System.Drawing.Color.Transparent;
			this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendings.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendings.Location = new System.Drawing.Point(16, 177);
			this.btnSpendings.Name = "btnSpendings";
			this.btnSpendings.Size = new System.Drawing.Size(163, 34);
			this.btnSpendings.TabIndex = 3;
			this.btnSpendings.Text = "Giderler";
			this.btnSpendings.UseVisualStyleBackColor = false;
			this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
			// 
			// btnBills
			// 
			this.btnBills.BackColor = System.Drawing.Color.Transparent;
			this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBills.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBills.Location = new System.Drawing.Point(16, 137);
			this.btnBills.Name = "btnBills";
			this.btnBills.Size = new System.Drawing.Size(163, 34);
			this.btnBills.TabIndex = 2;
			this.btnBills.Text = "Faturalar";
			this.btnBills.UseVisualStyleBackColor = false;
			this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
			// 
			// FrmCategories
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 493);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmCategories";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmCategories";
			this.Load += new System.EventHandler(this.FrmCategories_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBanksForm;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnSpendings;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label lblBillId;
	}
}
namespace FinancialCrm
{
	partial class FrmDashboard
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
			this.pnlIs = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblBillAmount = new System.Windows.Forms.Label();
			this.pnlVakıf = new System.Windows.Forms.Panel();
			this.lblBillTitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotalBalance = new System.Windows.Forms.Label();
			this.pnlZiraat = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnBankProcesses = new System.Windows.Forms.Button();
			this.btnSpendingsForm = new System.Windows.Forms.Button();
			this.btnBills = new System.Windows.Forms.Button();
			this.btnBanks = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pnlIs.SuspendLayout();
			this.pnlVakıf.SuspendLayout();
			this.pnlZiraat.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblLastBankProcessAmount
			// 
			this.lblLastBankProcessAmount.AutoSize = true;
			this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLastBankProcessAmount.Location = new System.Drawing.Point(17, 40);
			this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
			this.lblLastBankProcessAmount.Size = new System.Drawing.Size(132, 53);
			this.lblLastBankProcessAmount.TabIndex = 10;
			this.lblLastBankProcessAmount.Text = "0.00 ₺";
			// 
			// pnlIs
			// 
			this.pnlIs.BackColor = System.Drawing.Color.OrangeRed;
			this.pnlIs.Controls.Add(this.lblLastBankProcessAmount);
			this.pnlIs.Controls.Add(this.label4);
			this.pnlIs.Location = new System.Drawing.Point(728, 87);
			this.pnlIs.Name = "pnlIs";
			this.pnlIs.Size = new System.Drawing.Size(227, 129);
			this.pnlIs.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(38, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Gelen Son Havale";
			// 
			// lblBillAmount
			// 
			this.lblBillAmount.AutoSize = true;
			this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillAmount.Location = new System.Drawing.Point(28, 40);
			this.lblBillAmount.Name = "lblBillAmount";
			this.lblBillAmount.Size = new System.Drawing.Size(132, 53);
			this.lblBillAmount.TabIndex = 11;
			this.lblBillAmount.Text = "0.00 ₺";
			// 
			// pnlVakıf
			// 
			this.pnlVakıf.BackColor = System.Drawing.Color.OrangeRed;
			this.pnlVakıf.Controls.Add(this.lblBillAmount);
			this.pnlVakıf.Controls.Add(this.lblBillTitle);
			this.pnlVakıf.Location = new System.Drawing.Point(479, 87);
			this.pnlVakıf.Name = "pnlVakıf";
			this.pnlVakıf.Size = new System.Drawing.Size(227, 129);
			this.pnlVakıf.TabIndex = 11;
			// 
			// lblBillTitle
			// 
			this.lblBillTitle.AutoSize = true;
			this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillTitle.Location = new System.Drawing.Point(54, 0);
			this.lblBillTitle.Name = "lblBillTitle";
			this.lblBillTitle.Size = new System.Drawing.Size(59, 24);
			this.lblBillTitle.TabIndex = 9;
			this.lblBillTitle.Text = "Başlık";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(45, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "Toplam Bakiye";
			// 
			// lblTotalBalance
			// 
			this.lblTotalBalance.AutoSize = true;
			this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBalance.Location = new System.Drawing.Point(16, 40);
			this.lblTotalBalance.Name = "lblTotalBalance";
			this.lblTotalBalance.Size = new System.Drawing.Size(132, 53);
			this.lblTotalBalance.TabIndex = 9;
			this.lblTotalBalance.Text = "0.00 ₺";
			// 
			// pnlZiraat
			// 
			this.pnlZiraat.BackColor = System.Drawing.Color.OrangeRed;
			this.pnlZiraat.Controls.Add(this.label2);
			this.pnlZiraat.Controls.Add(this.lblTotalBalance);
			this.pnlZiraat.Location = new System.Drawing.Point(227, 87);
			this.pnlZiraat.Name = "pnlZiraat";
			this.pnlZiraat.Size = new System.Drawing.Size(227, 129);
			this.pnlZiraat.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dashboard";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(968, 71);
			this.panel2.TabIndex = 8;
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
			// 
			// btnSpendingsForm
			// 
			this.btnSpendingsForm.BackColor = System.Drawing.Color.Transparent;
			this.btnSpendingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpendingsForm.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSpendingsForm.Location = new System.Drawing.Point(16, 177);
			this.btnSpendingsForm.Name = "btnSpendingsForm";
			this.btnSpendingsForm.Size = new System.Drawing.Size(163, 34);
			this.btnSpendingsForm.TabIndex = 3;
			this.btnSpendingsForm.Text = "Giderler";
			this.btnSpendingsForm.UseVisualStyleBackColor = false;
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
			// 
			// btnBanks
			// 
			this.btnBanks.BackColor = System.Drawing.Color.Transparent;
			this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBanks.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBanks.Location = new System.Drawing.Point(16, 97);
			this.btnBanks.Name = "btnBanks";
			this.btnBanks.Size = new System.Drawing.Size(163, 34);
			this.btnBanks.TabIndex = 1;
			this.btnBanks.Text = "Bankalar";
			this.btnBanks.UseVisualStyleBackColor = false;
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
			this.panel1.Controls.Add(this.btnSpendingsForm);
			this.panel1.Controls.Add(this.btnBills);
			this.panel1.Controls.Add(this.btnBanks);
			this.panel1.Controls.Add(this.btnCategories);
			this.panel1.Location = new System.Drawing.Point(-1, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 422);
			this.panel1.TabIndex = 7;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(227, 269);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Bakiyeler";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(340, 207);
			this.chart1.TabIndex = 12;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(615, 269);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "Faturalar";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(340, 207);
			this.chart2.TabIndex = 13;
			this.chart2.Text = "chart2";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(227, 222);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(340, 41);
			this.panel3.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
			this.panel4.Controls.Add(this.label5);
			this.panel4.Location = new System.Drawing.Point(615, 222);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(340, 41);
			this.panel4.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(34, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Bankalarınızdaki para miktarları";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(3, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(321, 21);
			this.label5.TabIndex = 17;
			this.label5.Text = "Ödenen ve ödenmesi gereken fatura tutarları";
			// 
			// FrmDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 488);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.pnlIs);
			this.Controls.Add(this.pnlVakıf);
			this.Controls.Add(this.pnlZiraat);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmDashboard";
			this.Text = "FrmDashboard";
			this.Load += new System.EventHandler(this.FrmDashboard_Load);
			this.pnlIs.ResumeLayout(false);
			this.pnlIs.PerformLayout();
			this.pnlVakıf.ResumeLayout(false);
			this.pnlVakıf.PerformLayout();
			this.pnlZiraat.ResumeLayout(false);
			this.pnlZiraat.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblLastBankProcessAmount;
		private System.Windows.Forms.Panel pnlIs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblBillAmount;
		private System.Windows.Forms.Panel pnlVakıf;
		private System.Windows.Forms.Label lblBillTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotalBalance;
		private System.Windows.Forms.Panel pnlZiraat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnBankProcesses;
		private System.Windows.Forms.Button btnSpendingsForm;
		private System.Windows.Forms.Button btnBills;
		private System.Windows.Forms.Button btnBanks;
		private System.Windows.Forms.Button btnCategories;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
	}
}


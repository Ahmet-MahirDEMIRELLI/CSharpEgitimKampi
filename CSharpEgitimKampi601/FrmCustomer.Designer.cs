namespace CSharpEgitimKampi601
{
	partial class FrmCustomer
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(107, 313);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(201, 29);
			this.btnGetById.TabIndex = 35;
			this.btnGetById.Text = "Id\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(314, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(538, 320);
			this.dataGridView1.TabIndex = 34;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(107, 278);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(201, 29);
			this.btnUpdate.TabIndex = 33;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(107, 243);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(201, 29);
			this.btnDelete.TabIndex = 32;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(107, 208);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(201, 29);
			this.btnAdd.TabIndex = 31;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(107, 173);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(201, 29);
			this.btnList.TabIndex = 30;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(107, 125);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(201, 22);
			this.txtCity.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 24;
			this.label4.Text = "Şehri:";
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(107, 97);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(201, 22);
			this.txtSurname.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "Soyadı:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(107, 69);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(201, 22);
			this.txtName.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Adı:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(107, 41);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(201, 22);
			this.txtId.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Müşteri Id:";
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 450);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCustomer";
			this.Text = "FrmCustomer";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
	}
}
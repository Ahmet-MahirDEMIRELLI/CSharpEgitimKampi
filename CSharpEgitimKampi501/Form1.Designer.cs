namespace CSharpEgitimKampi501
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblPricyName = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün Id:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(101, 42);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(160, 22);
			this.txtId.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(101, 211);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(160, 44);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(306, 42);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(545, 377);
			this.dataGridView1.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(101, 70);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(160, 22);
			this.txtName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ürün Adı:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(101, 98);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(160, 22);
			this.txtPrice.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fiyat:";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(101, 126);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(160, 22);
			this.txtStock.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Stok:";
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(101, 154);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(160, 22);
			this.txtCategory.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Kategori:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(101, 261);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(160, 44);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(101, 311);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(160, 44);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(101, 361);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(160, 44);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 473);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "Toplam Kitap Sayısı:";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Location = new System.Drawing.Point(172, 473);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(14, 16);
			this.lblProductCount.TabIndex = 16;
			this.lblProductCount.Text = "0";
			// 
			// lblPricyName
			// 
			this.lblPricyName.AutoSize = true;
			this.lblPricyName.Location = new System.Drawing.Point(172, 498);
			this.lblPricyName.Name = "lblPricyName";
			this.lblPricyName.Size = new System.Drawing.Size(14, 16);
			this.lblPricyName.TabIndex = 18;
			this.lblPricyName.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(68, 498);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "En Pahalı Ürün:";
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Location = new System.Drawing.Point(172, 523);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(14, 16);
			this.lblCategoryCount.TabIndex = 20;
			this.lblCategoryCount.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(68, 523);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(108, 16);
			this.label9.TabIndex = 19;
			this.label9.Text = "Katageroi Sayısı:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 583);
			this.Controls.Add(this.lblCategoryCount);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblPricyName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblProductCount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblProductCount;
		private System.Windows.Forms.Label lblPricyName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblCategoryCount;
		private System.Windows.Forms.Label label9;
	}
}


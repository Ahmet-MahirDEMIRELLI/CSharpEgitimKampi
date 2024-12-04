﻿namespace _01_PresentationLayer
{
	partial class FrmCategory
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
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rdbActive = new System.Windows.Forms.RadioButton();
			this.rdbPassive = new System.Windows.Forms.RadioButton();
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kategori ID:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(117, 22);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(166, 22);
			this.txtCategoryId.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(117, 123);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(166, 39);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(316, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(472, 317);
			this.dataGridView1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kategori Durum:";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(117, 50);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(166, 22);
			this.txtCategoryName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kategori Adı:";
			// 
			// rdbActive
			// 
			this.rdbActive.AutoSize = true;
			this.rdbActive.Location = new System.Drawing.Point(139, 79);
			this.rdbActive.Name = "rdbActive";
			this.rdbActive.Size = new System.Drawing.Size(53, 20);
			this.rdbActive.TabIndex = 8;
			this.rdbActive.TabStop = true;
			this.rdbActive.Text = "Aktif";
			this.rdbActive.UseVisualStyleBackColor = true;
			// 
			// rdbPassive
			// 
			this.rdbPassive.AutoSize = true;
			this.rdbPassive.Location = new System.Drawing.Point(207, 79);
			this.rdbPassive.Name = "rdbPassive";
			this.rdbPassive.Size = new System.Drawing.Size(58, 20);
			this.rdbPassive.TabIndex = 9;
			this.rdbPassive.TabStop = true;
			this.rdbPassive.Text = "Pasif";
			this.rdbPassive.UseVisualStyleBackColor = true;
			// 
			// btnGetById
			// 
			this.btnGetById.Location = new System.Drawing.Point(117, 303);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(166, 39);
			this.btnGetById.TabIndex = 10;
			this.btnGetById.Text = "ID\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(117, 258);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(166, 39);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(117, 213);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(166, 39);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(117, 168);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(166, 39);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 372);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.rdbPassive);
			this.Controls.Add(this.rdbActive);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCategory";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdbActive;
		private System.Windows.Forms.RadioButton rdbPassive;
		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
	}
}


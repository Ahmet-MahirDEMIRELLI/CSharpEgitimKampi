using _01_BusinessLayer.Abstarct;
using _01_BusinessLayer.Concrete;
using _01_DataAccessLayer.EntityFramework;
using _01_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_PresentationLayer
{
	public partial class FrmCategory : Form
	{
		private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
			InitializeComponent();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			var categoryValues = _categoryService.TGetAll();
			dataGridView1.DataSource = categoryValues;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Category category = new Category();
			category.CategoryName = txtCategoryName.Text;
			category.CategoryStatus = true;
			_categoryService.TInsert(category);
			MessageBox.Show("Ekleme Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var categoryToDelete = _categoryService.TGetById(id);
			_categoryService.TDelete(categoryToDelete);
			MessageBox.Show("Silme Başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var categoryToUpdate = _categoryService.TGetById(id);
			categoryToUpdate.CategoryName = txtCategoryName.Text;
			_categoryService.TUpdate(categoryToUpdate);
			MessageBox.Show("Güncelleme Başarılı");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			var categoryToList = _categoryService.TGetById(id);
			dataGridView1 .DataSource = categoryToList;
		}
	}
}

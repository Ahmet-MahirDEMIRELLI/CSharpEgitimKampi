using _01_BusinessLayer.Abstarct;
using _01_BusinessLayer.Concrete;
using _01_DataAccessLayer.EntityFramework;
using _01_EntityLayer.Concrete;
using System;
using System.Windows.Forms;

namespace _01_PresentationLayer
{
	public partial class FrmProduct : Form
	{
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;
		public FrmProduct()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
			_categoryService = new CategoryManager(new EfCategoryDal());
		}
		
		private void btnList_Click(object sender, EventArgs e)
		{
			var values = _productService.TGetAll();
			dataGridView1.DataSource = values;
		}

		private void btnList2_Click(object sender, EventArgs e)
		{
			var values = _productService.TGetProductsWithCategory();
			dataGridView1.DataSource = values;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductId.Text);
			var value = _productService.TGetById(id);
			_productService.TDelete(value);
			MessageBox.Show("Silme işlemi başarılı.");
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			product.ProductPrice = decimal.Parse(txtProductPrice.Text);
			product.ProductName = txtProductName.Text;
			product.ProductDescription = txtProductDescription.Text;
			product.ProductStock = int.Parse(txtProductStock.Text);
			_productService.TInsert(product);
			MessageBox.Show("Ekleme işlemi yapıldı.");
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductId.Text);
			var value = _productService.TGetById(id);
			dataGridView1.DataSource = value;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtProductId.Text);
			var value = _productService.TGetById(id);
			value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			value.ProductPrice = decimal.Parse(txtProductPrice.Text);
			value.ProductName = txtProductName.Text;
			value.ProductDescription = txtProductDescription.Text;
			value.ProductStock = int.Parse(txtProductStock.Text);
			_productService.TUpdate(value);
			MessageBox.Show("Güncelleme işlemi yapıldı.");
		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			var values = _categoryService.TGetAll();
			cmbCategory.DataSource = values;
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryId";
		}
	}
}

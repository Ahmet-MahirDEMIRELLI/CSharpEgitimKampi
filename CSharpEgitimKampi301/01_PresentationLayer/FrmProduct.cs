using _01_BusinessLayer.Abstarct;
using _01_BusinessLayer.Concrete;
using _01_DataAccessLayer.EntityFramework;
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
	public partial class FrmProduct : Form
	{
		private readonly IProductService _productService;
		public FrmProduct()
		{
			InitializeComponent();
			_productService = new ProductManager(new EfProductDal());
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
			throw new NotImplementedException();
		}
	}
}

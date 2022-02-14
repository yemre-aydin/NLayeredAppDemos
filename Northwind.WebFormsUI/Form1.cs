using NorthwindBusiness.Abstract;
using NorthwindBusiness.Concrete;
using NorthwindBusiness.DependencyResolvers.Ninject;
using NorthwindDataAccess.Concrete.EntityFramework;
using NorthwindDataAccess.Concrete.NHibernate;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _productService= InstanceFactory.GetInstance<IProductService>();

            _categoryService = InstanceFactory.GetInstance<ICategoryService>();//ICategoryService yi çözümle diyoruz burada 
                                                //tamamen sadece interface e bağlı kaldık. INstanceFactory ile 
        }
        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            //bağımlılıkları olabildiğince azaltmak gerek
            LoadProducts();
            LoadCategories();

        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void LoadCategories()//niyet güdümlü programlama varmış gibi kodluyoruz
        {
            cbxCategory.DataSource= _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch
            {

               
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);

            }
            else
            {
                LoadProducts();//yoksa tüm ürünleri getir
            }
        }
    }
}

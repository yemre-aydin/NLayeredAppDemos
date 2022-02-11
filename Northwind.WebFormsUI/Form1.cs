using NorthwindBusiness.Abstract;
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

            _productService= new ProductManager(new NhProductDal());
        }
        private IProductService _productService;


        private void Form1_Load(object sender, EventArgs e)
        {
            //bağımlılıkları olabildiğince azaltmak gerek
            dgwProduct.DataSource = _productService.GetAll();

        }
    }
}

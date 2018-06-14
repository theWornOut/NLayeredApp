using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N.Business.Abstract;
using N.Business.Concrete;
using N.DataAccess.Concrete.EntityFramework;
using N.DataAccess.Concrete.NHibernate;

namespace N.WinformsUI
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;
        public Form1()
        {
            _productService = new ProductManager(new EfProductDal());
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = _productService.GetAll();
        }
    }
}
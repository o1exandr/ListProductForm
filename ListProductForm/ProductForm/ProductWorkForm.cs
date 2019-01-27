using ListProductForm.Entities;
using ListProductForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListProductForm.ProductForm
{
    public partial class ProductWorkForm : Form
    {
        private readonly EFContext _context;
        public ProductWorkForm()
        {
            InitializeComponent();
            _context = new EFContext();
        }

        private void ProductWorkForm_Load(object sender, EventArgs e)
        {
            List<ProductItemModel> list = _context
                .Products
                .Select(p => new ProductItemModel
                {
                    Id=p.Id,
                    Name=p.Name,
                    CategoryName=p.CategoryOf.Name
                })
                .ToList();
            foreach (var product in list)
            {
                object[] row = { product.Id,
                    product.Name, product.CategoryName };
                dgvProducts.Rows.Add(row);
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
        }
    }
}

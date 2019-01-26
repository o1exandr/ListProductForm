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
    public partial class ProductAddForm : Form
    {
        private readonly EFContext _context;
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            List<Category> list = _context
                .Categories
                .Select(p => new Category
                {
                    Id = p.Id,
                    Name = p.Name,
                })
                .ToList();
            cmbCategory.Items.Add(list);
            /*
            foreach (var category in list)
            {
                object[] row = { category.Id,
                    category.Name };
                cmbCategory.Items.Add(string(row.));
            }
            */
        }
    }
}

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
            _context = new EFContext();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        { 
            var listCategories = _context.Categories
               .Select(c => new SelectItemElement
               {
                   Id = c.Id,
                   Value = c.Name
               }).ToArray();
            cmbCategory.Items.AddRange(listCategories);

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
            Product product = new Product();
            if (cmbCategory.SelectedItem != null)
            {
                var item = (SelectItemElement)cmbCategory.SelectedItem;
                product.CategoryId = Convert.ToInt32(item.Id.ToString());
            }
            else
            {
                MessageBox.Show("Оберіть категорію");
                return;
            }

                product.Name = txtName.Text;

                using (EFContext context = new EFContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }

                MessageBox.Show($"Товар {product.Name} додано");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запису товару\n\t{ex.Message}", ex.Message);
            }
        }
    }
}

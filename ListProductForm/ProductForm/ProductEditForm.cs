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
    public partial class ProductEditForm : Form
    {
        public int Id { get; set; }
        private readonly EFContext _context;

        public ProductEditForm()
        {
            InitializeComponent();
        }

        public ProductEditForm(Product product)
        {
            InitializeComponent();
            txtName.Text = product.Name;
            Id = product.Id;
            _context = new EFContext();
        }

        private void btUpdate_Click(object sender, EventArgs e)
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
                
                product.Id = Id;
                product.Name = txtName.Text;

                // оновлюємо
                using (EFContext context = new EFContext())
                {
                    var result = context.Products.SingleOrDefault(b => b.Id == Id);
                    if (result != null)
                    {
                        result.Id = product.Id;
                        result.Name = product.Name;
                        result.CategoryId = product.CategoryId;
                        context.SaveChanges();
                    }
                }

                MessageBox.Show($"Товар '{product.Name}' оновлено");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення товару\n\t{ex.Message}", ex.Message);
            }
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            var listCategories = _context.Categories
               .Select(c => new SelectItemElement
               {
                   Id = c.Id,
                   Value = c.Name
               }).ToArray();
            cmbCategory.Items.AddRange(listCategories);
        }
    }
}

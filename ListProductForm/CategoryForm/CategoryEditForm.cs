using ListProductForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListProductForm.CategoryForm
{
    public partial class CategoryEditForm : Form
    {
        public int Id { get; set; }
        public CategoryEditForm()
        {
            InitializeComponent();
        }

        public CategoryEditForm(Category category)
        {
            InitializeComponent();
            Id = category.Id;
            txtCategory.Text = category.Name;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Id = Id;
                category.Name = txtCategory.Text;

                // оновлюємо
                using (EFContext context = new EFContext())
                {
                    var result = context.Categories.SingleOrDefault(b => b.Id == Id);
                    if (result != null)
                    {
                        result.Id = category.Id;
                        result.Name = category.Name;
                        context.SaveChanges();
                    }
                }

                MessageBox.Show($"Категорія {category.Name} оновлена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення категорії\n\t{ex.Message}", ex.Message);
            }
        }
    }
}

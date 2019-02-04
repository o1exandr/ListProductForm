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
    public partial class CategoryWorkForm : Form
    {
        private readonly EFContext _context;
        public CategoryWorkForm()
        {
            InitializeComponent();
            _context = new EFContext();
        }

        private void CategoryWorkForm_Load(object sender, EventArgs e)
        {
            dgvCategories.Rows.Clear();
            foreach(var category in _context.Categories)
            {
                string path = @"Images\Category\";

                string name = category.Image;
                if (string.IsNullOrEmpty(name))
                    name = "_default.png";
                Image image = Image.FromFile(path + name);
                object[] row = { category.Id, image, category.Name };
                dgvCategories.Rows.Add(row);
            }

        }

        private void dbInsert_Click(object sender, EventArgs e)
        {
            CategoryAddForm addcategory = new CategoryAddForm();
            addcategory.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategories.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgvCategories.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgvCategories.Rows[selectedrowindex];

                    Category category = new Category();
                    category.Id = Convert.ToInt32(selectedRow.Cells["ColId"].Value);
                    category.Name = Convert.ToString(selectedRow.Cells["ColName"].Value);
                    category.Image = _context.Categories.SqlQuery("");

                    CategoryEditForm editcategory = new CategoryEditForm(category);
                    editcategory.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення категорії\n\t{ex.Message}", ex.Message);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (dgvCategories.SelectedCells.Count > 0)
            {
                // зчитали обраний рядок
                int selectedrowindex = dgvCategories.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvCategories.Rows[selectedrowindex];

                Category category = new Category();
                category.Id = Convert.ToInt32(selectedRow.Cells["ColId"].Value);
                category.Name = Convert.ToString(selectedRow.Cells["ColName"].Value);

                // запитуємо чи точно хочеш користувач видалити
                DialogResult dialogResult = MessageBox.Show($"Ви дійсно хочете видалити товар {category.Name}?", "Видалення товару", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) // якщо так - видаляємо
                {
                    try
                    {
                        using (EFContext context = new EFContext())
                        {
                            var result = context.Categories.SingleOrDefault(b => b.Id == category.Id);
                            if (result != null)
                            {
                                context.Categories.Remove(result);
                                context.SaveChanges();
                            }
                        }

                        MessageBox.Show($"Категорію '{category.Name}' видалено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка видалення категорії {category.Name}\n\t{ex.Message}", ex.Message);
                    }
                    CategoryWorkForm_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // якщо НІ - нічого не робимо
                }
            }
        }
    }
}

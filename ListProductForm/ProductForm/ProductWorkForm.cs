using ListProductForm.Entities;
using ListProductForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        // при завантаженні форми читаємо дані з бази і заливаємо в грід
        private void ProductWorkForm_Load(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
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

        // виклик форми для додавання товару
        private void btInsert_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
        }

        // оновлення товару
        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];

                    Product product = new Product();
                    product.Id = Convert.ToInt32(selectedRow.Cells["ColId"].Value);
                    product.Name = Convert.ToString(selectedRow.Cells["ColName"].Value);

                    ProductEditForm editproduct = new ProductEditForm(product);
                    editproduct.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення товару\n\t{ex.Message}", ex.Message);
            }
        }

        // пошук по всім записам введеного користувачем слова/фрази
        private void btFind_Click(object sender, EventArgs e)
        {
            string strFind = "";
            bool isFind = false;
            for (int i = 0; i < dgvProducts.RowCount - 1; i++)
                for (int j = 0; j < dgvProducts.ColumnCount - 1; j++)
                {
                    if (dgvProducts.Rows[i].Cells[j].Value.ToString().ToLower().Contains(txtFind.Text.ToLower()))
                    {
                        strFind += dgvProducts.Rows[i].Cells[j].Value.ToString() + "\n";
                        isFind = true;
                    }
                }
            if (isFind)
                MessageBox.Show($"{strFind}", $"Знайдено по запиту '{txtFind.Text}'");
            else
                MessageBox.Show($"Не знайдено '{txtFind.Text}'", $"По запиту '{txtFind.Text}'");
        }

        // видалення товару
        private void btDelete_Click(object sender, EventArgs e)
        {

            if (dgvProducts.SelectedCells.Count > 0)
            {
                // зчитали обраний рядок
                int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];

                Product product = new Product();
                product.Id = Convert.ToInt32(selectedRow.Cells["ColId"].Value);
                product.Name = Convert.ToString(selectedRow.Cells["ColName"].Value);

                // запитуємо чи точно хочеш користувач видалити
                DialogResult dialogResult = MessageBox.Show($"Ви дійсно хочете видалити товар {product.Name}?", "Видалення товару", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) // якщо так - видаляємо
                {
                    try
                    {
                        using (EFContext context = new EFContext())
                        {
                            var result = context.Products.SingleOrDefault(b => b.Id == product.Id);
                            if (result != null)
                            {
                                context.Products.Remove(result);
                                context.SaveChanges();
                            }
                        }

                        MessageBox.Show($"Категорію '{product.Name}' видалено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка видалення товару {product.Name}\n\t{ex.Message}", ex.Message);
                    }
                    ProductWorkForm_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // якщо НІ - нічого не робимо
                }
            }
        }
    }
}

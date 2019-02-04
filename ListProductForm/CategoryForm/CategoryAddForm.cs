using ListProductForm.Entities;
using ListProductForm.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListProductForm.CategoryForm
{
    public partial class CategoryAddForm : Form
    {
        private readonly EFContext _context;
        public string NameCategory
        {
            get
            {
                return txtCategory.Text;
            }
        }
        public string ImageCategory
        {
            get
            {
                return txtPath.Text;
            }
        }

        public CategoryAddForm()
        {
            InitializeComponent();
            _context = new EFContext();
        }

        // додаємо категорію в Категорії
        private void btInsert_Click(object sender, EventArgs e)
        {
            /*
            Category category = new Category();
            category.Name = txtCategory.Text;
            try
            {
                using (EFContext context = new EFContext())
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                }

                MessageBox.Show($"Категорію {category.Name} додано");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запису категорії\n\t{ex.Message}", ex.Message);
            }
            */

            //CategoryAddForm dlg = new CategoryAddForm();
           // if (dlg.ShowDialog() == DialogResult.OK)
            {
                var imageClientPath = txtPath.Text;
                string path = @"Images\Category\";
                var imageName = Guid.NewGuid().ToString() + ".jpg";
                using (Bitmap bitmap = new Bitmap(imageClientPath))
                {
                    var smallImage = ImageWorker.CreateImage(bitmap, 64, 64);
                    smallImage.Save(path + imageName, ImageFormat.Jpeg);
                }
                Category category = new Category
                {
                    Name = txtCategory.Text,
                    Image = imageName
                };
                _context.Categories.Add(category);
                _context.SaveChanges();
            }

        }

        private void CategoryAddForm_Load(object sender, EventArgs e)
        {
            try
            {
                string path = @"Images\Category\_default.png";
                pbImage.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження малюнка\n\t{ex.Message}", ex.Message);
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) " +
                "| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
                pbImage.Image = Image.FromFile(txtPath.Text);
            }
        }
    }
}

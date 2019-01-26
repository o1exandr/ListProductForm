using ListProductForm.CategoryForm;
using ListProductForm.ProductForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListProductForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void hmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryWorkForm dlg = new CategoryWorkForm();
            dlg.ShowDialog();
        }

        private void hmProducts_Click(object sender, EventArgs e)
        {
            ProductWorkForm dlg = new ProductWorkForm();
            dlg.ShowDialog();
        }
    }
}

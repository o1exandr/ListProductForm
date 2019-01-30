namespace ListProductForm.ProductForm
{
    partial class ProductWorkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInsert = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColCategory});
            this.dgvProducts.Location = new System.Drawing.Point(11, 78);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(520, 277);
            this.dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Назва";
            this.ColName.Name = "ColName";
            // 
            // ColCategory
            // 
            this.ColCategory.HeaderText = "Категорія";
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.Width = 200;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(119, 12);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(98, 23);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "&Додати товар";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(13, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(100, 23);
            this.btRead.TabIndex = 2;
            this.btRead.Text = "&Оновити";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.ProductWorkForm_Load);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(224, 12);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(106, 23);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "&Редагувати товар";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(337, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(107, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "&Видалити товар";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Location = new System.Drawing.Point(18, 45);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(40, 13);
            this.lbFind.TabIndex = 5;
            this.lbFind.Text = "Пошук";
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(68, 42);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(458, 20);
            this.txtFind.TabIndex = 6;
            // 
            // ProductWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 366);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lbFind);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.dgvProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Робота з продуктами";
            this.Load += new System.EventHandler(this.ProductWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.TextBox txtFind;
    }
}
namespace ListProductForm.CategoryForm
{
    partial class CategoryWorkForm
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
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRead = new System.Windows.Forms.Button();
            this.dbInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName});
            this.dgvCategories.Location = new System.Drawing.Point(7, 56);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(578, 279);
            this.dgvCategories.TabIndex = 0;
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
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(13, 13);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(140, 23);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Читати категорії";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.CategoryWorkForm_Load);
            // 
            // dbInsert
            // 
            this.dbInsert.Location = new System.Drawing.Point(160, 13);
            this.dbInsert.Name = "dbInsert";
            this.dbInsert.Size = new System.Drawing.Size(139, 23);
            this.dbInsert.TabIndex = 2;
            this.dbInsert.Text = "Додати категорію";
            this.dbInsert.UseVisualStyleBackColor = true;
            this.dbInsert.Click += new System.EventHandler(this.dbInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(307, 13);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(137, 23);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Редагувати категорію";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(451, 13);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(134, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Видалити категорію";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // CategoryWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 346);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dbInsert);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.dgvCategories);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoryWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список категорій";
            this.Activated += new System.EventHandler(this.CategoryWorkForm_Load);
            this.Load += new System.EventHandler(this.CategoryWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button dbInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}
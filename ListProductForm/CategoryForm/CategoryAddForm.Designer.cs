namespace ListProductForm.CategoryForm
{
    partial class CategoryAddForm
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
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(17, 19);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(87, 13);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Нова категорія:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(110, 16);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(366, 20);
            this.txtCategory.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(402, 58);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(321, 58);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Додати";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // CategoryAddForm
            // 
            this.AcceptButton = this.btInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(488, 102);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lbCategory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(504, 140);
            this.Name = "CategoryAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати категорію";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btInsert;
    }
}
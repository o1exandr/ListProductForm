namespace ListProductForm.CategoryForm
{
    partial class CategoryEditForm
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
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(318, 61);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Редагувати";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(399, 61);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(138, 19);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(335, 20);
            this.txtCategory.TabIndex = 4;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(14, 22);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(118, 13);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Редагувати категорію";
            // 
            // CategoryEditForm
            // 
            this.AcceptButton = this.btUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(488, 102);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lbCategory);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(504, 140);
            this.Name = "CategoryEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати категорію";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lbCategory;
    }
}
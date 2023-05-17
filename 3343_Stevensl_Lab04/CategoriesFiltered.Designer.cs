namespace _3343_Stevensl_Lab04
{
    partial class categoriesF
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
            this.components = new System.ComponentModel.Container();
            this.close_Button4 = new System.Windows.Forms.Button();
            this.listBoxF = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDataSet = new _3343_Stevensl_Lab04.CategoriesDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new _3343_Stevensl_Lab04.CategoriesDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new _3343_Stevensl_Lab04.CategoriesDataSetTableAdapters.TableAdapterManager();
            this.comboBoxF = new System.Windows.Forms.ComboBox();
            this.categoriesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new _3343_Stevensl_Lab04.CategoriesDataSetTableAdapters.CategoryTableAdapter();
            this.categoryProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // close_Button4
            // 
            this.close_Button4.Location = new System.Drawing.Point(175, 193);
            this.close_Button4.Name = "close_Button4";
            this.close_Button4.Size = new System.Drawing.Size(75, 23);
            this.close_Button4.TabIndex = 9;
            this.close_Button4.Text = "Cl&ose";
            this.close_Button4.UseVisualStyleBackColor = true;
            this.close_Button4.Click += new System.EventHandler(this.close_Button4_Click);
            // 
            // listBoxF
            // 
            this.listBoxF.DataSource = this.categoryProductsBindingSource;
            this.listBoxF.DisplayMember = "Product ID";
            this.listBoxF.FormattingEnabled = true;
            this.listBoxF.Location = new System.Drawing.Point(83, 66);
            this.listBoxF.Name = "listBoxF";
            this.listBoxF.Size = new System.Drawing.Size(167, 121);
            this.listBoxF.TabIndex = 8;
            this.listBoxF.ValueMember = "Product ID";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Products";
            this.bindingSource1.DataSource = this.categoriesDataSet;
            // 
            // categoriesDataSet
            // 
            this.categoriesDataSet.DataSetName = "CategoriesDataSet";
            this.categoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Products:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categories:";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         
            this.tableAdapterManager.Connection = null;
 
            this.tableAdapterManager.UpdateOrder = _3343_Stevensl_Lab04.CategoriesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBoxF
            // 
            this.comboBoxF.DataSource = this.categoryBindingSource;
            this.comboBoxF.DisplayMember = "Category_Name";
            this.comboBoxF.FormattingEnabled = true;
            this.comboBoxF.Location = new System.Drawing.Point(84, 22);
            this.comboBoxF.Name = "comboBoxF";
            this.comboBoxF.Size = new System.Drawing.Size(121, 21);
            this.comboBoxF.TabIndex = 10;
            this.comboBoxF.ValueMember = "Category_ID";
            this.comboBoxF.SelectionChangeCommitted += new System.EventHandler(this.comboBoxF_SelectionChangeCommitted_1);
            // 
            // categoriesDataSetBindingSource
            // 
            this.categoriesDataSetBindingSource.DataSource = this.categoriesDataSet;
            this.categoriesDataSetBindingSource.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.categoriesDataSetBindingSource;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryProductsBindingSource
            // 
            this.categoryProductsBindingSource.DataMember = "Category_Products";
            this.categoryProductsBindingSource.DataSource = this.categoryBindingSource;
            // 
            // categoriesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 255);
            this.Controls.Add(this.comboBoxF);
            this.Controls.Add(this.close_Button4);
            this.Controls.Add(this.listBoxF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "categoriesF";
            this.Text = "Catergories Products (Filtering)";
            this.Load += new System.EventHandler(this.categoriesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_Button4;
        private System.Windows.Forms.ListBox listBoxF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CategoriesDataSet categoriesDataSet;
        private CategoriesDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private CategoriesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxF;
        private System.Windows.Forms.BindingSource categoriesDataSetBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CategoriesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;

        private System.Windows.Forms.BindingSource categoryProductsBindingSource;
    }
}
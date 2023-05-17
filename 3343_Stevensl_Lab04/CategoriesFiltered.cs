using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3343_Stevensl_Lab04
{
    public partial class categoriesF : Form
    {
        public categoriesF()
        {
            InitializeComponent();
        }

        private void categoriesF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.categoriesDataSet.Category);
            CategoriesDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
            productsTableAdapter = new CategoriesDataSetTableAdapters.ProductsTableAdapter();
            productsTableAdapter.Fill(categoriesDataSet.Products);
        }

        private void comboBoxF_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            string selectionString;
            selectionString = comboBoxF.SelectedValue.ToString();
            bindingSource1.DataMember = "Products";
            bindingSource1.Filter = " Category_ID = '" + selectionString + "'";
            bindingSource1.Sort = "Category_ID";
            listBoxF.DataSource = bindingSource1;
            listBoxF.DisplayMember = "Product_ID";
        }

        private void close_Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

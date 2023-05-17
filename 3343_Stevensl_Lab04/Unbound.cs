using _3343_Stevensl_Lab04.CategoriesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _3343_Stevensl_Lab04
{
    public partial class categoriesU : Form
    {
        public categoriesU()
        {
            InitializeComponent();
        }

        private void categoriesU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriesDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.categoriesDataSet.Category);
            CategoriesDataSetTableAdapters.ProductsTableAdapter ProductTableAdapter;
            ProductTableAdapter = new CategoriesDataSetTableAdapters.ProductsTableAdapter();
            ProductTableAdapter.Fill(categoriesDataSet.Products);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            short ID; 
            DataRow catDataRow;
            DataRow[] productDataRows;
            ID = Convert.ToInt16(comboBox1.SelectedValue); 
            catDataRow = this.categoriesDataSet.Category.FindByCategory_ID(ID);
            productDataRows = catDataRow.GetChildRows("Category_Products");
            listBoxU.Items.Clear();
            foreach( DataRow aCatDataRow in productDataRows)
                listBoxU.Items.Add(aCatDataRow["Product ID"].ToString());

        }

        private void close_Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

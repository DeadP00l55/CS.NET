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
    public partial class northwind_Selection : Form
    {
        public northwind_Selection()
        {
            InitializeComponent();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            customer_Orders Order = new customer_Orders();
            Order.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriesButtonf_Click(object sender, EventArgs e)
        {
            categoriesF catF = new categoriesF();
            catF.ShowDialog();

        }

        private void categoriesButtonu_Click(object sender, EventArgs e)
        {
            categoriesU catU = new categoriesU();
            catU.ShowDialog();
        }

        private void territoryButton_Click(object sender, EventArgs e)
        {
            employee_Territory Ter = new employee_Territory();
            Ter.ShowDialog();
        }
    }
}

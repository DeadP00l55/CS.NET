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
    public partial class customer_Orders : Form
    {
        public customer_Orders()
        {
            InitializeComponent();
        }

        private void customer_Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSetP.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter1.Fill(this.northwindDataSetP.Order);
            // TODO: This line of code loads data into the 'northwindDataSetP.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter1.Fill(this.northwindDataSetP.Company);
        }

        private void CloseBttn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


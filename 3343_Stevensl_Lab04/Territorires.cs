using _3343_Stevensl_Lab04.NorthwindDataSetTableAdapters;
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
    public partial class employee_Territory : Form
    {
        private NorthwindDataSetR aNorthwindDataSet = new NorthwindDataSetR();
        public employee_Territory()
        {
            InitializeComponent();
        }

        private void employee_Territory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSetR.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter1.Fill(this.northwindDataSetR.Company);
            NorthwindDataSetRTableAdapters.CompanyTableAdapter aCompanyTableAdapter;
            NorthwindDataSetRTableAdapters.TerritoriesTableAdapter aTerritoriesTableAdapter;
            aCompanyTableAdapter = new NorthwindDataSetRTableAdapters.CompanyTableAdapter();
            aTerritoriesTableAdapter = new NorthwindDataSetRTableAdapters.TerritoriesTableAdapter();
           

  

            aCompanyTableAdapter.Fill(aNorthwindDataSet.Company);
            aTerritoriesTableAdapter.Fill(aNorthwindDataSet.Territories);
            

        

            comboBoxT.DataSource = aNorthwindDataSet.Company;
            comboBoxT.DisplayMember = "Contact_Name";
            comboBoxT.ValueMember = "Customer_ID";
            comboBoxT.SelectedIndex = -1;
        }

        private void comboBoxT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ContactID;
            string Territory = "";
            List<String> Ter = new List<String>();

            DataRow ContactDataRow;
            DataRow[] TerritoryDataRows;
            ContactID = comboBoxT.SelectedValue.ToString();
            ContactDataRow = aNorthwindDataSet.Company.FindByCustomer_ID(ContactID);
            TerritoryDataRows = ContactDataRow.GetChildRows("Company_Territories");
            foreach (DataRow CustomerDataRow in TerritoryDataRows)
            {
                Territory = CustomerDataRow["T_Name"].ToString(); 
                Ter.Add(Territory);
            }
            listBoxT.Items.Clear();
            foreach (string A in Ter)
                listBoxT.Items.Add(A);
        }
    }
}


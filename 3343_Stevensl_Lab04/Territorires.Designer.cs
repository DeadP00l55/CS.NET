namespace _3343_Stevensl_Lab04
{
    partial class employee_Territory
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
            this.listBoxT = new System.Windows.Forms.ListBox();
            this.comboBoxT = new System.Windows.Forms.ComboBox();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new _3343_Stevensl_Lab04.NorthwindDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new _3343_Stevensl_Lab04.NorthwindDataSetTableAdapters.CompanyTableAdapter();
            this.territoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesTableAdapter = new _3343_Stevensl_Lab04.NorthwindDataSetTableAdapters.TerritoriesTableAdapter();
            this.northwindDataSetR = new _3343_Stevensl_Lab04.NorthwindDataSetR();
            this.companyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter1 = new _3343_Stevensl_Lab04.NorthwindDataSetRTableAdapters.CompanyTableAdapter();
            this.northwindDataSetRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // close_Button4
            // 
            this.close_Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_Button4.Location = new System.Drawing.Point(192, 177);
            this.close_Button4.Name = "close_Button4";
            this.close_Button4.Size = new System.Drawing.Size(75, 23);
            this.close_Button4.TabIndex = 14;
            this.close_Button4.Text = "Cl&ose";
            this.close_Button4.UseVisualStyleBackColor = true;
            // 
            // listBoxT
            // 
            this.listBoxT.FormattingEnabled = true;
            this.listBoxT.Location = new System.Drawing.Point(100, 50);
            this.listBoxT.Name = "listBoxT";
            this.listBoxT.Size = new System.Drawing.Size(167, 121);
            this.listBoxT.TabIndex = 13;
            // 
            // comboBoxT
            // 
            this.comboBoxT.DataSource = this.companyBindingSource4;
            this.comboBoxT.DisplayMember = "Contact_Name";
            this.comboBoxT.FormattingEnabled = true;
            this.comboBoxT.Location = new System.Drawing.Point(100, 12);
            this.comboBoxT.Name = "comboBoxT";
            this.comboBoxT.Size = new System.Drawing.Size(167, 21);
            this.comboBoxT.TabIndex = 12;
            this.comboBoxT.ValueMember = "Customer_ID";
            this.comboBoxT.SelectionChangeCommitted += new System.EventHandler(this.comboBoxT_SelectionChangeCommitted);
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.northwindDataSetBindingSource;
            // 
            // northwindDataSetBindingSource
            // 
            this.northwindDataSetBindingSource.DataSource = this.northwindDataSet;
            this.northwindDataSetBindingSource.Position = 0;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Territories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employee Name:";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.northwindDataSet;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // territoriesBindingSource
            // 
            this.territoriesBindingSource.DataMember = "Territories";
            this.territoriesBindingSource.DataSource = this.northwindDataSet;
            // 
            // territoriesTableAdapter
            // 
            this.territoriesTableAdapter.ClearBeforeFill = true;
            // 
            // northwindDataSetR
            // 
            this.northwindDataSetR.DataSetName = "NorthwindDataSetR";
            this.northwindDataSetR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource2
            // 
            this.companyBindingSource2.DataMember = "Company";
            this.companyBindingSource2.DataSource = this.northwindDataSetR;
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // northwindDataSetRBindingSource
            // 
            this.northwindDataSetRBindingSource.DataSource = this.northwindDataSetR;
            this.northwindDataSetRBindingSource.Position = 0;
            // 
            // companyBindingSource3
            // 
            this.companyBindingSource3.DataMember = "Company";
            this.companyBindingSource3.DataSource = this.northwindDataSetRBindingSource;
            // 
            // companyBindingSource4
            // 
            this.companyBindingSource4.DataMember = "Company";
            this.companyBindingSource4.DataSource = this.northwindDataSetRBindingSource;
            // 
            // employee_Territory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close_Button4;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.close_Button4);
            this.Controls.Add(this.listBoxT);
            this.Controls.Add(this.comboBoxT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "employee_Territory";
            this.Text = "Employee Territories";
            this.Load += new System.EventHandler(this.employee_Territory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_Button4;
        private System.Windows.Forms.ListBox listBoxT;
        private System.Windows.Forms.ComboBox comboBoxT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private NorthwindDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource territoriesBindingSource;
        private NorthwindDataSetTableAdapters.TerritoriesTableAdapter territoriesTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.BindingSource northwindDataSetBindingSource;
        private NorthwindDataSetR northwindDataSetR;
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private NorthwindDataSetRTableAdapters.CompanyTableAdapter companyTableAdapter1;
        private System.Windows.Forms.BindingSource companyBindingSource4;
        private System.Windows.Forms.BindingSource northwindDataSetRBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource3;
    }
}
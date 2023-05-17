namespace _3343_Stevensl_Lab04
{
    partial class northwind_Selection
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
            this.customButton = new System.Windows.Forms.Button();
            this.categoriesButtonf = new System.Windows.Forms.Button();
            this.territoryButton = new System.Windows.Forms.Button();
            this.categoriesButtonu = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(44, 35);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(100, 55);
            this.customButton.TabIndex = 0;
            this.customButton.Text = "Custom &Orders (Master/Detail)";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // categoriesButtonf
            // 
            this.categoriesButtonf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoriesButtonf.Location = new System.Drawing.Point(211, 35);
            this.categoriesButtonf.Name = "categoriesButtonf";
            this.categoriesButtonf.Size = new System.Drawing.Size(108, 55);
            this.categoriesButtonf.TabIndex = 1;
            this.categoriesButtonf.Text = "Catagories &Products (Filtering)";
            this.categoriesButtonf.UseVisualStyleBackColor = true;
            this.categoriesButtonf.Click += new System.EventHandler(this.categoriesButtonf_Click);
            // 
            // territoryButton
            // 
            this.territoryButton.Location = new System.Drawing.Point(211, 134);
            this.territoryButton.Name = "territoryButton";
            this.territoryButton.Size = new System.Drawing.Size(108, 56);
            this.territoryButton.TabIndex = 2;
            this.territoryButton.Text = "Employee &Territories (Many-To-Many)";
            this.territoryButton.UseVisualStyleBackColor = true;
            this.territoryButton.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // categoriesButtonu
            // 
            this.categoriesButtonu.Location = new System.Drawing.Point(44, 134);
            this.categoriesButtonu.Name = "categoriesButtonu";
            this.categoriesButtonu.Size = new System.Drawing.Size(100, 56);
            this.categoriesButtonu.TabIndex = 3;
            this.categoriesButtonu.Text = "&Catagories Products (Unbound)";
            this.categoriesButtonu.UseVisualStyleBackColor = true;
            this.categoriesButtonu.Click += new System.EventHandler(this.categoriesButtonu_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(244, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // northwind_Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(370, 248);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.categoriesButtonu);
            this.Controls.Add(this.territoryButton);
            this.Controls.Add(this.categoriesButtonf);
            this.Controls.Add(this.customButton);
            this.Name = "northwind_Selection";
            this.Text = "Northwind Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Button categoriesButtonf;
        private System.Windows.Forms.Button territoryButton;
        private System.Windows.Forms.Button categoriesButtonu;
        private System.Windows.Forms.Button exitButton;
    }
}


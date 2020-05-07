namespace WindowsFormsApp1
{
    partial class SearchCustomers
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
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.searchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.searchCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Location = new System.Drawing.Point(33, 47);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(117, 17);
            this.searchCustomerLabel.TabIndex = 0;
            this.searchCustomerLabel.Text = "Search Customer";
            // 
            // searchCustomerTextBox
            // 
            this.searchCustomerTextBox.Location = new System.Drawing.Point(204, 44);
            this.searchCustomerTextBox.Name = "searchCustomerTextBox";
            this.searchCustomerTextBox.Size = new System.Drawing.Size(212, 22);
            this.searchCustomerTextBox.TabIndex = 1;
            // 
            // searchCustomer
            // 
            this.searchCustomer.Location = new System.Drawing.Point(511, 47);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Size = new System.Drawing.Size(172, 23);
            this.searchCustomer.TabIndex = 2;
            this.searchCustomer.Text = "Search";
            this.searchCustomer.UseVisualStyleBackColor = true;
            this.searchCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // SearchCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchCustomer);
            this.Controls.Add(this.searchCustomerTextBox);
            this.Controls.Add(this.searchCustomerLabel);
            this.Name = "SearchCustomers";
            this.Text = "SearchCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchCustomerLabel;
        private System.Windows.Forms.TextBox searchCustomerTextBox;
        private System.Windows.Forms.Button searchCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
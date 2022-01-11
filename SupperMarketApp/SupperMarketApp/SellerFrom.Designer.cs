namespace SupperMarketApp
{
    partial class SellerFrom
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
            this.dgvSellerManage = new System.Windows.Forms.DataGridView();
            this.sellerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supperMarketSystemDataSet = new SupperMarketApp.SupperMarketSystemDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSellerPhone = new System.Windows.Forms.TextBox();
            this.txtSellerAge = new System.Windows.Forms.TextBox();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSellerPassword = new System.Windows.Forms.TextBox();
            this.sellerDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerDetailTableAdapter = new SupperMarketApp.SupperMarketSystemDataSetTableAdapters.SellerDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSellerManage
            // 
            this.dgvSellerManage.AllowUserToAddRows = false;
            this.dgvSellerManage.AutoGenerateColumns = false;
            this.dgvSellerManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellerManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerIdDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.sellerAgeDataGridViewTextBoxColumn,
            this.sellerPhoneDataGridViewTextBoxColumn,
            this.sellerPasswordDataGridViewTextBoxColumn});
            this.dgvSellerManage.DataSource = this.sellerDetailBindingSource1;
            this.dgvSellerManage.Location = new System.Drawing.Point(369, 124);
            this.dgvSellerManage.Name = "dgvSellerManage";
            this.dgvSellerManage.RowTemplate.Height = 24;
            this.dgvSellerManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSellerManage.Size = new System.Drawing.Size(729, 583);
            this.dgvSellerManage.TabIndex = 21;
            this.dgvSellerManage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellerManage_CellContentClick);
            // 
            // sellerIdDataGridViewTextBoxColumn
            // 
            this.sellerIdDataGridViewTextBoxColumn.DataPropertyName = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.HeaderText = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.Name = "sellerIdDataGridViewTextBoxColumn";
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            // 
            // sellerAgeDataGridViewTextBoxColumn
            // 
            this.sellerAgeDataGridViewTextBoxColumn.DataPropertyName = "SellerAge";
            this.sellerAgeDataGridViewTextBoxColumn.HeaderText = "SellerAge";
            this.sellerAgeDataGridViewTextBoxColumn.Name = "sellerAgeDataGridViewTextBoxColumn";
            // 
            // sellerPhoneDataGridViewTextBoxColumn
            // 
            this.sellerPhoneDataGridViewTextBoxColumn.DataPropertyName = "SellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.HeaderText = "SellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.Name = "sellerPhoneDataGridViewTextBoxColumn";
            // 
            // sellerPasswordDataGridViewTextBoxColumn
            // 
            this.sellerPasswordDataGridViewTextBoxColumn.DataPropertyName = "SellerPassword";
            this.sellerPasswordDataGridViewTextBoxColumn.HeaderText = "SellerPassword";
            this.sellerPasswordDataGridViewTextBoxColumn.Name = "sellerPasswordDataGridViewTextBoxColumn";
            // 
            // sellerDetailBindingSource1
            // 
            this.sellerDetailBindingSource1.DataMember = "SellerDetail";
            this.sellerDetailBindingSource1.DataSource = this.supperMarketSystemDataSet;
            // 
            // supperMarketSystemDataSet
            // 
            this.supperMarketSystemDataSet.DataSetName = "SupperMarketSystemDataSet";
            this.supperMarketSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(222, 430);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 42);
            this.button7.TabIndex = 20;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(131, 430);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 42);
            this.button6.TabIndex = 19;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(41, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSellerPhone
            // 
            this.txtSellerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerPhone.Location = new System.Drawing.Point(138, 301);
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.Size = new System.Drawing.Size(177, 28);
            this.txtSellerPhone.TabIndex = 9;
            // 
            // txtSellerAge
            // 
            this.txtSellerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerAge.Location = new System.Drawing.Point(138, 259);
            this.txtSellerAge.Name = "txtSellerAge";
            this.txtSellerAge.Size = new System.Drawing.Size(177, 28);
            this.txtSellerAge.TabIndex = 8;
            // 
            // txtSellerName
            // 
            this.txtSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerName.Location = new System.Drawing.Point(138, 204);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(177, 28);
            this.txtSellerName.TabIndex = 7;
            // 
            // txtSellerId
            // 
            this.txtSellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerId.Location = new System.Drawing.Point(138, 158);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(177, 28);
            this.txtSellerId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(515, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Seller";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(1315, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(6, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(6, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Catagory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(6, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtSellerPassword);
            this.panel1.Controls.Add(this.dgvSellerManage);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtSellerPhone);
            this.panel1.Controls.Add(this.txtSellerAge);
            this.panel1.Controls.Add(this.txtSellerName);
            this.panel1.Controls.Add(this.txtSellerId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 736);
            this.panel1.TabIndex = 5;
            // 
            // txtSellerPassword
            // 
            this.txtSellerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerPassword.Location = new System.Drawing.Point(138, 348);
            this.txtSellerPassword.Name = "txtSellerPassword";
            this.txtSellerPassword.Size = new System.Drawing.Size(177, 28);
            this.txtSellerPassword.TabIndex = 22;
            // 
            // sellerDetailBindingSource
            // 
            this.sellerDetailBindingSource.DataMember = "SellerDetail";
            this.sellerDetailBindingSource.DataSource = this.supperMarketSystemDataSet;
            // 
            // sellerDetailTableAdapter
            // 
            this.sellerDetailTableAdapter.ClearBeforeFill = true;
            // 
            // SellerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 805);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerFrom";
            this.Load += new System.EventHandler(this.SellerFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellerManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSellerManage;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSellerPhone;
        private System.Windows.Forms.TextBox txtSellerAge;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.TextBox txtSellerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSellerPassword;
        private SupperMarketSystemDataSet supperMarketSystemDataSet;
        private System.Windows.Forms.BindingSource sellerDetailBindingSource;
        private SupperMarketSystemDataSetTableAdapters.SellerDetailTableAdapter sellerDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sellerDetailBindingSource1;
    }
}
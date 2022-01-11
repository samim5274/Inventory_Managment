namespace SupperMarketApp
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSeller = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supperMarketSystemDataSet1 = new SupperMarketApp.SupperMarketSystemDataSet1();
            this.lbDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductInvoice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supperMarketSystemDataSet = new SupperMarketApp.SupperMarketSystemDataSet();
            this.supperMarketSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billDetailTableAdapter = new SupperMarketApp.SupperMarketSystemDataSet1TableAdapters.BillDetailTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvOrder);
            this.panel1.Controls.Add(this.lbAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbSeller);
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtProductQuantity);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductInvoice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(202, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 736);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(561, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 39);
            this.label8.TabIndex = 32;
            this.label8.Text = "Selle List";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.PName,
            this.PPrice,
            this.PQuantity,
            this.PTotal});
            this.dgvOrder.Location = new System.Drawing.Point(397, 79);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(715, 217);
            this.dgvOrder.TabIndex = 31;
            // 
            // PId
            // 
            this.PId.HeaderText = "Id";
            this.PId.Name = "PId";
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "Price";
            this.PPrice.Name = "PPrice";
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "Quantity";
            this.PQuantity.Name = "PQuantity";
            // 
            // PTotal
            // 
            this.PTotal.HeaderText = "Total";
            this.PTotal.Name = "PTotal";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.White;
            this.lbAmount.Location = new System.Drawing.Point(873, 329);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(51, 25);
            this.lbAmount.TabIndex = 30;
            this.lbAmount.Text = "00/-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(719, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Amount";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(106, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSeller
            // 
            this.lbSeller.AutoSize = true;
            this.lbSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeller.ForeColor = System.Drawing.Color.White;
            this.lbSeller.Location = new System.Drawing.Point(83, 24);
            this.lbSeller.Name = "lbSeller";
            this.lbSeller.Size = new System.Drawing.Size(124, 25);
            this.lbSeller.TabIndex = 27;
            this.lbSeller.Text = "SellerName";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AutoGenerateColumns = false;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dgvBill.DataSource = this.billDetailBindingSource;
            this.dgvBill.Location = new System.Drawing.Point(397, 411);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(715, 232);
            this.dgvBill.TabIndex = 26;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            // 
            // billDateDataGridViewTextBoxColumn
            // 
            this.billDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate";
            this.billDateDataGridViewTextBoxColumn.HeaderText = "BillDate";
            this.billDateDataGridViewTextBoxColumn.Name = "billDateDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // billDetailBindingSource
            // 
            this.billDetailBindingSource.DataMember = "BillDetail";
            this.billDetailBindingSource.DataSource = this.supperMarketSystemDataSet1;
            // 
            // supperMarketSystemDataSet1
            // 
            this.supperMarketSystemDataSet1.DataSetName = "SupperMarketSystemDataSet1";
            this.supperMarketSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(968, 24);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 25);
            this.lbDate.TabIndex = 25;
            this.lbDate.Text = "Date";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox1.Location = new System.Drawing.Point(28, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 31);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Select Catagory";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(211, 308);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 38);
            this.button8.TabIndex = 23;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(28, 364);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(303, 342);
            this.dgvProduct.TabIndex = 21;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(580, 664);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 42);
            this.button7.TabIndex = 20;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(489, 664);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 42);
            this.button6.TabIndex = 19;
            this.button6.Text = "Print";
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
            this.button4.Location = new System.Drawing.Point(397, 664);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Century", 12F);
            this.txtProductQuantity.Location = new System.Drawing.Point(168, 202);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(190, 32);
            this.txtProductQuantity.TabIndex = 9;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Enabled = false;
            this.txtProductPrice.Font = new System.Drawing.Font("Century", 12F);
            this.txtProductPrice.Location = new System.Drawing.Point(168, 156);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(190, 32);
            this.txtProductPrice.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Century", 12F);
            this.txtProductName.Location = new System.Drawing.Point(168, 111);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(190, 32);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductInvoice
            // 
            this.txtProductInvoice.Font = new System.Drawing.Font("Century", 12F);
            this.txtProductInvoice.Location = new System.Drawing.Point(168, 69);
            this.txtProductInvoice.Name = "txtProductInvoice";
            this.txtProductInvoice.Size = new System.Drawing.Size(190, 32);
            this.txtProductInvoice.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(561, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling";
            // 
            // supperMarketSystemDataSet
            // 
            this.supperMarketSystemDataSet.DataSetName = "SupperMarketSystemDataSet";
            this.supperMarketSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supperMarketSystemDataSetBindingSource
            // 
            this.supperMarketSystemDataSetBindingSource.DataSource = this.supperMarketSystemDataSet;
            this.supperMarketSystemDataSetBindingSource.Position = 0;
            // 
            // billDetailTableAdapter
            // 
            this.billDetailTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 754);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Log Out";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 805);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotal;
        private SupperMarketSystemDataSet supperMarketSystemDataSet;
        private System.Windows.Forms.BindingSource supperMarketSystemDataSetBindingSource;
        private SupperMarketSystemDataSet1 supperMarketSystemDataSet1;
        private System.Windows.Forms.BindingSource billDetailBindingSource;
        private SupperMarketSystemDataSet1TableAdapters.BillDetailTableAdapter billDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label7;
    }
}
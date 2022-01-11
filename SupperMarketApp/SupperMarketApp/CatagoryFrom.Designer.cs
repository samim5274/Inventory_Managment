namespace SupperMarketApp
{
    partial class CatagoryFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCatagory = new System.Windows.Forms.DataGridView();
            this.catIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catDiscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supperMarketSystemDataSet = new SupperMarketApp.SupperMarketSystemDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCatagoryDiscription = new System.Windows.Forms.TextBox();
            this.txtCatagoryName = new System.Windows.Forms.TextBox();
            this.txtCatagoryId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.catagoryDetailTableAdapter = new SupperMarketApp.SupperMarketSystemDataSetTableAdapters.CatagoryDetailTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.button5.TabIndex = 13;
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
            this.button3.TabIndex = 12;
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
            this.button2.TabIndex = 11;
            this.button2.Text = "Product";
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
            this.button1.TabIndex = 9;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.dgvCatagory);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtCatagoryDiscription);
            this.panel1.Controls.Add(this.txtCatagoryName);
            this.panel1.Controls.Add(this.txtCatagoryId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 736);
            this.panel1.TabIndex = 10;
            // 
            // dgvCatagory
            // 
            this.dgvCatagory.AllowUserToAddRows = false;
            this.dgvCatagory.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatagory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatagory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIdDataGridViewTextBoxColumn,
            this.catNameDataGridViewTextBoxColumn,
            this.catDiscriptionDataGridViewTextBoxColumn});
            this.dgvCatagory.DataSource = this.catagoryDetailBindingSource;
            this.dgvCatagory.Location = new System.Drawing.Point(369, 154);
            this.dgvCatagory.Name = "dgvCatagory";
            this.dgvCatagory.RowTemplate.Height = 24;
            this.dgvCatagory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatagory.Size = new System.Drawing.Size(725, 553);
            this.dgvCatagory.TabIndex = 21;
            this.dgvCatagory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatagory_CellContentClick);
            this.dgvCatagory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCatagory_CellMouseDoubleClick);
            // 
            // catIdDataGridViewTextBoxColumn
            // 
            this.catIdDataGridViewTextBoxColumn.DataPropertyName = "CatId";
            this.catIdDataGridViewTextBoxColumn.HeaderText = "CatId";
            this.catIdDataGridViewTextBoxColumn.Name = "catIdDataGridViewTextBoxColumn";
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            this.catNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catNameDataGridViewTextBoxColumn.DataPropertyName = "CatName";
            this.catNameDataGridViewTextBoxColumn.HeaderText = "CatName";
            this.catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            // 
            // catDiscriptionDataGridViewTextBoxColumn
            // 
            this.catDiscriptionDataGridViewTextBoxColumn.DataPropertyName = "CatDiscription";
            this.catDiscriptionDataGridViewTextBoxColumn.HeaderText = "CatDiscription";
            this.catDiscriptionDataGridViewTextBoxColumn.Name = "catDiscriptionDataGridViewTextBoxColumn";
            // 
            // catagoryDetailBindingSource
            // 
            this.catagoryDetailBindingSource.DataMember = "CatagoryDetail";
            this.catagoryDetailBindingSource.DataSource = this.supperMarketSystemDataSet;
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
            this.button7.Location = new System.Drawing.Point(229, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 42);
            this.button7.TabIndex = 6;
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
            this.button6.Location = new System.Drawing.Point(138, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 42);
            this.button6.TabIndex = 5;
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
            this.button4.Location = new System.Drawing.Point(48, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCatagoryDiscription
            // 
            this.txtCatagoryDiscription.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryDiscription.Location = new System.Drawing.Point(138, 284);
            this.txtCatagoryDiscription.Name = "txtCatagoryDiscription";
            this.txtCatagoryDiscription.Size = new System.Drawing.Size(177, 32);
            this.txtCatagoryDiscription.TabIndex = 3;
            // 
            // txtCatagoryName
            // 
            this.txtCatagoryName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryName.Location = new System.Drawing.Point(138, 229);
            this.txtCatagoryName.Name = "txtCatagoryName";
            this.txtCatagoryName.Size = new System.Drawing.Size(177, 32);
            this.txtCatagoryName.TabIndex = 2;
            // 
            // txtCatagoryId
            // 
            this.txtCatagoryId.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatagoryId.Location = new System.Drawing.Point(138, 179);
            this.txtCatagoryId.Name = "txtCatagoryId";
            this.txtCatagoryId.Size = new System.Drawing.Size(177, 32);
            this.txtCatagoryId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 229);
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
            this.label4.Location = new System.Drawing.Point(5, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 186);
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
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Catagory";
            // 
            // catagoryDetailTableAdapter
            // 
            this.catagoryDetailTableAdapter.ClearBeforeFill = true;
            // 
            // CatagoryFrom
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
            this.Name = "CatagoryFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatagoryFrom";
            this.Load += new System.EventHandler(this.CatagoryFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supperMarketSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCatagory;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCatagoryDiscription;
        private System.Windows.Forms.TextBox txtCatagoryName;
        private System.Windows.Forms.TextBox txtCatagoryId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SupperMarketSystemDataSet supperMarketSystemDataSet;
        private System.Windows.Forms.BindingSource catagoryDetailBindingSource;
        private SupperMarketSystemDataSetTableAdapters.CatagoryDetailTableAdapter catagoryDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catDiscriptionDataGridViewTextBoxColumn;
    }
}
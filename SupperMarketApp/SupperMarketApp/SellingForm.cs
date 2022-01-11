using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupperMarketApp
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=SupperMarketSystem;Integrated Security=True");

        private void populate()
        {
            con.Open();
            string query = "select ProductName,ProductPrice from ProductDetail";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvProduct.DataSource = ds.Tables[0];
            con.Close();
        }

        private void populateBill()
        {
            con.Open();
            string query = "select * from BillDetail";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvBill.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ClearTextbox()
        {
            txtProductInvoice.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            //cbxCatagory.Text = string.Empty;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supperMarketSystemDataSet1.BillDetail' table. You can move, or remove it, as needed.
            this.billDetailTableAdapter.Fill(this.supperMarketSystemDataSet1.BillDetail);
            populate();
            populateBill();
            FillCombo();
            lbSeller.Text = Login.SellerName;
        }
        
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtProductPrice.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lbDate.Text = DateTime.Today.Day.ToString() + " / " + DateTime.Today.Month.ToString() + " / " + DateTime.Today.Year.ToString();
        }

        int GridTotal = 0,n=0;

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtProductInvoice.Text == "")
            {
                MessageBox.Show("Missig Bill Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BillDetail values (" + txtProductInvoice.Text + ",'" + lbSeller.Text + "','" + lbDate.Text + "','" + lbAmount.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Add Successfylly..!");
                    con.Close();
                    populate();
                    //ClearTextbox();
                    populateBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Samim Supper Shop", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red,new Point(230));
            e.Graphics.DrawString("Invoice No: " + dgvBill.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Cash Recived: " + dgvBill.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Shoppin Date: " + dgvBill.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + dgvBill.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Thanks to connect with us.", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Green, new Point(270,230));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //con.Open();
            ////string query = new " select * from ProductDetail where ProductCatagory = '" + cbxCatagoryScarch.SelectedValue.ToString()
            //SqlDataAdapter sda = new SqlDataAdapter(Queryable, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //dgvProduct.DataSource = ds.Tables[0];
            //con.Close();
        }

        private void FillCombo()
        {
            //This Method well bind the Combobox with the Database
            con.Open();
            SqlCommand cmd = new SqlCommand(" select CatName From CatagoryDetail ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            //cbxCatagory.ValueMember = "CatName";
            //cbxCatagory.DataSource = dt;
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {                      
            if (txtProductName.Text == "" || txtProductQuantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int Total = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvOrder);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtProductName.Text;
                newRow.Cells[2].Value = txtProductPrice.Text;
                newRow.Cells[3].Value = txtProductQuantity.Text;
                newRow.Cells[4].Value = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                dgvOrder.Rows.Add(newRow);
                n++;
                GridTotal = GridTotal + Total;
                lbAmount.Text = " " + GridTotal;
                ClearTextbox();
            }
        }
    }
}

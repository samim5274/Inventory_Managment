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
    public partial class ProductFrom : Form
    {
        public ProductFrom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=SupperMarketSystem;Integrated Security=True");

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from ProductDetail";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvProduct.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ClearTextbox()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            cbxCatagory.Text = string.Empty;
        }

        private void FillCombo()
        {
            //This Method well bind the Combobox with the Database
            con.Open();
            SqlCommand cmd = new SqlCommand(" select CatName From CatagoryDetail ",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(rdr);
            cbxCatagory.ValueMember = "CatName";
            cbxCatagory.DataSource = dt;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductId.Text == "" || txtProductName.Text == "" || txtProductPrice.Text == "" || txtProductQuantity.Text == "" || cbxCatagory.Text == "")
                {
                    MessageBox.Show("Information Missing.");
                }
                else
                {
                    con.Open();
                    string query = " update [ProductDetail] set [ProductName]='" + txtProductName.Text + "',[ProductPrice]='"+ txtProductPrice.Text +"',[ProductQuantity]='"+ txtProductQuantity.Text + "',[ProductCatagory]='"+ cbxCatagory.Text + "' where [ProductId] = '" + txtProductId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Edit Successfully..!");
                    con.Close();
                    populate();
                    ClearTextbox();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductId.Text == "")
                {
                    MessageBox.Show("Select the Product Item..!");
                }
                else
                {
                    con.Open();
                    string query = "Delete from ProductDetail where ProductId =" + txtProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Delete Successfully..!");
                    con.Close();
                    populate();
                    ClearTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductDetail values (" + txtProductId.Text + ",'" + txtProductName.Text + "'," + txtProductPrice.Text + ","+txtProductQuantity.Text+",'"+ cbxCatagory.SelectedValue.ToString() +"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Add Successfylly..!");
                con.Close();
                populate();
                ClearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supperMarketSystemDataSet.ProductDetail' table. You can move, or remove it, as needed.
            this.productDetailTableAdapter.Fill(this.supperMarketSystemDataSet.ProductDetail);
            FillCombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatagoryFrom cat = new CatagoryFrom();
            cat.Show();
            this.Hide();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtProductPrice.Text = dgvProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtProductQuantity.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();            
            cbxCatagory.SelectedValue = dgvProduct.SelectedRows[0].Cells[4].Value.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerFrom sellerfrom = new SellerFrom();
            sellerfrom.Show();
            this.Hide();
        }

        private void cbxCatagoryScarch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //con.Open();
            //string query = new " select * from ProductDetail where ProductCatagory = '" + cbxCatagoryScarch.SelectedValue.ToString()
            //SqlDataAdapter sda = new SqlDataAdapter(Queryable,con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //dgvProduct.DataSource = ds.Tables[0];
            //con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingForm sells = new SellingForm();
            sells.Show();
            this.Hide();
        }
    }
}

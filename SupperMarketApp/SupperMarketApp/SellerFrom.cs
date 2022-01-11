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
    public partial class SellerFrom : Form
    {
        public SellerFrom()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=SupperMarketSystem;Integrated Security=True");

        private void populate()
        {
            con.Open();
            string query = "select * from SellerDetail";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvSellerManage.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ClearTextbox()
        {
            txtSellerId.Text = string.Empty;
            txtSellerName.Text = string.Empty;
            txtSellerAge.Text = string.Empty;
            txtSellerPhone.Text = string.Empty;
            txtSellerPassword.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatagoryFrom catagory = new CatagoryFrom();
            catagory.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductFrom Product = new ProductFrom();
            Product.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void SellerFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supperMarketSystemDataSet.SellerDetail' table. You can move, or remove it, as needed.
            this.sellerDetailTableAdapter.Fill(this.supperMarketSystemDataSet.SellerDetail);
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerDetail values (" + txtSellerId.Text + ",'" + txtSellerName.Text + "','" + txtSellerAge.Text + "','" + txtSellerPhone.Text + "','" + txtSellerPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Add Successfylly..!");
                con.Close();
                populate();
                ClearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerId.Text == "" || txtSellerName.Text == "" || txtSellerAge.Text == "" || txtSellerPhone.Text == "" || txtSellerPassword.Text == "")
                {
                    MessageBox.Show("Information Missing.");
                }
                else
                {
                    con.Open();
                    string query = " update [SellerDetail] set [SellerName]='" + txtSellerName.Text + "',[SellerAge]='" + txtSellerAge.Text + "',[SellerPhone]='" + txtSellerPhone.Text + "',[SellerPassword]='"+txtSellerPassword.Text+"' where [SellerId] = '" + txtSellerId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Information Edit Successfully..!");
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

        private void dgvSellerManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerId.Text = dgvSellerManage.SelectedRows[0].Cells[0].Value.ToString();
            txtSellerName.Text = dgvSellerManage.SelectedRows[0].Cells[1].Value.ToString();
            txtSellerAge.Text = dgvSellerManage.SelectedRows[0].Cells[2].Value.ToString();
            txtSellerPhone.Text = dgvSellerManage.SelectedRows[0].Cells[3].Value.ToString();
            txtSellerPassword.Text = dgvSellerManage.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerId.Text == "")
                {
                    MessageBox.Show("Select the Seller Name..!");
                }
                else
                {
                    con.Open();
                    string query = "Delete from SellerDetail where SellerId =" + txtSellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Delete Successfully..!");
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
    }
}

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
    public partial class CatagoryFrom : Form
    {
        public CatagoryFrom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=SupperMarketSystem;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into CatagoryDetail values (" + txtCatagoryId.Text + ",'" + txtCatagoryName.Text + "','" + txtCatagoryDiscription.Text + "')";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catagory Add Successfylly..!");
                con.Close();
                populate();
                ClearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            con.Open();
            string query = "select * from CatagoryDetail";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder bilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvCatagory.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ClearTextbox()
        {
            txtCatagoryId.Text = string.Empty;
            txtCatagoryName.Text = string.Empty;
            txtCatagoryDiscription.Text = string.Empty;
        }
        private void CatagoryFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supperMarketSystemDataSet.CatagoryDetail' table. You can move, or remove it, as needed.
            this.catagoryDetailTableAdapter.Fill(this.supperMarketSystemDataSet.CatagoryDetail);
            populate();
        }

        private void dgvCatagory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCatagoryId.Text = dgvCatagory.SelectedRows[0].Cells[0].Value.ToString();
            txtCatagoryName.Text = dgvCatagory.SelectedRows[0].Cells[1].Value.ToString();
            txtCatagoryDiscription.Text = dgvCatagory.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dgvCatagory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        //    txtCatagoryId.Text = dgvCatagory.SelectedRows[0].Cells[0].Value.ToString();
        //    txtCatagoryName.Text = dgvCatagory.SelectedRows[0].Cells[1].Value.ToString();
        //    txtCatagoryDiscription.Text = dgvCatagory.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatagoryId.Text == "")
                {
                    MessageBox.Show("Select the Catagory..!");
                }
                else
                {
                    con.Open();
                    string query = "Delete from CatagoryDetail where CatId =" + txtCatagoryId.Text + "";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Delet Successfully..!");
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatagoryId.Text == "" || txtCatagoryName.Text == "" || txtCatagoryDiscription.Text == "")
                {
                    MessageBox.Show("Information Missing.");
                }
                else
                {
                    con.Open();
                    string query = " update [CatagoryDetail] set [CatName]='" + txtCatagoryName.Text +"',[CatDiscription]='" + txtCatagoryDiscription.Text + "' where [CatId] = '" + txtCatagoryId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Catagory Edit Successfully..!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            ProductFrom Prod = new ProductFrom();
            Prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerFrom sellerfrom = new SellerFrom();
            sellerfrom.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingForm sells = new SellingForm();
            sells.Show();
            this.Hide();
        }
    }
}

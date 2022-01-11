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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string SellerName = "";
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=SupperMarketSystem;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            cbxRole.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the username and passeord.");
            }
            else
            {
                if (cbxRole.SelectedIndex > -1)
                {

                    if (cbxRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txtUsername.Text == "Admin" || txtPassword.Text == "Admin")
                        {
                            ProductFrom product = new ProductFrom();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the admin,please fill the correct Role,Correct Username and Password.");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Your in Seller Section.");
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(" Select count(8) from SellerDetail where SellerName='"+txtUsername.Text+"' and SellerPassword= '"+txtPassword.Text+"'",con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellerName = txtUsername.Text;
                            SellingForm selle = new SellingForm();
                            selle.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username and Password");
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role.");
                }
            }
        }
    }
}

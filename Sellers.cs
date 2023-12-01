using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jasimProject
{
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
            Showseller();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\jasimProject\PharmacyDB.mdf;Integrated Security=True");
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtMobileNo.Text == ""  || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into SellerTbl(SellerAddress,SellerMobileNo,SellerPassword)values(@SA,@SMN,@SP");
               

                        cmd.Parameters.AddWithValue("@SMN", txtMobileNo.Text);

                        
                        cmd.Parameters.AddWithValue("@SP", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@SKey", key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Updated Successfully");
                        Con.Close();
                        Reset();

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Something Went Wrong");
                }

            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void GoSellers_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void GoManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

       

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void GoCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();

        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Showseller()
        {
            Con.Open();
            string Query = "Select * from sellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVSellers.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
           
            txtAddress.Text = "";
            txtMobileNo.Text = "";
  
            txtPassword.Text = "";
            key = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" ||  txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into SellerTbl(SellerName,SellerAddress,SellerMobileNo,SellerDOB,SellerPassword)values(@SN,@SA,@SMN,@SD,@SP)", Con);
                        cmd.Parameters.AddWithValue("@SN", txtName.Text);
                        cmd.Parameters.AddWithValue("@SA", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@SMN", txtMobileNo.Text);

                        cmd.Parameters.AddWithValue("@SD", txtDOB.Text);
     
                        cmd.Parameters.AddWithValue("@SP", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Added Successfully");
                        Con.Close();
                        Reset();

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int key = 0;
        private void DGVSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = DGVSellers.SelectedRows[0].Cells[1].ToString();
            txtAddress.Text = DGVSellers.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVSellers.SelectedRows[0].Cells[3].Value.ToString();
            txtDOB.Text = DGVSellers.SelectedRows[0].Cells[4].Value.ToString();
            
            txtPassword.Text = DGVSellers.SelectedRows[0].Cells[5].Value.ToString();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Seller");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from SellerTbl where SellerId = @Skey", Con);
                    cmd.Parameters.AddWithValue("@Skey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    Showseller();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        
    }
}

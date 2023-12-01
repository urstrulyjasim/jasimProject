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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowCustomer();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\jasimProject\PharmacyDB.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void GoDashboard_Click(object sender, EventArgs e)
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

        

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            this.Hide();
            obj.Show();
        }

        private void GoSellers_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
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
        private void ShowCustomer()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVCustomer.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtGender.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtAddress.Text == ""|| txtMobileNo.Text == "" || txtGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustomerName,CustomerAddress,CustomerMobileNo,CustomerDOB,CustomerGender)values(@CN,@CA,@CMN,@CD,@CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@CG", txtGender.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    Con.Close();
                    ShowCustomer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomerTbl set CustomerName=@CN,CustomerAddress=@CA,CustomerMobileNo,@CMN,CustomerDOB=@CD,CustomerGender=@CG where CustomerId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@CG", txtGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated Successfully");
                    Con.Close();
                    ShowCustomer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int key = 0;
        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = DGVCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = DGVCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVCustomer.SelectedRows[0].Cells[3].Value.ToString();
            txtDOB.Text = DGVCustomer.SelectedRows[0].Cells[4].Value.ToString();
            txtGender.SelectedItem = DGVCustomer.SelectedRows[0].Cells[5].Value.ToString();
            if (txtCustomerName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVCustomer.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Customer");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CustomerTbl where CustomerId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    Con.Close();
                    ShowCustomer();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jasimProject
{
    public partial class Manufacturer : Form
    {
        public Manufacturer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\jasimProject\PharmacyDB.mdf;Integrated Security=True");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Manufacturer");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ManufacturerTbl where ManufacturerId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Deleted Successfully");
                    Con.Close();
                    ShowManufacturer();
                    Reset();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowManufacturer()
        {
            Con.Open();
            string Query = "Select * from ManufactuererTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVManufacturer.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManufactuererTbl(ManufacturerName,ManufactuererAddress,ManufactuererMobileNo,ManufactuererDate)values(@MN,@MA,@MMN,@MD)", Con);
                    cmd.Parameters.AddWithValue("@MN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@MD", txtJoinDate.Value.Date);

                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Added Successfully");
                    Con.Close();
                    ShowManufacturer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }
        int key = 0;
        private void DGVManufacturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManufacturerName.Text = DGVManufacturer.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = DGVManufacturer.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVManufacturer.SelectedRows[0].Cells[3].Value.ToString();
            txtJoinDate.Text = DGVManufacturer.SelectedRows[0].Cells[4].Value.ToString();

            if (txtManufacturerName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVManufacturer.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            txtManufacturerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            key = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ManufactuererTbl set ManufacturerName=@CN,ManufacturerAddress=@CA,ManufactuererMobileNo=@CMN where ManufactuererId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtJoinDate.Value.Date);

                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Updated Successfully");
                    Con.Close();
                    ShowManufacturer();
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

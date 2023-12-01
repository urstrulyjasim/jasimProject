using jasimProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace jasimProject
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\jasimProject\PharmacyDB.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        public static string User;
       

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
            }
            else if (txtPassword.Text == "Admin")
            {
                Dashboard obj = new Dashboard();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You have entered wrong Admin Password");
                txtPassword.Text = "";
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

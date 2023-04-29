using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VisualProgrammingg
{
    public partial class LOGIN : Form
    {
        
        public LOGIN()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAZILIMG-1-01\MSSQL;Initial Catalog=visualProgramming;Integrated Security=True"); // veritabanı bağlantısı
        private void RegisterrLabel_Click(object sender, EventArgs e)
        {
            REGISTER frm = new REGISTER();
            frm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("select * from [users] where userName='" + UserNameTextBox.Text + "' and password ='" + PasswordTextBoxx.Text + "'", connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                string roles = (string)dr.GetValue(dr.GetOrdinal("role"));
                dr.Close();

            if (roles == "CUSTOMER")
                {
                    string query = "select userName from users where role='" + roleTextBoxxx.Text+ "'";
                    SqlCommand command1 = new SqlCommand(query, connection);
                    SqlDataReader dr1 = command.ExecuteReader();
                    
                    
                    CustomerPage frm = new CustomerPage();
                    frm.Show();

                } else if(roles == "FACTORY") {
                    string query = "select userName from users where role='" + roleTextBoxxx.Text + "'";
                    SqlCommand command1 = new SqlCommand(query, connection);
                    SqlDataReader dr2 = command.ExecuteReader();
                    
                    FactoryPage frm = new FactoryPage();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Login is unsuccesful");
            }
            connection.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

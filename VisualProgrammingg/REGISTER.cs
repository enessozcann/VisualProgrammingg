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
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=YAZILIMG-1-01\MSSQL;Initial Catalog=visualProgramming;Integrated Security=True"); // veritabanı bağlantısı
        private void RegisterButton_Click(object sender, EventArgs e)
        {
                connection.Open();

                string query = "insert into [users](name,password,userName,surname,phoneNumber,email,role)values(@name,@password,@userName,@surname,@phoneNumber,@email,@role)"; //kayıt oluşturmak için sorgu

                SqlCommand command = new SqlCommand(query, connection);// komut oluşturma

                command.Parameters.AddWithValue("@userName", UsernameTextBox.Text);
                command.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                command.Parameters.AddWithValue("@name", FactoryNameTextBox.Text);
                command.Parameters.AddWithValue("@surname", SurnameTextBox.Text);
                command.Parameters.AddWithValue("@phoneNumber", PhoneNumberTextBox.Text);
                command.Parameters.AddWithValue("@email", EmailTextBox.Text);
                command.Parameters.AddWithValue("@role", roleTextBox.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Register is succesfully");

                connection.Close();
            
  
            
        }

        
    }
}

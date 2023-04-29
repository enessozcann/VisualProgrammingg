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
    public partial class warehouse : Form
    {
        public warehouse()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAZILIMG-1-01\MSSQL;Initial Catalog=visualProgramming;Integrated Security=True"); // veritabanı bağlantısı
        private void AddButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "insert into [warehouse](ID,Wcountry,Wmaxstock,Waddress,Wphonenum)values(@ID,@Wcountry,@Wmaxstock,@Waddress,@Wphonenum)"; //kayıt oluşturmak için sorgu
            SqlCommand command = new SqlCommand(query, connection);// komut oluşturma

            command.Parameters.AddWithValue("@ID", IdTextBox.Text);
            command.Parameters.AddWithValue("@Wcountry", CountryTextBox.Text);
            command.Parameters.AddWithValue("@Wmaxstock", stockTextBox.Text);
            command.Parameters.AddWithValue("@Waddress", AdressTextBox.Text);
            command.Parameters.AddWithValue("@Wphonenum", phoneNumLabell.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Warehouse added succesfully");
            connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "delete from [warehouse] where ID=" + IdTextBox.Text + ""; //kayıt oluşturmak için sorgu
            SqlCommand command = new SqlCommand(query, connection);// komut oluşturma


            command.ExecuteNonQuery();
            MessageBox.Show("Warehouse delete succesfully");
            connection.Close();
        }

        private void warehouse_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select * from [warehouse]"; //kayıt oluşturmak için sorgu
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            warehouseDtaGridView.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            IdTextBox.Clear();
            CountryTextBox.Clear();
            stockTextBox.Clear();
            AdressTextBox.Clear();
            phoneNumLabell.Clear();

        }
    }
}

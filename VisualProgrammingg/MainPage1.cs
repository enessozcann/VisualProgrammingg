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
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }
        

        SqlConnection connection = new SqlConnection(@"Data Source=YAZILIMG-1-01\MSSQL;Initial Catalog=visualProgramming;Integrated Security=True"); // veritabanı bağlantısı

        private void comboboxes() // combobox içini doldurma
        {
            connection.Open();

            string query = "SELECT * FROM [users]";
           
            SqlCommand command = new SqlCommand(query, connection);// komut oluşturma
           
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                FactoryNameComboBox.Items.Add(dr["userName"]); //factory name combobox
            }
            connection.Close();
            if (FactoryNameComboBox.Items.Count > 1)
            {
                FactoryNameComboBox.SelectedIndex = -1;
            } 
        }

        private void populateGrid() // grid içini doldurmak
        {
            connection.Open();
            
            string query = "select * from [product]"; //kayıt oluşturmak için sorgu
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            productsssDataGridView.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void Filter() //filtreleme için 
        {
                connection.Open();

                string query = "select * from [product] where Pname = '"+ filterTextBox.Text + "'"; //kayıt oluşturmak için sorgu
                string query1 = "select * from [users] where userName= '" + FactoryNameComboBox.SelectedIndex.ToString() + "' and role= 'FACTORY' "; //kayıt oluşturmak için sorgu

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connection);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
                
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                adapter1.Fill(dataSet);
                productsssDataGridView.DataSource = dataSet.Tables[0];
                connection.Close();
            
        }
        
        private void CustomerPage_Load(object sender, EventArgs e) // grid ve comboBox içini doldurma için load işlemi
        {
            comboboxes();
            populateGrid();
        }

        
        private void ListelemeButonu_Click(object sender, EventArgs e) // LİST butonu işlemi
        {
            Filter();
        }
        

        private void siparişButon_Click(object sender, EventArgs e) // sipariş butonu işlemi
        { 
            try
            {
                connection.Open();
                int value = int.Parse(siparişTextBoc.Text);

                string query = "insert into [request](factoryAccept,customerSend)values(@factoryAccept,@customerSend)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@factoryAccept", value);
                command.Parameters.AddWithValue("@customerSend", amounttTextBox.Text);
                command.ExecuteNonQuery();

                int rowsAffect = command.ExecuteNonQuery();
                if (rowsAffect <= 0)
                {
                    MessageBox.Show("ERROR");

                }
                else
                {
                    MessageBox.Show("Succesfull");
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Request is not sending");
            }
           
        }
            

        private void clearbutton_Click(object sender, EventArgs e) // CLEAR butonu işlemi
        {
            siparişTextBoc.Clear();
            amounttTextBox.Clear();

        }

        private void ExitButtonn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


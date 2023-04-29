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
    public partial class FactoryPage : Form
    {
        public FactoryPage()
        {
            InitializeComponent();
           
        }
        
        SqlConnection connection = new SqlConnection(@"Data Source=YAZILIMG-1-01\MSSQL;Initial Catalog=visualProgramming;Integrated Security=True"); // veritabanı bağlantısı


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
            string query = "insert into [product](PId,Pname,Pdate,Pweight,Pprice,Pamount,whouseName)values(@PId,@Pname,@Pdate,@Pweight,@Pprice,@Pamount,@whouseName)"; //kayıt oluşturmak için sorgu
            SqlCommand command = new SqlCommand(query, connection);// komut oluşturma

            command.Parameters.AddWithValue("@PId", IdTextBox.Text);
            command.Parameters.AddWithValue("@Pname", nameTextBox.Text);
            command.Parameters.AddWithValue("@Pdate", DateTextBox.Text);
            command.Parameters.AddWithValue("@Pweight", WeightTextBox.Text);
            command.Parameters.AddWithValue("@Pprice", SalesTextBox.Text);
            command.Parameters.AddWithValue("@Pamount", AmountTextBox.Text);
            command.Parameters.AddWithValue("@whouseName", whouseTextBox.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Product added succesfully");
            connection.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message); 
                
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            string query = "delete from [product] where PId="+ IdTextBox.Text+""; //kayıt oluşturmak için sorgu
            SqlCommand command = new SqlCommand(query, connection);// komut oluşturma


            command.ExecuteNonQuery();
            MessageBox.Show("Product delete succesfully");
            connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            connection.Open();
            string query = "select * from [product]"; //kayıt oluşturmak için sorgu
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            productsDataGridView.DataSource = dataSet.Tables[0];
            connection.Close();
        }
        private void FactoryPage_Load_1(object sender, EventArgs e)
        {
            populate();
            
        }

        private void addWarehouseButton_Click(object sender, EventArgs e)
        {
            warehouse frm = new warehouse();
            frm.Show();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int value = int.Parse(amountTextBoxx.Text);

                string query = "UPDATE [product] Set Pamount = Pamount - @amount where Pname = @Pname";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@amount", value);
                command.Parameters.AddWithValue("@Pname", productAcceptTextbox.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Product is sending");

            }
            catch (Exception ex){
                MessageBox.Show("Product is not sending");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            productAcceptTextbox.Clear();
            amountTextBoxx.Clear();

        }

        private void clearrbutton_Click(object sender, EventArgs e)
        {
            IdTextBox.Clear();
            nameTextBox.Clear();
            DateTextBox.Clear();
            WeightTextBox.Clear();
            SalesTextBox.Clear();
            AmountTextBox.Clear();
            whouseTextBox.Clear();

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0) // seçilen satırı textbox'a yerleştirme
            {
                DataGridViewRow row = productsDataGridView.Rows[e.RowIndex];

                IdTextBox.Text = row.Cells["PId"].Value.ToString();
                nameTextBox.Text = row.Cells["Pname"].Value.ToString();
                DateTextBox.Text = row.Cells["Pdate"].Value.ToString();
                WeightTextBox.Text = row.Cells["Pweight"].Value.ToString();
                SalesTextBox.Text = row.Cells["Pprice"].Value.ToString();
                AmountTextBox.Text = row.Cells["Pamount"].Value.ToString();
                whouseTextBox.Text = row.Cells["whouseName"].Value.ToString();

            }
           
        }
    }
}

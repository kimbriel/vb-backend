using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace InstantOrderForm
{
    public partial class Form1 : Form
    {
        string myConnectionString = "server='localhost';database='UHAC';uid='root';pwd='';";
        public Form1()
        {
            InitializeComponent();
            setData();
            timer1.Start();
        }
        DataTable dbdataset;
        public void setData()
        {
            string sql = "select transac_id as 'Transaction ID',chicken as 'Chicken Qty.',fries 'French Fries Qty.',spag as 'Spaghetti Qty.',total as 'Total Amount',status,food_status as 'Food Status' from orders";
            MySqlConnection conDataBase = new MySqlConnection(myConnectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            status.Text = "paid";
            string sql = "update orders set status='paid' where transac_id=" + transaction_id.Text + ";";
            MySqlConnection conDataBase = new MySqlConnection(myConnectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Transaction success!");
                while (myReader.Read())
                {
                }
                setData();
                timer1.Stop();
                timer1.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("transaction failed! "+ex);
            }
      
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            transaction_id.Text = dataGridView1.Rows[e.RowIndex].Cells["Transaction ID"].Value.ToString();
            chicken_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Chicken Qty."].Value.ToString();
            frenchfries_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells["French Fries Qty."].Value.ToString();
            spaghetti_quantity.Text = dataGridView1.Rows[e.RowIndex].Cells["Spaghetti Qty."].Value.ToString();
            total_amount.Text = dataGridView1.Rows[e.RowIndex].Cells["Total Amount"].Value.ToString();
            status.Text = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();
            table_number.Text = dataGridView1.Rows[e.RowIndex].Cells["Food Status"].Value.ToString();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select transac_id as 'Transaction ID',chicken as 'Chicken Qty.',fries 'French Fries Qty.',spag as 'Spaghetti Qty.',total as 'Total Amount',status,food_status as 'Food Status' from orders where transac_id=" + textBox1.Text + "";
            MySqlConnection conDataBase = new MySqlConnection(myConnectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                timer1.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setData();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            status.Text = "paid";
            string sql = "update orders set food_status='cook' where transac_id=" + transaction_id.Text + ";";
            MySqlConnection conDataBase = new MySqlConnection(myConnectionString);
            MySqlCommand cmdDataBase = new MySqlCommand(sql, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Transaction success!");
                while (myReader.Read())
                {
                }
                setData();
                timer1.Stop();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("transaction failed! " + ex);
            }
        }
    }
}

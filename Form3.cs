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
    public partial class Form3 : Form
    {
        string myConnectionString = "server='localhost';database='UHAC';uid='root';pwd='';";
        DataTable dbdataset;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            setData();


        }


        public void setData()
        {
            string sql = "select transac_id as 'Transaction ID',chicken as 'Chicken Qty.',fries 'French Fries Qty.',spag as 'Spaghetti Qty.',total as 'Total Amount',status,food_status as 'Food Status' from orders where status='paid' and food_status='uncook'";
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
    }
}

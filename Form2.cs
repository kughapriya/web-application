using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace krishnaa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      


        

        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\another.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into product(DESCRIPTION, UNITTYPE, UNIT, UNITPRICE, AMOUNT) values('" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "' ,'" + textBox15.Text + "','" + textBox16.Text + "')";
            com.ExecuteNonQuery();
            MessageBox.Show("Saving is done!");
          



        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 d = new Form3();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            idcheck();

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\proje.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            string str = "select * from details where [CUSTOMER OR BUYER]='" + textBox1.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(str, con);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {

                textBox2.Text = sdr["ADDRESS"].ToString();
                textBox3.Text = sdr["INVOICE TYPE"].ToString();
                textBox8.Text = sdr["TERMS OF PAYMENT"].ToString();
                textBox9.Text = sdr["DATE OF SHIPMENT"].ToString();
                textBox4.Text = sdr["PROFORMA INV No"].ToString();
                textBox5.Text = sdr["BUYERS ORDER NO"].ToString();
                string date1 = dateTimePicker1.Value.ToShortDateString();
                string date2 = dateTimePicker2.Value.ToShortDateString();
                textBox6.Text = sdr["CURRENCY TYPE"].ToString();
                textBox7.Text = sdr["RATE OF EXCHANGE"].ToString();
                textBox10.Text = sdr["PLACE OF LOADING"].ToString();
                textBox11.Text = sdr["FINAL DESTINATION"].ToString();
                sdr.Close();
                con.Close();
            }


        }
        public void idcheck()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\proje.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();

            string str = "select count(*)from details where [CUSTOMER OR BUYER]='" + textBox1.Text + "'";

            SqlCommand com = new SqlCommand(str, con);

            int count = Convert.ToInt32(com.ExecuteScalar());

            if (count > 0)
            {

                MessageBox.Show("Id Exist");

            }

            else
            {

                MessageBox.Show("Id Does not Exist");

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 g = new Form5();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox14.Text);
            decimal b = decimal.Parse(textBox15.Text);
            decimal c;
            c = a * b;
            textBox16.Text = c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox16.Text = string.Empty;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 k = new Form3();
            k.Show();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       


    }

}











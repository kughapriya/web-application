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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 h=new Form6();
            h.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
             idcheck1();

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\proje.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            string str = "select * from export where [CODE NO]='" + textBox1.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(str, con);
            SqlDataReader sd = com.ExecuteReader();
            if (sd.Read())
            {

                textBox2.Text = sd["BUYERS NAME_ADDRESS"].ToString();
                textBox3.Text = sd["Invoice No"].ToString();
                textBox4.Text = sd["Buyer Order No"].ToString();
                textBox5.Text = sd["Country Of Origin"].ToString();
                textBox6.Text = sd["Port Of Landing"].ToString();
                textBox7.Text = sd["Final Destination"].ToString();
                string date1 = dateTimePicker1.Value.ToShortDateString();
                string date2 = dateTimePicker2.Value.ToShortDateString();
                textBox8.Text = sd["Currency type"].ToString();
                textBox9.Text = sd["Rate of Exchange"].ToString();
               
                sd.Close();
                con.Close();
            }


        }
        public void idcheck1()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\proje.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();

            string str = "select count(*)from export where [CODE NO]='" + textBox1.Text + "'";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 i = new Form5();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idcheck();

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\another.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            string str = "select * from product where DESCRIPTION ='" + textBox10.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(str, con);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                textBox11.Text = sdr["UNITTYPE"].ToString();
                textBox12.Text = sdr["UNIT"].ToString();
                textBox13.Text = sdr["UNITPRICE"].ToString();
                textBox14.Text = sdr["AMOUNT"].ToString();
                sdr.Close();
                con.Close();
            }


        }
        public void idcheck()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\another.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

            con.Open();

            string str = "select count(*)from product where DESCRIPTION='" + textBox10.Text + "'";

            SqlCommand com = new SqlCommand(str, con);

            int count = Convert.ToInt32(com.ExecuteScalar());

            if (count > 0)
            {

                MessageBox.Show("Product Exist");

            }

            else
            {

                MessageBox.Show("Product Does not Exist");

            }

        }

        }
    }


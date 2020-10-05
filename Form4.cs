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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\documents\visual studio 2010\Projects\krishnaa\krishnaa\proje.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into ledger([Ledger Group], [Ledger Code], [Ledger Head], [Addres Line-1], [Address Line-2], [State/Country]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            com.ExecuteNonQuery();
            MessageBox.Show("CREATED SUCCESSFULLY!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDIParent1 l = new MDIParent1();
            l.Show();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\Documents\proje.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            String str1 = "Select USERNAME,PASSWORD from login where USERNAME='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                this.Hide();
                MDIParent1 f = new MDIParent1();
                f.Show();

            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace krishnaa
{
    public partial class Form5 : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\Documents\another.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESCRIPTION, UNITTYPE, UNIT, UNITPRICE, AMOUNT FROM     product", con1);
            anotherDataSet  ds = new anotherDataSet();
            da.Fill(ds, "product");
            CrystalReport2 cr = new CrystalReport2();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            this.Hide();
            MDIParent1 f = new MDIParent1();
            f.Show();

           

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

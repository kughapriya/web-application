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
    public partial class Form6 : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kugha priya\Documents\another.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DESCRIPTION, UNITTYPE, UNIT, UNITPRICE, AMOUNT FROM     product", con1);
            anotherDataSet ds = new anotherDataSet();
            da.Fill(ds, "product");
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

           
        }
    }
}

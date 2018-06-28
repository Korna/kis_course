using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KIS8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        DataSet ds = new DataSet();
        SqlDataAdapter daRoute, daTransport, daDriver;

        private void Form3_Load(object sender, EventArgs e)
        {
            daRoute = new SqlDataAdapter("select * from route", cnn);
            daTransport = new SqlDataAdapter("select * from transport", cnn);
            daDriver = new SqlDataAdapter("select * from driver", cnn);

            daRoute.Fill(ds, "route");
            daDriver.Fill(ds, "driver");
            daTransport.Fill(ds, "transport");

            ds.Relations.Add("R_T", ds.Tables["route"].Columns["routeNumber"], ds.Tables["transport"].Columns["routeNumber"]);
            ds.Relations.Add("T_D", ds.Tables["transport"].Columns["personalNumber"], ds.Tables["driver"].Columns["personalNumber"]);

            bindingSource1.DataSource = ds.Tables[0];
            comboBox1.DataSource = bindingSource1;
            comboBox1.DisplayMember = "index";
            comboBox1.ValueMember = "routeNumber";
            bindingSource2.DataSource = bindingSource1;
            bindingSource2.DataMember = "R_T";
            dataGridView1.DataSource = bindingSource2;
            bindingSource3.DataSource = bindingSource2;
            bindingSource3.DataMember = "T_D";
            dataGridView2.DataSource = bindingSource3;



        }
    }
}

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

namespace KIS7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        DataSet ds = new DataSet();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;
            dataGridView3.DataSource = bindingSource3;
            SqlDataAdapter daRoute = new SqlDataAdapter("select * from route", cnn);
            SqlDataAdapter daTransport = new SqlDataAdapter("select * from transport", cnn);
            SqlDataAdapter daDriver = new SqlDataAdapter("select * from driver", cnn);
            daRoute.Fill(ds, "route");
            daDriver.Fill(ds, "driver");
            daTransport.Fill(ds, "transport");

            ds.Relations.Add("Route_Transport", ds.Tables["route"].Columns["routeNumber"], ds.Tables["transport"].Columns["routeNumber"]);
            ds.Relations.Add("Transport_Driver", ds.Tables["transport"].Columns["personalNumber"], ds.Tables["driver"].Columns["personalNumber"]);

            bindingSource1.DataSource = ds.Tables["route"];
            bindingSource2.DataSource = bindingSource1;
            bindingSource2.DataMember = "Route_Transport";

            bindingSource3.DataSource = bindingSource2;
            bindingSource3.DataMember = "Transport_Driver";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

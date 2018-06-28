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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bind = new BindingSource();

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from route", cnn);
            da.Fill(ds, "route");
            bind.DataSource = ds.Tables[0];
            textBox1.DataBindings.Add(new Binding("Text", bind, "length"));
            textBox2.DataBindings.Add(new Binding("Text", bind, "routeNumber"));
            textBox3.DataBindings.Add(new Binding("Text", bind, "countryID"));
            textBox4.DataBindings.Add(new Binding("Text", bind, "end"));
            textBox5.DataBindings.Add(new Binding("Text", bind, "start"));
            textBox6.DataBindings.Add(new Binding("Text", bind, "coordinates"));
            // dateTimePicker1.DataBindings.Add(new Binding("Text", bind, "birthday"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bind.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bind.MoveNext();
        }
    }
}

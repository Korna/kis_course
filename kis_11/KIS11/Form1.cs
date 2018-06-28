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

namespace KIS11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand(), cmd2 = new SqlCommand();
        SqlDataAdapter daPolis, daCase, damed;


        private void comboBox1_comboBox1_SelectionChangeCommitted(object sender, EventArgs e)//
                                                                             

        {

            cmd = new SqlCommand("countryinfo"); cmd.Connection = cnn;

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@coordsAkaRnum", SqlDbType.Int);

            cmd.Parameters["@coordsAkaRnum"].Value = Convert.ToInt32(
                comboBox1.SelectedValue.ToString()
                );

            cmd.Parameters.Add("@cName", SqlDbType.VarChar, 50);

            cmd.Parameters["@cName"].Direction = ParameterDirection.Output;

            cnn.Open();

            cmd.ExecuteNonQuery();

            textBox2.Text = cmd.Parameters["@cName"].Value.ToString();

            cnn.Close();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmd2 = new SqlCommand("routecasestation"); // cmd.Connection = cnn;

            cmd2.CommandType = CommandType.StoredProcedure;

            cmd2.Parameters.Add("@routeNumCase", SqlDbType.Int);

            cmd2.Parameters["@routeNumCase"].Value = Convert.ToInt32(dataGridView1[3,dataGridView1.CurrentCellAddress.Y].Value);

            damed = new SqlDataAdapter(); cmd2.Connection = cnn;

            damed.SelectCommand = cmd2;

            ds.Tables["stationList"].Clear();

            damed.Fill(ds, "stationList");

            dataGridView2.DataSource = ds.Tables["stationList"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            daPolis = new SqlDataAdapter("select * from city", cnn);

            daCase = new SqlDataAdapter("select * from route", cnn);

            daPolis.Fill(ds, "city");

            daCase.Fill(ds, "route");

            ds.Relations.Add("P_Case", ds.Tables["city"].Columns["coordinates"], ds.Tables["route"].Columns["routeNumber"]);//zdes

            bindingSource1.DataSource = ds.Tables["city"];

            comboBox1.DataSource = bindingSource1;

            comboBox1.DisplayMember = "координаты";

            comboBox1.ValueMember = "coordinates";//ili routeNumber ili coordinates

            bindingSource2.DataSource = bindingSource1;

            bindingSource2.DataMember = "P_Case";

            dataGridView1.DataSource = bindingSource2;

            dataGridView1.Columns[0].HeaderText = "длина";
            dataGridView1.Columns[1].HeaderText = "старт";
            dataGridView1.Columns[2].HeaderText = "конец";
            dataGridView1.Columns[3].HeaderText = "номер пути";
            dataGridView1.Columns[4].HeaderText = "ID страны";
            dataGridView1.Columns[5].HeaderText = "координаты";

            ds.Tables.Add("stationList");
        

    }
    }
}

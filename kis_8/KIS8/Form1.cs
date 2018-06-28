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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        DataSet ds = new DataSet();
        DataView dv;






        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dv.Sort = comboBox1.SelectedItem.ToString() + " DESC";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dv.Sort = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            //newForm.BackColor = Color.Aqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
          //  newForm3.BackColor = Color.Coral;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daClient = new SqlDataAdapter("select * from route", cnn);
            daClient.Fill(ds, "routeNumber");
            dv = new DataView(ds.Tables[0]);
            dataGridView1.DataSource = dv;
            foreach (DataColumn col in ds.Tables[0].Columns)
                comboBox1.Items.Add(col.ColumnName);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "length";
            comboBox2.ValueMember = "length";
            comboBox2.SelectedIndex = 1;
        }
    }



}

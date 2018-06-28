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



namespace kis_3{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
     
          SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();

        private void buttonShow(object sender, EventArgs e)
        {
            listRoute.Items.Clear();
            cnn.Open();

            
            cmd.CommandText = "select routeNumber from route";

            cmd.Connection = cnn;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listRoute.Items.Add(reader[0].ToString());
            }

            cnn.Close();
        }

  




        private void buttonSum(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "select sum([length]) from  route";
            textBox7.Text = "Общая длина =  " + Convert.ToString(cmd.ExecuteScalar());
            cnn.Close();

        }

        private void buttonDelete(object sender, EventArgs e)
        {
            cnn.Open(); cmd.Connection = cnn;
            cmd.CommandText = "delete from  route where routeNumber = " + textBox8.Text;
            textBox8.Text = "Удалено " + Convert.ToString(cmd.ExecuteNonQuery());
            cnn.Close();

        }

        private void buttonAdd(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;

            cmd.CommandText = "insert into route values (" + textLength.Text + ", '" + textStart.Text + "', '" + textEnd.Text + "'," + textRouteNum.Text + "," + textCountryID.Text + "," + textCoordinates.Text + ")";
            textLength.Text = textStart.Text = textEnd.Text = textRouteNum.Text = textCountryID.Text = textCoordinates.Text = "";

            cmd.ExecuteScalar();
            cnn.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "update route set length = 5000 where [length] > 50";
            cmd.ExecuteScalar();
            cnn.Close();

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "create table transportAmount (ID int primary key, number nchar(30)) ";
            cmd.ExecuteNonQuery();
            cnn.Close();


        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "drop table transportAmount";
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        private void buttonIDK_Click(object sender, EventArgs e)
        {
            listRoute.Items.Clear();
            cnn.Open();

            cmd.CommandText = "select length from  route";
            cmd.Connection = cnn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()){
                listRoute.Items.Add("length:" + reader[0].ToString());
            }

            cnn.Close();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "select coordinates from route order by coordinates DESC";
            textSort.Text = "coordinates #  " + Convert.ToString(cmd.ExecuteScalar());
            cnn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}



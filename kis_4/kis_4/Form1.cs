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
namespace kis_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

    }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
           listBox1.Clear();
         
            cnn.Open();
            cmd.CommandText = "select routeNumber from route;select length from route;";
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            { listBox1.Text += reader[0] + "\n"; }
                        listBox1.Text += "Номер пути:" + new string('*', 50) + "\n";
            reader.NextResult();
            while(reader.Read())
            { listBox1.Text += "Длина пути:" + reader["length"] + "\n"; }
            cnn.Close();
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Clear();
            cnn.Open();
            cmd.CommandText = "select routeNumber, length from route where length > @par ";
            cmd.Connection = cnn;
            if(!flag)
            {
                cmd.Parameters.Add("@par", SqlDbType.Int, 8);
                flag =true;
            }
            cmd.Parameters["@par"].Value = Convert.ToDecimal(textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                listBox1.Text += reader[0] + " " + reader[1] +"\n";
            }
            cnn.Close();
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Clear();
            cmd.Connection = cnn;
            cmd.CommandType =CommandType.StoredProcedure;
            cmd.CommandText ="procedure";
            cmd.Parameters.Add("@lengthNumber", SqlDbType.Int);
            cmd.Parameters["@lengthNumber"].Value = Convert.ToDecimal(textBox1.Text);
            cmd.Parameters.Add("@MaxLength", SqlDbType.Int);
            cmd.Parameters["@MaxLength"].Direction =ParameterDirection.Output;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Text+="Список длин путей, которые меньше введенного значения:\n";
            while(reader.Read())
            {
                listBox1.Text += reader[0] + " " + reader[1] + "\n";
            }
            reader.NextResult();
            listBox1.Text +="\nМаксимальная длина пути = "+Convert.ToString(cmd.Parameters["@MaxLength"].Value);
            cnn.Close();
            reader.Close();
        }
    }
}

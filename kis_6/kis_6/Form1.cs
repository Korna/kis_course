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
namespace kis_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)//кнопка показать
        {
            
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select length, start, [end], routeNumber from  route", cnn);
            da.Fill(ds,"route");
            dataGridView1.DataSource = ds.Tables[0];
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)//кнопка добавить
        {

            DataRow row = ds.Tables[0].NewRow();
            row["start"] = textBox1.Text;
            row[ "end"] = textBox2.Text;
            ds.Tables[0].Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)//кнопка отменить
        {
            ds.Tables[0].RejectChanges();
        }



        private void button5_Click(object sender, EventArgs e)//удалить нужную
        {
            ds.Tables[0].AcceptChanges();
            ds.Tables[0].Rows[Convert.ToInt32(textBox3.Text)-1].Delete();
        }

        private void button6_Click(object sender, EventArgs e)//сортировка
        {
            richTextBox1.Clear();
            string filter = string.Format("length <='{0}'", textBox4.Text);
            DataRow[] row = ds.Tables[0].Select(filter,"length DESC");
            if(row.Length == 0)
                MessageBox.Show("Нет значений");
            else
                for(int i = 0; i < row.Length; i++)
                {
                    richTextBox1.Text += row[i]["length"] +"    "+ row[i][0] +"\n";
                }

        }



        private void button7_Click(object sender, EventArgs e)// вставка в выбранную
        {
            dataGridView1[dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y].Value = textBox5.Text;
        }

        private void button8_Click(object sender, EventArgs e)//вставка в 00
        {
            ds.Tables[0].Rows[0][0] = textBox5.Text;
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}

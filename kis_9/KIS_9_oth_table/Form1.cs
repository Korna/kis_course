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

namespace KIS_9_oth_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");
        DataSet ds = new DataSet();
        BindingSource bind = new BindingSource();
        SqlDataAdapter daIns = new SqlDataAdapter(); //адаптер



        private void Form1_Load(object sender, EventArgs e)
        {
            // Выборка данных
            daIns.SelectCommand = new SqlCommand("select * from driver", cnn);
            daIns.Fill(ds, "driver");
            daIns.SelectCommand = new SqlCommand("select * from transport", cnn);
            daIns.Fill(ds, "transport");

            daIns.DeleteCommand = new SqlCommand("delete from driver where personalNumber = @pn", cnn);
            daIns.DeleteCommand.Parameters.Add("@pn", SqlDbType.Int, 6, "personalNumber"); //int

            daIns.InsertCommand = new SqlCommand("insert into driver values (@pn, @age, @name, @ph)", cnn);

            daIns.InsertCommand.Parameters.Add("@pn", SqlDbType.Int, 6, "personalNumber");
            daIns.InsertCommand.Parameters.Add("@age", SqlDbType.Int, 2, "age");
            daIns.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar, 30, "name");
            daIns.InsertCommand.Parameters.Add("@ph", SqlDbType.VarChar, 50, "photo");

            bind.DataSource = ds.Tables["driver"];
            dataGridView1.DataSource = bind;

            textBox1.DataBindings.Add(new Binding("Text", bind, "personalNumber"));
            textBox2.DataBindings.Add(new Binding("Text", bind, "age"));
            textBox3.DataBindings.Add(new Binding("Text", bind, "name"));
            textBox4.DataBindings.Add(new Binding("Text", bind, "photo"));

            foreach (DataColumn col in ds.Tables[0].Columns)
                comboBox1.Items.Add(col.ColumnName);  //ВЫВОД ТЕМ (определенного поля, список)

             comboBox1.DataSource = ds.Tables["transport"];
          //  comboBox1.DataSource = bind;
            comboBox1.ValueMember = "personalNumber";
            comboBox1.DisplayMember = "type";
            comboBox1.SelectedValue = 1;
            comboBox1.DataBindings.Add("SelectedValue", bind, "personalNumber");

        }

        private void button4_Click(object sender, EventArgs e)
        {//добавить
            DataRow newRow = ds.Tables[0].NewRow();


         //   cnn.Open();
         //   SqlCommand cmd2 = new SqlCommand(); //чтобы тема вместо номера:
         //   cmd2.CommandText = "Select personalNumber from driver where age = '" + comboBox1.Text + "'";
        //    cmd2.Connection = cnn;
           // int num = Convert.ToInt32(cmd2.ExecuteScalar());
       //     cnn.Close();

            newRow["personalNumber"] = Convert.ToInt32(textBox1.Text);
            newRow["age"] = Convert.ToInt32(textBox2.Text);
            newRow["name"] = textBox3.Text;
            newRow["photo"] = textBox4.Text;


            ds.Tables[0].Rows.Add(newRow);
            daIns.Update(ds.Tables[0]);
            ds.Clear(); //обновление данных в форме
            daIns.SelectCommand = new SqlCommand("select * from driver", cnn);
            daIns.Fill(ds, "driver");
            daIns.SelectCommand = new SqlCommand("select * from transport", cnn);
            daIns.Fill(ds, "transport");

        }

        private void button5_Click(object sender, EventArgs e)
        {//удалить
           ds.Tables[0].AcceptChanges();
           ds.Tables[0].Rows[bind.Position].Delete();
           daIns.Update(ds.Tables[0]);

        }

        private void button3_Click(object sender, EventArgs e)
        {//очистка
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {//назад
            bind.Position -= 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {//вперед
            bind.Position += 1;
        }
    }
}

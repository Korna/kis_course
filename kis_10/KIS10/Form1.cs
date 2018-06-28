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

namespace KIS10
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
        SqlDataAdapter da = new SqlDataAdapter();


        private void button1_Click(object sender, EventArgs e)
        {//back 
            bind.Position -= 1;

            if (textBox4.Text != "")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox1.Image = Image.FromFile(textBox4.Text);
            }
        }

    

        private void button2_Click(object sender, EventArgs e)
        {//add
            
                bind.Position += 1;

                if (textBox4.Text != "") {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox1.Image = Image.FromFile(textBox4.Text);
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        { // добавим новую строку

            DataRow newRow = ds.Tables[0].NewRow();

            newRow["age"] = textBox2.Text;
            newRow["name"] = textBox3.Text;
            newRow["photo"] = textBox4.Text;

            ds.Tables[0].Rows.Add(newRow); da.Update(ds.Tables[0]); ds.Clear();

            da.SelectCommand = new SqlCommand("select * from driverNew", cnn);

            da.Fill(ds, "driverNew");
        }

        private void button5_Click(object sender, EventArgs e)
        { // удалить

            ds.Tables[0].AcceptChanges();
            ds.Tables[0].Rows[bind.Position].Delete();

            da.Update(ds.Tables[0]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox4.Text = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(textBox4.Text);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                da.SelectCommand = new SqlCommand("select * from driverNew", cnn);

                da.Fill(ds, "driverNew");

                da.DeleteCommand = new SqlCommand("delete from driverNew where personalNumber = @personalNumber", cnn);

                da.DeleteCommand.Parameters.Add("@personalNumber", SqlDbType.Int, 6, "personalNumber");

                da.InsertCommand = new SqlCommand("insert into driverNew ( age, name, photo) values ( @age, @name, @photo)", cnn);

                da.InsertCommand.Parameters.Add("@age", SqlDbType.Int, 6, "age");

                da.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar, 50, "name");

                da.InsertCommand.Parameters.Add("@photo", SqlDbType.VarChar, 200, "photo");

                bind.DataSource = ds.Tables["driverNew"]; dataGridView1.DataSource = bind;

                textBox1.DataBindings.Add(new Binding("Text", bind, "personalNumber"));
                textBox2.DataBindings.Add(new Binding("Text", bind, "age"));
                textBox3.DataBindings.Add(new Binding("Text", bind, "name"));
                textBox4.DataBindings.Add(new Binding("Text", bind, "photo"));

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                if(textBox4.Text != "")
                    pictureBox1.Image = Image.FromFile(textBox4.Text);
            

        }
    }
}

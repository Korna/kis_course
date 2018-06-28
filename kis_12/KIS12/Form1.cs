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
using Excel = Microsoft.Office.Interop.Excel;

namespace KIS12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DOLBON\SQL2016;Initial Catalog=RouteDB;Integrated Security=True;");

        DataSet ds = new DataSet();

        SqlDataAdapter daIns;

        DataRelation drel;
        private void Form1_Load(object sender, EventArgs e)
        {
            daIns = new SqlDataAdapter("select * from driver", cnn);
            daIns.Fill(ds, "driver");
            daIns = new SqlDataAdapter("select * from transport", cnn);
            daIns.Fill(ds, "transport");
            drel = ds.Relations.Add("D_T", ds.Tables["driver"].Columns["personalNumber"], ds.Tables["transport"].Columns["personalNumber"]);
            bindingSource1.DataSource = ds.Tables[0];
            bindingSource2.DataSource = bindingSource1;
            bindingSource2.DataMember = "D_T";
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;

        }

        private void button3_Click(object sender, EventArgs e)//загрузка
        {
            ds.ReadXml(@"C:\excel\fromdb.xml"); 
    }

        private void button1_Click(object sender, EventArgs e)//сохран
        {
            
                ds.WriteXml(@"C:\excel\fromdb.xml");

                ds.WriteXmlSchema(@"C:\excel\schema.xsd");

                string xmltable = ds.GetXml();

                richTextBox1.Text = xmltable;
            
        }

        private void button4_Click(object sender, EventArgs e)//select??
        {
            
                Excel.Application ExApp = new Excel.Application();

                ExApp.Visible = true;

                ExApp.SheetsInNewWorkbook = 1;

                ExApp.Workbooks.Add();

                Excel.Workbook ExWbook = ExApp.Workbooks[1];

                Excel.Worksheet listex = ExWbook.Worksheets.get_Item(1);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)

                    listex.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)

                    for (int j = 0; j < dataGridView1.Columns.Count; j++)

                        listex.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                listex.Cells.get_Range("A1", "C1").Font.Color = Color.Blue;
            
        }

        private void button5_Click(object sender, EventArgs e)//export??
        {
            drel.Nested = true;

            ds.WriteXml(@"C:\excel\fromdb.xml");

            ds.WriteXmlSchema(@"C:\excel\schema.xsd");

            string xmltable = ds.GetXml();

            richTextBox1.Text = xmltable;
        
    }

        private void button2_Click(object sender, EventArgs e)//очистка
        {
             ds.Clear(); 
        }
    }
}

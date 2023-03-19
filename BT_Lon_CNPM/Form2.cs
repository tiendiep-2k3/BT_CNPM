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

namespace BT_Lon_CNPM
{
    public partial class Form2 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-MUKSDVC\SQLEXPRESS;Initial Catalog=test00;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table= new DataTable();

        void loadData()
        {
            command=connection.CreateCommand();
            command.CommandText= "select * from dataTicket";
            adapter.SelectCommand= command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection=new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btATM_Click(object sender, EventArgs e)
        {
            command=connection.CreateCommand();
            command.CommandText = "insert into dataTicket values(N'"+txtTen.Text+"','"+txtsdt.Text+"','"+cbdi.Text +"','"+cbden.Text +"')";
            command.ExecuteNonQuery();
            loadData();
            
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        public void cbdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtTen.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cbdi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cbden.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into dataTicket values(N'" + txtTen.Text + "','" + txtsdt.Text + "','" + cbdi.Text + "','" + cbden.Text + "')";
            command.ExecuteNonQuery();
            loadData();

            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}

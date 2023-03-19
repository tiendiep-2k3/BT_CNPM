using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Lon_CNPM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy mã PIN từ TextBox
            string pin = textBox1.Text.Trim();

            // Kết nối với cơ sở dữ liệu SQL Server
            string connectionString = "Data Source=DESKTOP-MUKSDVC\\SQLEXPRESS;Initial Catalog=test00;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu trong bảng chứa mã PIN
                string query = "SELECT COUNT(*) FROM customer WHERE Pin = @Pin";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pin", pin);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Mã PIN hợp lệ
                        MessageBox.Show("Payment successful, printing tickets!");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        // Mã PIN không hợp lệ
                        MessageBox.Show("Payment failed!");
                    }

                }
            }
        }
    }
}

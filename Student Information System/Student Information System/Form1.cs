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

namespace Student_Information_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=studentinfodb;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("Select * from studentab", conn);
            SqlDataAdapter data =new SqlDataAdapter(cnn);
            DataTable table =new DataTable();

            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=studentinfodb;Integrated Security=True");
            conn.Open();
            SqlCommand cnn = new SqlCommand("insert into studentab values(@id,@Stname,@age,@email)", conn);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Stname",textBox2.Text);

            cnn.Parameters.AddWithValue("@age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@email", textBox4.Text);

            cnn.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data Instered Successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=studentinfodb;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("Select * from studentab", conn);
            SqlDataAdapter data = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();

            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?","Confirm Cancellation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                   
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=studentinfodb;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM studentab WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);


                cmd.ExecuteNonQuery();

                conn.Close();


                MessageBox.Show("Data Deleted Successfully");
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please select a record to delete");
            }

        }
    }
}

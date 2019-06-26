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

namespace PC_08
{
    public partial class room_form : Form
    {
        SqlConnection konek;
        public room_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void room_form_Load(object sender, EventArgs e)
        {
            konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");

            konek.Open();
            refresh_tbl();
            konek.Close();
        }
        private void refresh_tbl()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from rooms where deleted_at is null", konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //udpate
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            button5.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert
            textBox2.Enabled = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            button5.Enabled = true;
            button6.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*cancel
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            button5.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;*/
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //save data btn
            konek.Close();
            string id = textBox2.Text;
            string code = textBox3.Text;
            string capacity = textBox4.Text;

            if (code.Equals("") || capacity.Equals(""))
            {
                MessageBox.Show("Jangan kosongkan data");
            }
            else
            {
                if (id.Equals(""))
                {
                    //proses insert
                    konek.Open();
                    string query = "insert into rooms (code, capacity) values (@code, @capacity)";
                    SqlCommand cmd = new SqlCommand(query, konek);

                    try
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Berhasil tambah data");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    konek.Close();
                }
                else
                {
                    //proses update
                    konek.Open();
                    string query = "update rooms set code = @code, capacity = @capacity where id = @id";
                    SqlCommand cmd = new SqlCommand(query, konek);

                    try
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.Parameters.AddWithValue("@id", id);

                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Berhasil ubah data");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    konek.Close();
                }
            }
            konek.Open();
            refresh_tbl();
            reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kata_kunci = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter($"select * from rooms where code like '%{kata_kunci}%'", konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void reset()
        {

            textBox2.Enabled = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string code = dataGridView1.Rows[e.RowIndex].Cells["code"].FormattedValue.ToString();
            string capacity = dataGridView1.Rows[e.RowIndex].Cells["capacity"].FormattedValue.ToString();


            textBox2.Text = id;
            textBox3.Text = code;
            textBox4.Text = capacity;

            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus ini ?", "Peringatan", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //proses update
                string id = textBox2.Text;
                konek.Open();
                string query = "update rooms set deleted_at=getdate() where id = @id";
                SqlCommand cmd = new SqlCommand(query, konek);

                try
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    MessageBox.Show("Berhasil hapus data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                konek.Close();

                konek.Open();
                refresh_tbl();
                reset();
            }

        }
    }
}

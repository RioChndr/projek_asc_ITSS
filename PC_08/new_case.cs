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
    public partial class new_case : Form
    {
        SqlConnection konek;
        int total_pertanyaan;
        string id_pertanyaan_terpilih;
        public new_case()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(new_question nq = new new_question())
            {
                nq.code_case = textBox1.Text;
                if (nq.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    refresh_tbl();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void new_case_Load(object sender, EventArgs e)
        {
            konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button5.Enabled = true;

            id_pertanyaan_terpilih = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();


        }

        private void refresh_tbl()
        {
            string case_code = textBox1.Text;
            int id_case = cek_case(case_code);
            string query = "SELECT[id],[case_id],[text],[option_a],[option_b],[option_c],[option_d],[correct_answer] FROM[cases_details] where case_id = '"+id_case+"' and deleted_at is null";

            konek.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            konek.Close();

            konek.Open();
            string query_count = "select number_of_questions from cases where cases.deleted_at is null and id = '" + id_case + "'";
            SqlCommand cmd = new SqlCommand(query_count, konek);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                total_pertanyaan = reader.GetInt32(0);
            }
            textBox2.Text = total_pertanyaan.ToString();
            konek.Close();

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private int cek_case( string code_case)
        {
            string query_cari = "select id from cases where code = @code_case";
            int id_case;
            int count = 0;
            konek.Open();
            SqlCommand cmd = new SqlCommand(query_cari, konek);

            try
            {

                cmd.Parameters.AddWithValue("@code_case", code_case);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                    id_case = reader.GetInt32(0);
                    konek.Close();
                    return id_case;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();
            return 0;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!id_pertanyaan_terpilih.Equals(""))
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus ini ?", "Peringatan", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string query_input = "delete from cases_details where id = @id_pertanyaan";

                    konek.Open();
                    SqlCommand cmd1 = new SqlCommand(query_input, konek);

                    try
                    {
                        cmd1.Parameters.AddWithValue("@id_pertanyaan", id_pertanyaan_terpilih);
                        SqlDataReader reader = cmd1.ExecuteReader();
                        MessageBox.Show("Berhasil Dihapus");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    konek.Close();


                }
            }
            else
            {
                MessageBox.Show("Pilih data terlebih dahulu");
            }
            string case_code = textBox1.Text;
            int id_case = cek_case(case_code);
            update_question_number(id_case);
            refresh_tbl();
        }

        private void update_question_number(int id_case)
        {
            int total_question = get_total_question(id_case);

            string query = "update cases set number_of_questions = @total_questions where id = @case_id";
            konek.Open();
            SqlCommand cmd = new SqlCommand(query, konek);
            try
            {
                cmd.Parameters.AddWithValue("@case_id", id_case);
                cmd.Parameters.AddWithValue("@total_questions", total_question);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();
        }
        private int get_total_question(int id_case)
        {
            string query = "select count(*) from cases_details where case_id = '" + id_case + "'";
            konek.Open();
            SqlCommand cmd = new SqlCommand(query, konek);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int total_q = 0;
                    total_q = reader.GetInt32(0);
                    konek.Close();
                    return total_q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();
            return 0;
        }

        private void textBox1_MouseLeave(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            refresh_tbl();
        }
    }
}

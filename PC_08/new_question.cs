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
    
    public partial class new_question : Form
    {
        public string code_case;
        string answer_2;
        SqlConnection konek;
        public new_question()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_question_Load(object sender, EventArgs e)
        {
            label2.Text = "Code case : " + code_case;
            konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_case = cek_case();
            string pertanyaan = input_pertanyaan.Text;
            string x_input_a = input_a.Text;
            string x_input_b = input_b.Text;
            string x_input_c = input_c.Text;
            string x_input_d = input_d.Text;
            string jwbn = combobox_answer.Text;

            if (jwbn.Equals("A"))
            {
                answer_2 = x_input_a;
            }
            else if (jwbn.Equals("B"))
            {
                answer_2 = x_input_b;
            }
            else if (jwbn.Equals("C"))
            {
                answer_2 = x_input_c;
            }
            else if (jwbn.Equals("D"))
            {
                answer_2 = x_input_d;
            }

            string query_values = "@code_case, @pertanyaan, @x_input_a, @x_input_b, @x_input_c, @x_input_d, @answer";
            string query_input = "INSERT INTO cases_details (case_id,text,option_a,option_b,option_c,option_d,correct_answer)VALUES (" + query_values + ")";
            
            konek.Open();
            SqlCommand cmd = new SqlCommand(query_input, konek);

            try
            {

                cmd.Parameters.AddWithValue("@code_case", id_case);
                cmd.Parameters.AddWithValue("@pertanyaan", pertanyaan);
                cmd.Parameters.AddWithValue("@x_input_a", x_input_a);
                cmd.Parameters.AddWithValue("@x_input_b", x_input_b);
                cmd.Parameters.AddWithValue("@x_input_c", x_input_c);
                cmd.Parameters.AddWithValue("@x_input_d", x_input_d);
                cmd.Parameters.AddWithValue("@answer", answer_2);
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil di tambah");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();

            update_question_number(id_case);
            this.Close();
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

        private int cek_case()
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
            

            if (count == 0)
            {
                string query_input = "insert into cases (creator_id, code, number_of_questions) values ('1', @code, '0')";

                konek.Open();
                SqlCommand cmd1 = new SqlCommand(query_input, konek);

                try
                {

                    cmd1.Parameters.AddWithValue("@code", code_case);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                konek.Close();
                return cek_case();
            }
            
            return 0;
        }
    }
}

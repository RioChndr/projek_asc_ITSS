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
    public partial class view_case_form : Form
    {
        SqlConnection konek;
        string total_questions;
        int selected_question;
        string id_case;
        string answer_1;
        string answer_2;
        int selected_case;
        public view_case_form()
        {
            InitializeComponent();
        }

        private void view_case_form_Load(object sender, EventArgs e)
        {
            konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");

            konek.Open();
            refresh_tbl();
            konek.Close();

            //ntuk melakukan combobox piliahn
            //comboBox1.SelectedIndex = comboBox1.FindStringExact("A");
        }
        private void refresh_tbl()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select cases.id, cases.code, users.name as creator, cases.number_of_questions, cases.created_at from cases left join users on users.id = cases.creator_id where cases.deleted_at is null", konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_case = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            total_questions = dataGridView1.Rows[e.RowIndex].Cells["number_of_questions"].FormattedValue.ToString(); 
            selected_question = 1;
            ambil_soal();
        }

        private void ambil_soal()
        {
            label3.Text = "Question " + selected_question + "/" + total_questions;
            konek.Open();
            string query = "select * from cases_details where case_id = @case_id";
            SqlCommand cmd = new SqlCommand(query, konek);

            try
            {
                cmd.Parameters.AddWithValue("@case_id", id_case);
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                    if(count == selected_question)
                    {
                        input_pertanyaan.Text = reader.GetString(2);
                        string answer = reader.GetString(7);
                        
                        input_a.Text = reader.GetString(3);
                        input_b.Text = reader.GetString(4);
                        input_c.Text = reader.GetString(5);
                        input_d.Text = reader.GetString(6);
                        if(answer.Equals(reader.GetString(3)))
                        {
                            answer_1 = "A";
                        }else if(answer.Equals(reader.GetString(4)))
                        {
                            answer_1 = "B";
                        }
                        else if (answer.Equals(reader.GetString(5)))
                        {
                            answer_1 = "C";
                        }
                        else if (answer.Equals(reader.GetString(6)))
                        {
                            answer_1 = "D";
                        }

                        combobox_answer.SelectedIndex = combobox_answer.FindStringExact(answer_1);

                        selected_case = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error cok");
                MessageBox.Show(ex.Message);
            }
            konek.Close();


            if (selected_question.Equals(1))
            {
                button_back.Enabled = false;
                button_for.Enabled = true;
            }
            if(selected_question > 1 && selected_question < Int32.Parse(total_questions))
            {
                button_back.Enabled = true;
                button_for.Enabled = true;
            }
            if(selected_question == Int32.Parse(total_questions))
            {
                button_back.Enabled = true;
                button_for.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected_question = 1;
            ambil_soal();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selected_question = Int32.Parse(total_questions);
            ambil_soal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_question -= 1;
            ambil_soal();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selected_question += 1;
            ambil_soal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input_a.Enabled = true;
            input_b.Enabled = true;
            input_c.Enabled = true;
            input_d.Enabled = true;
            input_pertanyaan.Enabled = true;
            combobox_answer.Enabled = true;
            button_back.Enabled = false;
            button_for.Enabled = false;
            button_first.Enabled = false;
            button_end.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ambil_soal();
            button_first.Enabled = true;
            button_end.Enabled = true;
            input_a.Enabled = false;
            input_b.Enabled = false;
            input_c.Enabled = false;
            input_d.Enabled = false;
            input_pertanyaan.Enabled = false;
            combobox_answer.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string x_input_a = input_a.Text;
            string x_input_b = input_b.Text;
            string x_input_c = input_c.Text;
            string x_input_d = input_d.Text;
            string x_input_q = input_pertanyaan.Text;
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


            konek.Open();
            string query = "update cases_details SET text = @input_q, option_a = @opt_a, option_b = @opt_b, option_c = @opt_c, option_d = @opt_d, correct_answer = @correct where id = @id_case";
            SqlCommand cmd = new SqlCommand(query, konek);

            try
            {

                cmd.Parameters.AddWithValue("@id_case", selected_case);
                cmd.Parameters.AddWithValue("@input_q", x_input_q);
                cmd.Parameters.AddWithValue("@opt_a", x_input_a);
                cmd.Parameters.AddWithValue("@opt_b", x_input_b);
                cmd.Parameters.AddWithValue("@opt_c", x_input_c);
                cmd.Parameters.AddWithValue("@opt_d", x_input_d);
                cmd.Parameters.AddWithValue("@correct", answer_2);
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil di update");            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();

            ambil_soal();
            button_first.Enabled = true;
            button_end.Enabled = true;
            input_a.Enabled = false;
            input_b.Enabled = false;
            input_c.Enabled = false;
            input_d.Enabled = false;
            input_pertanyaan.Enabled = false;
            combobox_answer.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

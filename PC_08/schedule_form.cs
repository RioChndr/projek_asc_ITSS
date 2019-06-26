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
    public partial class schedule_form : Form
    {
        SqlConnection konek;
        string id_schedule = "";
        string id_participant_selected = "";
        public schedule_form()
        {
            InitializeComponent();
        }

        private void schedule_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pC_08DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pC_08DataSet1.users);
            // TODO: This line of code loads data into the 'pC_08DataSet1.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.pC_08DataSet1.schedules);
            // TODO: This line of code loads data into the 'pC_08DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pC_08DataSet1.users);
            // TODO: This line of code loads data into the 'pC_08DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pC_08DataSet.users);
            // TODO: This line of code loads data into the 'pC_08DataSet.cases' table. You can move, or remove it, as needed.
            this.casesTableAdapter.Fill(this.pC_08DataSet.cases);
            // TODO: This line of code loads data into the 'pC_08DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.pC_08DataSet.rooms);
            // TODO: This line of code loads data into the 'pC_08DataSet.types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.pC_08DataSet.types);
            // TODO: This line of code loads data into the 'pC_08DataSet3.get_examiner' table. You can move, or remove it, as needed.
            this.get_examinerTableAdapter.Fill(this.pC_08DataSet3.get_examiner);

            this.usersTableAdapter.carii_participant(this.pC_08DataSet.users);

            konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");
            load_schedule();
        }

        private void carii_participantToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.usersTableAdapter.carii_participant(this.pC_08DataSet.users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void usersBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void load_schedule()
        {
            string query = "SELECT schedules.id,users.name as 'examiner',types.name as 'type',rooms.code,cases.code,time FROM schedules left join users on users.id = schedules.examiner_id left join types on types.id = schedules.type_id  left join rooms on rooms.id  = schedules.room_id  left join cases on cases.id = schedules.case_id where schedules.deleted_at is null";
            konek.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            konek.Close();
        }

        private void get_participant(string id_schedule)
        {
            string query = "select schedules_participants.id, users.name from schedules_participants left join users on users.id = schedules_participants.participant_id where schedules_participants.schedule_id= '"+id_schedule+"' and schedules_participants.deleted_at is null";
            konek.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;
            konek.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string pilih_id_schedule = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            string examiner = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            string type = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            string room = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            string case_shedule = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            string date = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

            get_participant(pilih_id_schedule);

            comboBox1.Text = examiner;
            comboBox2.Text = type;
            comboBox3.Text = room;
            comboBox4.Text = case_shedule;
            dateTimePicker1.Text = date;

            id_schedule = pilih_id_schedule;
            button3.Enabled = true;
            button8.Enabled = true;
            comboBox5.Enabled = true;
            button6.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            dateTimePicker1.Text = "";

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            dateTimePicker1.Enabled = true;

            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset_form();
        }

        private void reset_form()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            dateTimePicker1.Enabled = false;

            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            id_schedule = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (id_schedule.Equals(""))
            {
                //tambah
                tambah_schedule();
                load_schedule();
            }else
            {
                //update
                update_schedule();
                load_schedule();
            }
            reset_form();
        }

        private void tambah_schedule()
        {
            string input_examiner =comboBox1.SelectedValue.ToString();
            string input_type =comboBox2.SelectedValue.ToString();
            string input_room =comboBox3.SelectedValue.ToString();
            string input_case =comboBox4.SelectedValue.ToString();
            string input_time =dateTimePicker1.Text;

            string query = "insert into schedules (examiner_id, type_id, room_id, case_id, time) values (@examiner, @type, @room, @case, @time)";
            
            konek.Open();
            SqlCommand cmd = new SqlCommand(query, konek);
            try
            {
                cmd.Parameters.AddWithValue("@examiner", input_examiner);
                cmd.Parameters.AddWithValue("@type", input_type);
                cmd.Parameters.AddWithValue("@room", input_room);
                cmd.Parameters.AddWithValue("@case", input_case);
                cmd.Parameters.AddWithValue("@time", input_time);
                
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil di tambah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();
        }

        private void update_schedule()
        {
            string input_examiner = comboBox1.SelectedValue.ToString();
            string input_type = comboBox2.SelectedValue.ToString();
            string input_room = comboBox3.SelectedValue.ToString();
            string input_case = comboBox4.SelectedValue.ToString();
            string input_time = dateTimePicker1.Text;

            string query = "update schedules set examiner_id=@examiner, type_id = @type, room_id = @room, case_id = @case, time = @time where id = @id_schedule";

            konek.Open();
            SqlCommand cmd = new SqlCommand(query, konek);
            try
            {
                cmd.Parameters.AddWithValue("@examiner", input_examiner);
                cmd.Parameters.AddWithValue("@type", input_type);
                cmd.Parameters.AddWithValue("@room", input_room);
                cmd.Parameters.AddWithValue("@case", input_case);
                cmd.Parameters.AddWithValue("@time", input_time);
                cmd.Parameters.AddWithValue("@id_schedule", id_schedule);

                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil di update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus ini ?", "Peringatan", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //proses update
                string id = id_schedule;
                konek.Open();
                string query = "update schedules set deleted_at=getdate() where id = @id";
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

                
                load_schedule();
                reset_form();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus ini ?", "Peringatan", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //proses update
                string id = id_schedule;
                konek.Open();
                string query = "update schedules_participants set deleted_at=getdate() where schedule_id = @id";
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


                get_participant(id_schedule);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus ini ?", "Peringatan", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //proses update
                string id = id_participant_selected;
                konek.Open();
                string query = "update schedules_participants set deleted_at=getdate() where id = @id";
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


                get_participant(id_schedule);
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_participant_selected = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            button7.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id_participant = comboBox5.SelectedValue.ToString();
            string query = "insert into schedules_participants (schedule_id, participant_id) values (@schedule, @paricipant)";

            konek.Open();
            SqlCommand cmd = new SqlCommand(query, konek);

            try
            {
                cmd.Parameters.AddWithValue("@schedule", id_schedule);
                cmd.Parameters.AddWithValue("@paricipant", id_participant);


                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Berhasil tambah data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            konek.Close();


            get_participant(id_schedule);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            dateTimePicker1.Enabled = true;

            button4.Enabled = true;
            button5.Enabled = true;
        }
    }
}

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
    public partial class Form1 : Form
    {
        SqlConnection konek;
        string role_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;

            if(username.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Mohon semua data diisi");

            }
            else
            {
                string query = "select id, role_id from users where username = @username and password = @password";
                SqlCommand cmd = new SqlCommand(query, konek);

                try
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", pass);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    
                    while (reader.Read())
                    {
                        count++;
                        role_id = reader.GetValue(1).ToString();
                    }

                    if(count > 0)
                    {
                        MessageBox.Show("berhasil masuk");
                        
                        if(role_id.Equals("1"))
                        {
                            Form2 mdi_admin = new Form2();
                            mdi_admin.Show();
                        }
                        else if(role_id.Equals("2") || role_id.Equals("3"))
                        {
                            Form3 mdi_exam = new Form3();
                            mdi_exam.Show();
                        }
                        this.Hide();
                        konek.Close();
                    }

                    else
                    {
                        MessageBox.Show("Username atau password salah");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");
            konek.Open();
        }
    }
}

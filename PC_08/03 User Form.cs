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
    public partial class _03_User_Form : Form
    {
        
        public _03_User_Form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void _03_User_Form_Load(object sender, EventArgs e)
        {
           /** SqlConnection konek = new SqlConnection(@"Data Source=DESKTOP-NLESQ2O\SQLEXPRESS01;Initial Catalog=PC_08;Integrated Security=True");

            SqlDataAdapter adapter = new SqlDataAdapter("select * from users", konek);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource(dt);**/
        }
    }
}

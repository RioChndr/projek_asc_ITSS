using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_08
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _03_User_Form user_form = new _03_User_Form();
            user_form.Show();
            this.Hide();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(type_form tf = new type_form())
            {
                if(tf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (room_form tf = new room_form())
            {
                if (tf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void viewCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (view_case_form tf = new view_case_form())
            {
                if (tf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Show();
                }
            }
        }

        private void newCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_case nc = new new_case();
            
                nc.Show();
            
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schedule_form sf = new schedule_form();
            sf.Show();
        }
    }
}

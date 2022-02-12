using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_reserve_ticket
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                MessageBox.Show("Replaced successfully");
                this.Hide();
                Form3 m = new Form3();//home
                m.Show();
            }
            else
            {
                MessageBox.Show("you should select ticket for booking");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 pp = new Form6();//cancel
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 n = new Form3();//home
            n.Show();
        }
    }
}

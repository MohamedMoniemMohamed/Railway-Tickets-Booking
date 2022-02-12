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
    public partial class Form2 : Form
    {
        public static string username;
        public static string lastname;
        public static string em;
        public static string phone;
        public static string Pass1;
        public static string pass2;

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text!= textBox5.Text)// password
            {
                MessageBox.Show("you should write the same password");
                textBox4.Text = "";
                textBox5.Text = "";// هصفرهم

            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && radioButton1.Checked == true || radioButton2.Checked == true)
            {
                MessageBox.Show("The account has been created successfully");
                this.Hide();
                Form1 f = new Form1();//sign in
                f.Show();
            }
            else
            {
                MessageBox.Show("you should complete all information");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f=new Form1();
            f.Show();

        }
    }
}

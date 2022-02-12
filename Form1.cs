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
    public partial class Form1 : Form
    {
        public static string email;
        public static string password;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = textBox1.Text;
            password = textBox2.Text;
            if (email == "erenyjoseph@gmail.com" && password == "123456" || email == "erenyyacoub@gmail.com" && password == "123456" || email == "mohamedmoniem@gmail.com" && password == "123456")
            {
                //yes
                this.Hide();
                Form3 r = new Form3();// home
                r.Show();
            }
            else
            {
                MessageBox.Show("your email or password is worng please write email and password again");
                textBox1.Text = "";
                textBox2.Text = "";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 x = new Form2();//sign up
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

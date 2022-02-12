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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox3.Text == "erenyjoseph@gmail.com" && textBox2.Text == "123456")
            {
                if (textBox6.Text == "981" && textBox4.Text == "41" || textBox4.Text == "1" || textBox4.Text == "35"&& textBox5.Text !="")
                {
                    MessageBox.Show("Booked successfully");
                    this.Hide();
                    Form3 o = new Form3();//home
                    o.Show();

                }
                else if (textBox6.Text == "900" && textBox4.Text == "16" || textBox4.Text == "6" || textBox4.Text == "26" && textBox5.Text != "")
                {
                    MessageBox.Show("Booked successfully");
                    this.Hide();
                    Form3 o = new Form3();//home
                    o.Show();
                }
                else
                {
                    MessageBox.Show("the seat or train isn't avaliable ");

                }
            }
           else if (textBox3.Text == "erenyyacoub@gmail.com" && textBox2.Text == "123456")
            {
                if (textBox6.Text == "981" && textBox4.Text == "41" || textBox4.Text == "1" || textBox4.Text == "35" && textBox5.Text != "")
                {
                    MessageBox.Show("Booked successfully");
                    this.Hide();
                    Form3 o = new Form3();//home
                    o.Show();

                }
                else if (textBox6.Text == "900" && textBox4.Text == "16" || textBox4.Text == "6" || textBox4.Text == "26" && textBox5.Text != "")
                {
                    MessageBox.Show("Booked successfully");
                    this.Hide();
                    Form3 o = new Form3();//home
                    o.Show();
                }
                else
                {
                    MessageBox.Show("the seat or train isn't avaliable ");

                }
            }
            else if (textBox3.Text == "mohamedmoniem@gmail.com" && textBox2.Text == "123456")
            {
                if (textBox6.Text == "981" && textBox4.Text == "41" || textBox4.Text == "1" || textBox4.Text == "35" && textBox5.Text != "")
                {
                    MessageBox.Show("Booked successfully");
                    this.Hide();
                    Form3 o = new Form3();//home
                    o.Show();

                }
                else if (textBox6.Text == "900" && textBox4.Text == "16" || textBox4.Text == "6" || textBox4.Text == "26" && textBox5.Text != "")
                {
                    MessageBox.Show("Booked successfully");
                    this.Hide();
                    Form3 o = new Form3();//home
                    o.Show();
                }
                else
                {
                    MessageBox.Show("the seat or train isn't avaliable please select avaliable seat");

                }
            }
            else
            {
                MessageBox.Show("your email or password is worng please write email and password again");
            }
                 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 p1 = new Form3();//home
            p1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 p2 = new Form5();//search
            p2.Show();
        }
    }
}

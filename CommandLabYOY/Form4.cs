using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandLabYOY
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}

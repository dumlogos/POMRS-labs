using System;
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double sub(double a, double b)
        {
            return a - b;
        }

        public static double mult(double a, double b)
        {
            return a * b;
        }

        public static double div(double a, double b)
        {
            return a / b;
        }

        public static double pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double root(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public static double cos(double a)
        {
            return Math.Cos(a);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(cos(Convert.ToDouble(fo_textBox.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(root(Convert.ToDouble(fo_textBox.Text), Convert.ToDouble(so_textBox.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(pow(Convert.ToDouble(fo_textBox.Text), Convert.ToDouble(so_textBox.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(div(Convert.ToDouble(fo_textBox.Text), Convert.ToDouble(so_textBox.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(mult(Convert.ToDouble(fo_textBox.Text), Convert.ToDouble(so_textBox.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(sub(Convert.ToDouble(fo_textBox.Text), Convert.ToDouble(so_textBox.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_textBox.Text = Convert.ToString(sum(Convert.ToDouble(fo_textBox.Text), Convert.ToDouble(so_textBox.Text)));
        }
    }
}

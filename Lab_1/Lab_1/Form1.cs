using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deg_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OK_button_Click(sender, e);
            }
            if((e.KeyChar >='0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (deg_textBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    OK_button.Focus();
                return;
            }
            e.Handled = true;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            double deg; //Градусы
            double rad; //Радианы
            try
            {
                deg = Convert.ToDouble(deg_textBox.Text);
                rad = deg * Math.PI/180.0;
                Console.WriteLine(rad);
                rad_textBox.Text = rad.ToString("0.00000") + " рад";
            }
            catch
            {
                deg_label.Focus();
            }
        }
    }
}

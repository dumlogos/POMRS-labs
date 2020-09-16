using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bFileOpen_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                String file_name = openFD.FileName;
                toolStripStatusLabel1.Text = file_name;
                rtbText.LoadFile(file_name);
            }
        }

        private void bFileSave_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                String file_name = saveFD.FileName;
                toolStripStatusLabel1.Text = file_name;
                rtbText.SaveFile(file_name);
            }
        }

        private void bFileNew_Click(object sender, EventArgs e)
        {
            if (rtbText.TextLength > 0)
                if (MessageBox.Show("Сохранить содержимое окна редактирования?", "Запрос сохранения файла",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bFileSave_Click(sender, e);
            rtbText.Clear();
            toolStripStatusLabel1.Text = "Без имени";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            bFileNew_Click(sender, e);
            Close();
        }

        private void bFileClose_Click(object sender, EventArgs e)
        {
            if (rtbText.TextLength > 0 && toolStripStatusLabel1.Text == "Без имени")
                bFileSave_Click(sender, e);
            else
            {
                rtbText.SaveFile(toolStripStatusLabel1.Text);
                rtbText.Clear();
                toolStripStatusLabel1.Text = "Без имени";
            }
        }

        private void bCut_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            About form_about = new About();
            form_about.ShowDialog();
        }

        private void инструментальнаяПанельToolStripItem_Click(object sender, EventArgs e)
        {
            инструментальнаяПанельToolStripMenuItem.Checked = !инструментальнаяПанельToolStripMenuItem.Checked;
            pToolBar.Visible = инструментальнаяПанельToolStripMenuItem.Checked;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку №1!", "Нажатие №1", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку №2!", "Нажатие №2", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void форма2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Форма1 программа = new Форма1();
            программа.ShowDialog();
        }
    }
}

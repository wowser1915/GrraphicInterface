using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Форма2 пушистик = new Форма2();
            пушистик.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Форма1 розыск = new Форма1();
            розыск.ShowDialog();
        }
    }
}

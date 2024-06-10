using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items.Cast<object>().ToArray());
            listBox2.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedItem = null;
            textBox1.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                while (listBox1.SelectedItems.Count != 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Выберите пункт");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                while (listBox2.SelectedItems.Count != 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItems[0]);
                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Выберите пункт");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
    }
}

﻿using System;
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
    public partial class Форма1 : Form
    {
        public Форма1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку №3!", "Нажатие №3", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}

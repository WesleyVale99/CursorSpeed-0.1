﻿using System;
using System.Windows.Forms;

namespace CursorSpeed_0._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            DialogResult = DialogResult.OK;
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Length.ToString() + " / 500";
        }
    }
}

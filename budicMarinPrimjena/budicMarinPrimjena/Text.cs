﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinPrimjena
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void Text_Load(object sender, EventArgs e)
        {

        }

        private void Text_FormClosing(object sender, FormClosingEventArgs e)
        {
           
               
           
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

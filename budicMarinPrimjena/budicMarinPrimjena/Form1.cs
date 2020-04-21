using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace budicMarinPrimjena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Paint");
            comboBox1.Items.Add("Notepad");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void TextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Text form = new Text();
            form.Show();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (comboBox1.SelectedItem.ToString() == "Paint") Process.Start(@"C:\Windows\system32\mspaint.exe");
            if (comboBox1.SelectedItem.ToString() == "Notepad") Process.Start("Notepad.exe");
        }

        private void TextBoxProgramDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxProgramName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxProgramDescription.Clear();
            textBoxProgramName.Clear();
=======
            if (comboBox1.SelectedIndex == 0)
            {
                Process.Start(@"C:\Windows\system32\mspaint.exe");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Process.Start(@"C:\Windows\system32\notepad.exe");
            }
>>>>>>> 60f1f372396bb7b1a82cb54cf68188c7697d67bf
        }
    }
}

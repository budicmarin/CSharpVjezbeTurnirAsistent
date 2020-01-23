using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinWindowsForm
{
    public partial class budicMarinRatioButton : Form
    {
        public budicMarinRatioButton()
        {
            InitializeComponent();
        }

        private void ButtonRezerviraj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (radioButtonAvion.Checked)
                textBox1.Text="Odabrali ste prijevoz avionom";
            else if (radioButtonAutobus.Checked)
                textBox1.Text="Odabrali ste prijevoz Autobusom";
            else if (radioButtonVlastiti.Checked)
                textBox1.Text="Odabrali ste vlastiti prijevoz";
            else
            {
                MessageBox.Show("Odaberite tip vozila");
                return;
            }
        }
    }
}

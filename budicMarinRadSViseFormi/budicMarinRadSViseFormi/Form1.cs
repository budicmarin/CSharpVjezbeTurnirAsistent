using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinRadSViseFormi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            FormUnosNovogStudenta frm = new FormUnosNovogStudenta();
            DialogResult rez = frm.ShowDialog();
            // unos novog studenta u listBox
            if (rez == System.Windows.Forms.DialogResult.OK)
                listBoxStudenti.Items.Add(frm.Student1.ToString());

        }

        private void ButtonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }

        private void ButtonObrisiStudenta_Click(object sender, EventArgs e)
        {
            // brisanje odabranog reda iz listBox-a
            if (!(listBoxStudenti.SelectedIndex < 0))
                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);

        }
    }
}

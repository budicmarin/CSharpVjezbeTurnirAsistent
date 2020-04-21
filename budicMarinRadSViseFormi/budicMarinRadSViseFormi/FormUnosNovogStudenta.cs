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
    public partial class FormUnosNovogStudenta : Form
    {
        private Student student1;
        public Student Student1
        {
            get
            {
                return student1;
            }
            set
            {
                student1 = value;
            }
        }


        public FormUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSpremi_Click(object sender, EventArgs e)
        {
            // kreiranje novog objekta tipa Student
            student1 = new Student();
            // pristup odgovarajucim atrubutima klase Student
            student1.Ime = textBoxIme.Text;
            student1.Prezime = textBoxPrezime.Text;
            student1.BrojIndeksa = textBoxBrojIndexa.Text;
            student1.Smjer = comboBoxSmjer.SelectedItem.ToString();
            student1.DatumRodjenja = dateTimePickerDatumRodjenja.Value;
            DialogResult = DialogResult.OK;

        }

        private void ButtonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void DateTimePickerDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxBrojIndexa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

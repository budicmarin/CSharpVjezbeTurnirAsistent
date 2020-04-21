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

namespace budicMarinKlasaProces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonWord_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }

        private void ButtonIExplorer_Click(object sender, EventArgs e)
        {

            Process.Start("IExplore.exe");
        }

        private void ButtonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void ButtonStartInfo_Click(object sender, EventArgs e)
        {
            // novi objekt klase ProcessStartInfo 
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);

        }
    }
}

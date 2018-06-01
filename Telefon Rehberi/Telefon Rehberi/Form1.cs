using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        KayitEkleme frm = new KayitEkleme();
        KayitListeleme Listeleme = new KayitListeleme();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme.ShowDialog();
        }
    }
}

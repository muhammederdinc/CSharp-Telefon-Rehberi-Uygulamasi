using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{

    public partial class KayitEkleme : Form
    {
        

        StreamReader Dosya;
        public KayitEkleme()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_ad.Text == "" || textBox_soyad.Text == "" || textBox_tel.Text == "")
            {
                MessageBox.Show("Metin Kutuları Boş Bırakılamaz...", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(comboBox_ad.Text == "" || comboBox_soyad.Text == "" || comboBox_tel.Text == "")
            {
                MessageBox.Show("Renk Seçme İşlemleri Yapılmalıdır...", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else { 
            string isim_renk="", soyisim_renk="", tel_renk="";
            if (comboBox_ad.Text == "Kırmızı")
                isim_renk = "K";
            else if (comboBox_ad.Text == "Mavi")
                isim_renk = "M";
            else if (comboBox_ad.Text == "Yeşil")
                    isim_renk = "Y";
            if (comboBox_soyad.Text == "Kırmızı")
                soyisim_renk = "K";
            else if (comboBox_soyad.Text == "Mavi")
                soyisim_renk = "M";
            else if (comboBox_soyad.Text == "Yeşil")
                    soyisim_renk = "Y";
            if (comboBox_tel.Text == "Kırmızı")
                tel_renk = "K";
            else if (comboBox_tel.Text == "Mavi")
                tel_renk = "M";
            else if (comboBox_tel.Text == "Yeşil")
                tel_renk = "Y";

            string Kisi_Kayit= isim_renk + soyisim_renk + tel_renk + "_" + textBox_ad.Text + "_" + textBox_soyad.Text + "_" + textBox_tel.Text;

            StreamWriter dosyayayaz = File.AppendText(@"...\veriler.txt");
            dosyayayaz.WriteLine(Kisi_Kayit);
            dosyayayaz.Flush();
            dosyayayaz.Close();
            MessageBox.Show("Kişi Rehbere Eklendi.", "Kayıt İşlemi Onaylandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
            }

        }

        private void textBox_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
           switch(e.KeyChar)
            {
                case'1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System;
using System.Windows;


namespace Telefon_Rehberi
{
    public partial class KayitListeleme : Form
    {
        public KayitListeleme()
        {
            InitializeComponent();
        }

        private void KayitListeleme_Load(object sender, EventArgs e)
        {

            StreamReader oku = new StreamReader(@"...\veriler.txt");
      

            while (oku.Peek() != -1)
            {

                // Burada Txt belgesindeki verileri satır satır diziye atıyoruz.

                string Satiroku = oku.ReadLine();
                string[] satirlar = Satiroku.Split('\n');



            //Satırları diziye attıktan sonra isim soyisim tel ve renkleri diziye atıyoruz.
            string kelime = satirlar[0];
            string[] parcalar;
            parcalar = kelime.Split('_'); // İsim Kısmına 2 İsim Girilebilme ihtimaline karşı isim soyisim tel araları "_" ile ayrılmıştır.

                string isim, soyad, tel,renk; 
               
                isim = parcalar[1];
                soyad = parcalar[2];
                tel = parcalar[3];

                //MessageBox.Show(parcalar[1] + " " + parcalar[2] + " " + parcalar[3]);
            
             


            int parca1, parca2, parca3;
            parca1 = parcalar[1].Length;
            parca2 = parcalar[2].Length + 1;
            parca3 = parcalar[3].Length + 1;

          
            if (parcalar[0].Substring(0, 1) == "M")
            {
                       richTextBox1.SelectionColor = Color.Blue;
                      richTextBox1.SelectedText = isim + " ";
                       }
            if (parcalar[0].Substring(0, 1) == "K")
            {
                 
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectedText = isim + " ";

                }
            if (parcalar[0].Substring(0, 1) == "Y")
            {
                  
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.SelectedText = isim + " ";

                }
            if (parcalar[0].Substring(1, 1) == "M")
            {
                 
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.SelectedText = soyad + " ";

                }
            if (parcalar[0].Substring(1, 1) == "K")
            {
             
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectedText = soyad + " ";

                }
           if (parcalar[0].Substring(1, 1) == "Y")
            {
                    
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.SelectedText = soyad + " ";

                }
            if (parcalar[0].Substring(2, 1) == "M")
            {
                   
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.SelectedText = tel + "\n";

                }
            if (parcalar[0].Substring(2, 1) == "K")
            {
                 
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectedText = tel + "\n";

                }
           if (parcalar[0].Substring(2, 1) == "Y")
            {
           
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.SelectedText = tel + "\n";

                }
           
                    
                    // Bir Satır Kalın Bir Satır Normal Yazdırmak İçin Kullanılan Kod:
            for (int a=0; a<richTextBox1.Lines.Length; a++) {

                        if(a % 2 == 0){
                    int basla = richTextBox1.GetFirstCharIndexFromLine(a);
                    int uzunluk = richTextBox1.Lines[a].Length;
                    richTextBox1.Select(basla,uzunluk);
                    richTextBox1.SelectionFont= new Font(this.Font, FontStyle.Bold);
                                      }
                        else {

                        int basla = richTextBox1.GetFirstCharIndexFromLine(a);
                    int uzunluk = richTextBox1.Lines[a].Length;
                    richTextBox1.Select(basla,uzunluk);
                    richTextBox1.SelectionFont= new Font(this.Font, FontStyle.Regular);




                              }



                
                    }

               

            }
            oku.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


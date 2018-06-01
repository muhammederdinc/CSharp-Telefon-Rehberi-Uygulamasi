namespace Telefon_Rehberi
{
    partial class KayitEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_ad = new System.Windows.Forms.ComboBox();
            this.comboBox_soyad = new System.Windows.Forms.ComboBox();
            this.comboBox_tel = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon Nu:";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(100, 29);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(149, 20);
            this.textBox_ad.TabIndex = 1;
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Location = new System.Drawing.Point(100, 60);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(149, 20);
            this.textBox_soyad.TabIndex = 1;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(100, 91);
            this.textBox_tel.MaxLength = 11;
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(149, 20);
            this.textBox_tel.TabIndex = 1;
            this.textBox_tel.TextChanged += new System.EventHandler(this.textBox_tel_TextChanged);
            this.textBox_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tel_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox_ad
            // 
            this.comboBox_ad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ad.Items.AddRange(new object[] {
            "Mavi",
            "Kırmızı",
            "Yeşil"});
            this.comboBox_ad.Location = new System.Drawing.Point(274, 28);
            this.comboBox_ad.Name = "comboBox_ad";
            this.comboBox_ad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ad.TabIndex = 4;
            // 
            // comboBox_soyad
            // 
            this.comboBox_soyad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_soyad.FormattingEnabled = true;
            this.comboBox_soyad.Items.AddRange(new object[] {
            "Mavi",
            "Kırmızı",
            "Yeşil"});
            this.comboBox_soyad.Location = new System.Drawing.Point(274, 59);
            this.comboBox_soyad.Name = "comboBox_soyad";
            this.comboBox_soyad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_soyad.TabIndex = 4;
            // 
            // comboBox_tel
            // 
            this.comboBox_tel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tel.FormattingEnabled = true;
            this.comboBox_tel.Items.AddRange(new object[] {
            "Mavi",
            "Kırmızı",
            "Yeşil"});
            this.comboBox_tel.Location = new System.Drawing.Point(274, 91);
            this.comboBox_tel.Name = "comboBox_tel";
            this.comboBox_tel.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tel.TabIndex = 4;
            // 
            // KayitEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 330);
            this.Controls.Add(this.comboBox_tel);
            this.Controls.Add(this.comboBox_soyad);
            this.Controls.Add(this.comboBox_ad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "KayitEkleme";
            this.Text = "Kayıt Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_ad;
        private System.Windows.Forms.ComboBox comboBox_soyad;
        private System.Windows.Forms.ComboBox comboBox_tel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
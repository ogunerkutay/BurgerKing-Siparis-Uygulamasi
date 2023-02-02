using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKing_Siparis_Uygulamasi
{
    public partial class Siparis_Olustur : Form
    {
        public Siparis_Olustur()
        {
            InitializeComponent();
        }
        Siparis yeniSiparis;
        AnaEkran anaEkran;
        private void Siparis_Olustur_Load(object sender, EventArgs e)
        {
            yeniSiparis = new Siparis();
            numericUpDownAdet.Minimum = 1;

            anaEkran = (AnaEkran)this.MdiParent;

            foreach (Menu menu in anaEkran.menuler)
            {
                comboBoxMenuler.Items.Add(menu.Name);     
                comboBoxMenuler.SelectedIndex = 0;
            }
            radioButtonOrta.Checked = true;

            flowLayoutPanel1.SuspendLayout();
            foreach (EkstraMalzeme ekstraMalzeme in anaEkran.ekstraMalzemeler)
            {
                CheckBox check = new CheckBox();
                check.Text = ekstraMalzeme.EkstraName;
                flowLayoutPanel1.Controls.Add(check);
            }
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.PerformLayout();

        }

        private void buttonSiparisEkle_Click(object sender, EventArgs e)
        {
            
            Menu menu = anaEkran.menuler.FirstOrDefault(o => o.Name == comboBoxMenuler.Text);
            
            foreach (RadioButton radioButton in groupBoxBoyutlar.Controls)
            {
                if (radioButton.Checked)
                {
                    menu.Boyut = radioButton.Text;
                }
                
            }

            menu.Adet = (int)numericUpDownAdet.Value;

            double ekstraMalzemeToplami = 0;
            foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
            {
                if (checkBox.Checked)
                {
                    EkstraMalzeme ekstraMalzeme = anaEkran.ekstraMalzemeler.FirstOrDefault(o => o.EkstraName == checkBox.Text);
                    menu.EkstraMalzemeler.Add(ekstraMalzeme);
                    ekstraMalzemeToplami += ekstraMalzeme.EkstraFiyat;
                }
            }

            double boyutCarpani = 1;
            switch (menu.Boyut)
            {
                case "Küçük":
                    boyutCarpani = 0.8;
                    break;
                case "Orta":
                    boyutCarpani = 1;
                    break;
                case "Büyük":
                    boyutCarpani = 1.5;
                    break;
            }

            
            menu.ToplamFiyat = (menu.Fiyat * boyutCarpani * menu.Adet) + ekstraMalzemeToplami;
            yeniSiparis.Menuler.Add(menu);




            int siparisAdedi = 0;
            int satilanUrunAdedi = 0;
            double ciro = 0;
            double ekstraMalzemeGeliri = 0;

            StringBuilder sb = new StringBuilder();

            sb.Append(menu.Name);
            sb.Append(" ");
            sb.Append(menu.Boyut);
            sb.Append(" boy ");
            sb.Append(menu.Adet);
            sb.Append(" adet");

            foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
            {
                if (checkBox.Checked)
                {
                    sb.Append(" ekstra ");
                    sb.Append(checkBox.Text);
                }
            }

            sb.Append(" toplam ");
            sb.Append(menu.ToplamFiyat);
            sb.Append(" TL");
            
            listBox1.Items.Add(sb);
            yeniSiparis.ToplamFiyat += menu.ToplamFiyat;
            labelMasraf.Text = yeniSiparis.ToplamFiyat.ToString() + " TL";

            radioButtonOrta.Checked = true;
            numericUpDownAdet.Value = 1;

            foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
            {
                checkBox.Checked = false;
            }

        }

        private void buttonSiparisiTamamla_Click(object sender, EventArgs e)
        {

            DialogResult siparisiTamamla = new DialogResult();
            siparisiTamamla = MessageBox.Show($"Toplam sipariş tutarı {yeniSiparis.ToplamFiyat} TL\nSiparişi tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo);

            if (siparisiTamamla == DialogResult.Yes)
            {

                anaEkran.siparisler.Add(yeniSiparis);
                yeniSiparis = new Siparis();

                radioButtonOrta.Checked = true;
                numericUpDownAdet.Value = 1;

                foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
                {
                    checkBox.Checked = false;
                }

                listBox1.Items.Clear();

                labelMasraf.Text = String.Empty;

                MessageBox.Show("Siparişiniz tamamlandı");
            }


        }
    }
}

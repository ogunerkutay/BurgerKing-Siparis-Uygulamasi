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
    public partial class Siparis_Bilgileri : Form
    {
        public Siparis_Bilgileri()
        {
            InitializeComponent();

        }
        ToolTip _toolTip;
        private void Siparis_Bilgileri_Load(object sender, EventArgs e)
        {
            _toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };

            AnaEkran anaEkran = (AnaEkran)this.MdiParent;

            int satilanUrunAdedi = 0;
            double ciro = 0;
            double ekstraMalzemeGeliri = 0;

            StringBuilder sb;


            foreach (Siparis siparis in anaEkran.siparisler)
            {

                foreach (Menu menu in siparis.Menuler)
                {
                    sb = new StringBuilder();
                    sb.Append(menu.Name);
                    sb.Append(" ");
                    sb.Append(menu.Boyut);
                    sb.Append(" boy ");
                    sb.Append(menu.Adet);
                    sb.Append(" adet");

                    foreach (EkstraMalzeme ekstraMalzeme in menu.EkstraMalzemeler)
                    {

                        sb.Append(" ekstra ");
                        sb.Append(ekstraMalzeme.EkstraName);

                        ekstraMalzemeGeliri += ekstraMalzeme.EkstraFiyat;
                    }
                    sb.Append(" toplam ");
                    sb.Append(menu.ToplamFiyat);

                    sb.Append(" TL");

                    listBox1.Items.Add(sb);

                    satilanUrunAdedi += menu.Adet;


                }
                ciro += siparis.ToplamFiyat;


            sb = null;
            GC.Collect();
            }

            labelCiro.Text = ciro.ToString() + " TL";
            labelEkstraMalzeme.Text = ekstraMalzemeGeliri.ToString() + " TL";
            labelSatilanUrunAdedi.Text = satilanUrunAdedi.ToString();
            labelToplamSiparis.Text = anaEkran.siparisler.Count.ToString();
        
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var listbox = sender as ListBox;
            if (listbox == null) return;

            // set tool tip for listbox
            var strTip = string.Empty;
            var index = listbox.IndexFromPoint(e.Location);

            if ((index >= 0) && (index < listbox.Items.Count))
                strTip = listbox.Items[index].ToString();

            if (_toolTip.GetToolTip(listbox) != strTip)
            {
                _toolTip.SetToolTip(listbox, strTip);
            }

        }
    }
}

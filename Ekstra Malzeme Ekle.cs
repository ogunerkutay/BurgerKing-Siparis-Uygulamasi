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
    public partial class Ekstra_Malzeme_Ekle : Form
    {
        public Ekstra_Malzeme_Ekle()
        {
            InitializeComponent();
        }
        AnaEkran anaEkran;
        private void Ekstra_Malzeme_Ekle_Load(object sender, EventArgs e)
        {
            numericUpDownEkstraFiyat.Increment = 0.1m;
            numericUpDownEkstraFiyat.Minimum = 0.1m;
            anaEkran = (AnaEkran)this.MdiParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textBoxEkstra.Text))
            {

                EkstraMalzeme yeniEkstraMalzeme = new EkstraMalzeme();
                yeniEkstraMalzeme.EkstraName = textBoxEkstra.Text;
                yeniEkstraMalzeme.EkstraFiyat = (double)numericUpDownEkstraFiyat.Value;
                anaEkran.ekstraMalzemeler.Add(yeniEkstraMalzeme);
            }
        }
    }
}

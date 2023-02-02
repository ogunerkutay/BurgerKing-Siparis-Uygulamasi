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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        public List<Siparis> siparisler;
        public List<Menu> menuler;
        public List<EkstraMalzeme> ekstraMalzemeler;
        int formBorderWidthOffset;
        int formBorderandCaptionHeightOffset;

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            siparisler = new List<Siparis>();

            MenuleriYukle();
            EkstralariYukle();

            formBorderWidthOffset = (SystemInformation.Border3DSize.Width * 2);
            formBorderandCaptionHeightOffset = (SystemInformation.CaptionHeight + SystemInformation.Border3DSize.Height * 2 + SystemInformation.BorderSize.Width);
        }

        private void EkstralariYukle()
        {
            ekstraMalzemeler = new List<EkstraMalzeme>();
            EkstraMalzeme ketcap = new EkstraMalzeme();
            ketcap.EkstraName = "Ketçap";
            ketcap.EkstraFiyat = 0.5;
            ekstraMalzemeler.Add(ketcap);
            EkstraMalzeme mayonez = new EkstraMalzeme();
            mayonez.EkstraName = "Mayonez";
            mayonez.EkstraFiyat = 0.5;
            ekstraMalzemeler.Add(mayonez);
            EkstraMalzeme Hardal = new EkstraMalzeme();
            Hardal.EkstraName = "Hardal";
            Hardal.EkstraFiyat = 0.5;
            ekstraMalzemeler.Add(Hardal);
            EkstraMalzeme bbq = new EkstraMalzeme();
            bbq.EkstraName = "BBQ";
            bbq.EkstraFiyat = 0.5;
            ekstraMalzemeler.Add(bbq);
            EkstraMalzeme ranch = new EkstraMalzeme();
            ranch.EkstraName = "Ranch";
            ranch.EkstraFiyat = 0.5;
            ekstraMalzemeler.Add(ranch);
            EkstraMalzeme buffalo = new EkstraMalzeme();
            buffalo.EkstraName = "Buffalo";
            buffalo.EkstraFiyat = 0.5;
            ekstraMalzemeler.Add(buffalo);

        }

        private void MenuleriYukle()
        {
            menuler = new List<Menu>();
            Menu bigKing = new Menu();
            bigKing.Name = "Big King Menü";
            bigKing.Boyut = "Orta";
            bigKing.Adet = 1;
            bigKing.Fiyat = 15;
            bigKing.ToplamFiyat = 15;
            menuler.Add(bigKing);
            Menu doubleKingChicken = new Menu();
            doubleKingChicken.Name = "Double King Chicken Menü";
            doubleKingChicken.Boyut = "Orta";
            doubleKingChicken.Adet = 1;
            doubleKingChicken.Fiyat = 20;
            doubleKingChicken.ToplamFiyat = 20;
            menuler.Add(doubleKingChicken);
            Menu steakhouse = new Menu();
            steakhouse.Name = "Steakhouse Menü";
            steakhouse.Boyut = "Orta";
            steakhouse.Adet = 1;
            steakhouse.Fiyat = 18;
            steakhouse.ToplamFiyat= 18;
            menuler.Add(steakhouse);
            Menu whooper = new Menu();
            whooper.Name = "Whooper Menü";
            whooper.Boyut = "Orta";
            whooper.Adet = 1;
            whooper.Fiyat = 16;
            whooper.ToplamFiyat= 16;
            menuler.Add(whooper);
            Menu whooperJr = new Menu();
            whooperJr.Name = "Whooper Jr Menü";
            whooperJr.Boyut = "Orta";
            whooperJr.Adet = 1;
            whooperJr.Fiyat = 8;
            whooperJr.ToplamFiyat = 8;
            menuler.Add(whooperJr);
            Menu chickenRoyal = new Menu();
            chickenRoyal.Name = "Chicken Royal Menü";
            chickenRoyal.Boyut = "Orta";
            chickenRoyal.Adet = 1;
            chickenRoyal.Fiyat = 12;
            chickenRoyal.ToplamFiyat = 12;
            menuler.Add(chickenRoyal);
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparis_Olustur form = new Siparis_Olustur();
            form.MdiParent = this;
            this.SetClientSizeCore(form.Width + formBorderWidthOffset, form.Height + formBorderandCaptionHeightOffset);
            form.Dock = DockStyle.Fill;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Activate();
            CloseChildren();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparis_Bilgileri form = new Siparis_Bilgileri();
            form.MdiParent = this;
            this.SetClientSizeCore(form.Width + formBorderWidthOffset, form.Height + formBorderandCaptionHeightOffset);
            form.Dock = DockStyle.Fill;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Activate();
            CloseChildren();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Ekle form = new Menu_Ekle();
            form.MdiParent = this;
            this.SetClientSizeCore(form.Width + formBorderWidthOffset, form.Height + formBorderandCaptionHeightOffset);
            form.Dock = DockStyle.Fill;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Activate();
            CloseChildren();
        }
        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ekstra_Malzeme_Ekle form = new Ekstra_Malzeme_Ekle();
            form.MdiParent = this;
            this.SetClientSizeCore(form.Width + formBorderWidthOffset, form.Height + formBorderandCaptionHeightOffset);
            form.Dock = DockStyle.Fill;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Activate();
            CloseChildren();

        }

        private void CloseChildren()
        {
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }



    } 
}

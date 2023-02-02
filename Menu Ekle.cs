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
    public partial class Menu_Ekle : Form
    {
        public Menu_Ekle()
        {
            InitializeComponent();
        }

        AnaEkran anaEkran;
        private void Menu_Ekle_Load(object sender, EventArgs e)
        {
            numericUpDownFiyat.Increment = 0.5m;
            numericUpDownFiyat.Minimum = 5m;
            anaEkran = (AnaEkran)this.MdiParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxMenu.Text))
            {

                Menu yeniMenu = new Menu();
                yeniMenu.Name = textBoxMenu.Text;
                yeniMenu.Boyut = "orta";
                yeniMenu.Adet = 1;
                yeniMenu.Fiyat = (double)numericUpDownFiyat.Value;
                anaEkran.menuler.Add(yeniMenu);
            }
        }
    }
}

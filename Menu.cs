using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKing_Siparis_Uygulamasi
{
    public class Menu
    {

        public Menu()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }


        private string name;
        private string boyut;
        private int adet;
        private double fiyat;
        private double toplamFiyat;


        public string Name { get => name; set => name = value; }
        public string Boyut { get => boyut; set => boyut = value; }
        public int Adet { get => adet; set => adet = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }

        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public double ToplamFiyat { get => toplamFiyat; set => toplamFiyat = value; }
    }
}

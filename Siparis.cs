using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKing_Siparis_Uygulamasi
{
    public class Siparis
    {
        public Siparis()
        {
            Menuler = new List<Menu>();
        }

        private double toplamFiyat;

        public List<Menu> Menuler { get ; set ; }
        public double ToplamFiyat { get => toplamFiyat; set => toplamFiyat = value; }
    }
}

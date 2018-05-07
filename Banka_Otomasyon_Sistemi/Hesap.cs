using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public class Hesap
    {
        public int HesapNo { get; set; }
        private const decimal ekhesap = 500;
        public decimal Bakiye { get; set; }
        public decimal Ekhesap = ekhesap;

        public List<HesapOzet> OzetListesi;

        public void HesapNoAta()
        {
            Random r = new Random();
            this.HesapNo = r.Next(10000, 100000);
        }
             
        public void OzetEkle(HesapOzet Hesapozeti)
        {
            OzetListesi.Add(Hesapozeti);

        }

        public Hesap()
        {
            OzetListesi = new List<HesapOzet>(); // Hesap ile HesapOzeti arasında Composition ilişki vardır.
        }
    }
}

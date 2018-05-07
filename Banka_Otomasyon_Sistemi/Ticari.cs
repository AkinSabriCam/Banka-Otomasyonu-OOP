using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public class Ticari : Musteri
    {      
        public override string Havale(Hesap gonderen, Hesap alan, decimal tutar, Musteri AlanMusteri, Musteri GonderenMusteri)
        {
            string gtr = "no";
            if (gonderen.Bakiye > tutar || gonderen.Bakiye == tutar)
            {
                HesapOzet HesapOzeti = new HesapOzet();
                HesapOzet HesapOzeti1 = new HesapOzet();
                DateTime tarih;

                gonderen.Bakiye -= tutar;
                alan.Bakiye += tutar;

                System.Windows.Forms.MessageBox.Show("Havale İşlemi Gerçekleştirilmiştir.");

                tarih = DateTime.Now;
                HesapOzeti.Tarih = tarih;
                HesapOzeti.Tutar = tutar;
                HesapOzeti.IslemTipi = "Havale (+)";
                HesapOzeti.GonderenKisi = GonderenMusteri.Ad + " " + GonderenMusteri.Soyad;
                alan.OzetEkle(HesapOzeti);

                HesapOzeti1.Tarih = tarih;
                HesapOzeti1.Tutar = tutar;
                HesapOzeti1.IslemTipi = "Havale (-)";
                HesapOzeti1.AlanKisi = AlanMusteri.Ad + " " + AlanMusteri.Soyad;
                gonderen.OzetEkle(HesapOzeti1);
            }
            else   System.Windows.Forms.MessageBox.Show("Havale İşlemi İçin Bakiye Yetersizdir!");
            return gtr;
        }
    }
}

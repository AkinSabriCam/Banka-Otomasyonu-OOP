using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public class Bireysel : Musteri
    {
        public override string Havale(Hesap gonderen,Hesap alan,decimal tutar,Musteri AlanMusteri,Musteri GonderenMusteri)
        {
            HesapOzet HesapOzeti = new HesapOzet();
            HesapOzet HesapOzeti1 = new HesapOzet();

            DateTime tarih;
            decimal islemucreti;
            decimal deger;

            string gtr="";

            islemucreti = tutar * 0.02m;
            deger = tutar + islemucreti;

            if (gonderen.Bakiye > deger || gonderen.Bakiye == deger)
            {
                gonderen.Bakiye -= tutar + islemucreti;
                alan.Bakiye += tutar;

                gtr = islemucreti.ToString();
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

            else
            {
                System.Windows.Forms.MessageBox.Show("Havale İşlemi İçin Bakiye Yetersizdir!");
                gtr = "no";
            }
            return gtr;
        }
        

    }
}

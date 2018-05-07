using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public class Banka
    {
        public decimal HesaplardakiPara { get; set; }   //Hesaplardaki Paralar
        public decimal Gelir { get; set; }              //Yatırılan Paralar, Havale Ücreti 
        public decimal Gider { get; set; }              //Çekilen Paralar
        public decimal Kasa { get; set; }               //Gelir ve Hesaplardaki Para

        public List<Musteri> Musteriler;

        public void MusteriEkleme(Musteri m)
        {
            Musteriler.Add(m);
        }
        public void MusteriSil(string nos)
        {
            foreach (Musteri m2 in Musteriler)
            {
                if (m2.MusteriNo == nos)
                {
                    Musteriler.Remove(m2);
                    System.Windows.Forms.MessageBox.Show("Müşteri Silindi.");
                    break;
                }
            }
        }
        public void ParaCekmeIslemi(string musterino,int hesapno,decimal miktar)
        {
            string str = "";
            foreach (Musteri m in Musteriler)
            {
                if (m.MusteriNo == musterino)
                {
                    if(miktar>750)  System.Windows.Forms.MessageBox.Show("Günlük Para Çekme Limitini Aştınız!");
                    else   str = m.ParaCek(hesapno, miktar);
                }
                if (str == "okey")
                    Gider += miktar;                                       
            }
        }
        public void ParaYatirmaİslemi(string musterino,int hesapno,decimal miktar)
        {
            foreach (Musteri m in Musteriler)
            {
                if (m.MusteriNo == musterino)
                {
                    m.ParaYatirma(hesapno, miktar);
                    Gelir += miktar;
                }

            }
        }
        public void ParaHavaleİslemi(int gonderenhesap, int alanhesap, decimal miktar)
        {

            Hesap gonderen = new Hesap();
            Hesap alan = new Hesap();

            foreach (Musteri m in Musteriler)
            {
                foreach (Hesap h in m.Hesaplar)
                {
                    if (h.HesapNo == gonderenhesap) gonderen = h;
                    else if (h.HesapNo == alanhesap) alan = h;
                }

                foreach (Hesap h in m.Hesaplar)
                {
                    string gtr = "";
                    if (h.HesapNo == alanhesap)
                    {
                        foreach (Musteri m1 in Musteriler)
                        {
                            foreach (Hesap h1 in m1.Hesaplar)
                            {
                                if (h1.HesapNo == gonderenhesap)
                                {
                                    gonderen = h1;
                                    gtr=m.Havale(gonderen, alan, miktar, m, m1);
                                    if (gtr != "no")
                                    {
                                        Gelir += Convert.ToDecimal(gtr);
                                        Kasa += Convert.ToDecimal(gtr);
                                    }
                                }          
                            }
                        }
                    }
                }
            }
        }
        public string MusteriNoSorgula(Musteri m1)
        {
            string str = "";

            foreach (Musteri m in Musteriler)
            {
                if (m1.MusteriNo == m.MusteriNo) str = m.MusteriNo;
            }
            return str;
        }
        public string TCKNSorgula(Musteri m1)
        {
            string str = "";

            foreach (Musteri m in Musteriler)
            {
                if (m1.TCKN == m.TCKN)  str = m.TCKN.ToString();      
            }
            return str;
        }
        public string HesapNoSorgula(int hesapno)
        {
            string str = "";

            foreach (Musteri m in Musteriler)
            {
                foreach (Hesap h in m.Hesaplar)
                {
                    if (hesapno == h.HesapNo)   str = h.HesapNo.ToString();                      
                }
            }
            return str;
        }
        public string HesapNoBulma(string musterino)
        {
            string str = "";
            int sayac = 0;

            foreach (Musteri m in Musteriler)
            {
                if (musterino == m.MusteriNo)
                {
                    foreach (Hesap h in m.Hesaplar)
                    {
                        sayac++;
                        str += sayac.ToString() + ".     Hesap Numarası   :   " + h.HesapNo + "     Bakiye   :   " + h.Bakiye +" TL"+"      Ek Hesap  :  "+h.Ekhesap+" TL"+ Environment.NewLine;
                    }
                }


            }
            return str;
        }

        public void HesapSil(string hesapno)
        {
            foreach (Musteri m in Musteriler)
            {
                foreach (Hesap h in m.Hesaplar)
                {
                    if (hesapno == h.HesapNo.ToString())
                    {
                        m.HesapSil(h);
                        break;
                    }
                }

            }
        }
        public void HesapEkle(string musterino, Hesap h1)
        {
            foreach (Musteri m in Musteriler)
            {
                if (m.MusteriNo == musterino)
                {
                    m.HesapEkle(h1);
                    System.Windows.Forms.MessageBox.Show("Hesap Başarıyla Oluşturuldu.");
                }
            }
        }
        public string MusteriListesi(string musno)
        {
            string str = "";

            foreach (Musteri m in Musteriler)
            {
                if (m.MusteriNo == musno)
                {
                    foreach (Hesap h in m.Hesaplar)
                    {
                        str += h.HesapNo.ToString() + Environment.NewLine;
                    }
                }
            }
            return str;
        }

        public string HesapOzetGoruntule(string hesapno,int baslangic,int bitis)
        {
            int gun;
            string str = "";
            foreach (Musteri m in Musteriler)
            {
                foreach (Hesap h in m.Hesaplar)
                {
                    if (hesapno == h.HesapNo.ToString())
                    {
                        foreach (HesapOzet ho in h.OzetListesi)
                        {
                            gun = ho.Tarih.Day;
                            if((gun==baslangic || gun>baslangic)&& (bitis==gun ||gun<bitis) )
                            {
                                if (ho.GonderenKisi == null)
                                    str += m.Ad + " " + m.Soyad + "                           " + ho.AlanKisi + "                            " + ho.Tutar + " TL                    " + ho.Tarih.ToString("dd.MM.yyyy") + "                   " + ho.IslemTipi + Environment.NewLine;
                                else
                                    str += m.Ad + " " + m.Soyad + "                           " + ho.GonderenKisi + "                             " + ho.Tutar + " TL                       " + ho.Tarih.ToString("dd.MM.yyyy") + "                    " + ho.IslemTipi + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            return str;
        }
        public void HesapBakiyeleri()
        {
            foreach (Musteri m in Musteriler)
            {
                foreach (Hesap h in m.Hesaplar)
                {
                    HesaplardakiPara += h.Bakiye;
                }
            }
            Kasa += HesaplardakiPara;
        }
        public List<Musteri> MusteriListele()
        {
            return Musteriler;
        }
        
        public Banka()
        {
             Musteriler = new List<Musteri>();  // Banka ile Müsteri arasında Composition ilişki vardır.
        }

     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyon_Sistemi
{
    public abstract class Musteri
    {
        public string MusteriNo { get; set; }
        public ulong TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string MusteriTipi { get; set; }
        
        public List<Hesap> Hesaplar;

        public void MusteriNoAta()
        {
            Random ran = new Random();
            int sayi;
            sayi = ran.Next(10000,100000);
            this.MusteriNo = sayi.ToString();
        }
        public string ParaCek(int hesapno, decimal tutar)
        {
            HesapOzet Ozet1 = new HesapOzet();
            DateTime tarih1;
            decimal kalan=0;
            decimal TopPara = 0;

            string str = "";
            foreach(Hesap h1 in Hesaplar)
            {
                if (h1.HesapNo == hesapno)
                {
                    if (h1.Bakiye < 0)  TopPara = h1.Ekhesap;
                        
                    else   TopPara = h1.Bakiye + h1.Ekhesap;

                    if (tutar > TopPara)
                    {
                        System.Windows.Forms.MessageBox.Show("Hesap Limitini Aştınız!");
                        str = "no";
                    }

                    else
                    {
                        if (h1.Bakiye < 0)
                        {
                            h1.Ekhesap = h1.Ekhesap - tutar;
                            h1.Bakiye = h1.Bakiye - tutar;
                        }
                        else
                        {
                            kalan = tutar - h1.Bakiye;
                            if (kalan > 0)
                            {
                                h1.Bakiye = 0 - kalan;
                                h1.Ekhesap = h1.Ekhesap - kalan;
                            }
                            else h1.Bakiye = h1.Bakiye - tutar;
                        }
                        System.Windows.Forms.MessageBox.Show("Para Çekme İşlemi Gerçekleştirilmiştir.");
                        str = "okey";
                        tarih1 = DateTime.Now;
                       
                        Ozet1.IslemTipi = "Para Çekme";
                        Ozet1.Tarih = tarih1;
                        Ozet1.AlanKisi = "-----------------   ";
                        Ozet1.Tutar = tutar;
                        h1.OzetEkle(Ozet1);
                    }
                }
            }
            return str;
        }
        public void ParaYatirma(int hesapno,decimal tutar)
        {
            HesapOzet Ozet2 = new HesapOzet();
            DateTime tarih2;
            decimal kalan = 0;

            foreach (Hesap h1 in Hesaplar)
            {
                if (h1.HesapNo == hesapno)
                {
                    if (h1.Bakiye > 0 || h1.Bakiye == 0)    h1.Bakiye = h1.Bakiye + tutar;   
                                     
                    else
                    {
                        h1.Ekhesap = h1.Ekhesap + tutar;
                        h1.Bakiye = h1.Bakiye + tutar;
                        if (h1.Ekhesap > 500)
                        {
                            kalan = h1.Ekhesap - 500;
                            h1.Ekhesap = h1.Ekhesap - kalan;
                        }         
                    }   
                    System.Windows.Forms.MessageBox.Show("Para Yatırma İşlemi Gerçekleştirilmiştir.");

                    tarih2 = DateTime.Now;
                    Ozet2.IslemTipi = "Para Yatırma";
                    Ozet2.AlanKisi = "-----------------   ";
                    Ozet2.Tarih = tarih2;
                    Ozet2.Tutar = tutar;
                    h1.OzetEkle(Ozet2);
                }
                
            }
        }

        public void HesapSil(Hesap hesap)
        {
            if(hesap.Bakiye==0)
                Hesaplar.Remove(hesap);
            
            else   System.Windows.Forms.MessageBox.Show("Hesap Silmek İçin Bakiye 0 Olmalıdır!");
        }

        public abstract string Havale(Hesap gonderen,Hesap alan,decimal tutar,Musteri AlanMusteri,Musteri GonderenMusteri);
        public void HesapEkle(Hesap h)
        {
            Hesaplar.Add(h);
        }
        
        public Musteri()
        {
            Hesaplar = new List<Hesap>(); // Müşteri ile Hesap arasında Composition ilişki vardır.
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class FormMusteriEkle : Form
    {
        public Banka banka;
        public FormMusteriEkle()
        {
            
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {   
            
            if (rdBireysel.Checked == true)
            {
                Bireysel b1 = new Bireysel();

                if (txtTckn.TextLength < 11)    MessageBox.Show("TC Kimlik Numarası 11 Haneli Olmalıdır!");
                    
                else
                {
                    b1.Ad = txtAd.Text;
                    b1.Soyad = txtSoyad.Text;
                    b1.TCKN = Convert.ToUInt64(txtTckn.Text);

                    if (banka.TCKNSorgula(b1) == b1.TCKN.ToString())
                    {
                        MessageBox.Show("Bu TC Kimlik Numarası Sistemde Kayıtlı!");
                        this.Close();
                    }
                    else
                    {
                        b1.MusteriTipi = rdBireysel.Text;
                        b1.MusteriNoAta();

                        while (banka.MusteriNoSorgula(b1) == b1.MusteriNo)
                        {
                            b1.MusteriNoAta();
                        }
                        banka.MusteriEkleme(b1);
                        lblmusterino.Text = b1.MusteriNo;
                        lblmusterino.Visible = true;
                        lblMno.Visible = true;
                    }
                }
                
            }
            else if (rdTicari.Checked == true)
            {
                Ticari t1 = new Ticari();
                if (txtTckn.TextLength < 11)    MessageBox.Show("TC Kimlik Numarası 11 Haneli Olmalıdır!");
                    
                else
                {
                    t1.Ad = txtAd.Text;
                    t1.Soyad = txtSoyad.Text;
                    t1.TCKN = Convert.ToUInt64(txtTckn.Text);
                    if (banka.TCKNSorgula(t1) == t1.TCKN.ToString())
                    {
                        MessageBox.Show("Bu TC Kimlik Numarası Sistemde Kayıtlı!");
                        this.Close();
                    }
                    else
                    {
                        t1.MusteriTipi = rdTicari.Text;
                        t1.MusteriNoAta();
                        while (banka.MusteriNoSorgula(t1) == t1.MusteriNo)
                        {
                            t1.MusteriNoAta();
                        }
                        banka.MusteriEkleme(t1);
                        lblmusterino.Text = t1.MusteriNo;
                        lblmusterino.Visible = true;
                        lblMno.Visible = true;
                    }
                }
            }
            else   MessageBox.Show("Müşteri Tipini Seçiniz!");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = banka.MusteriListele();
        }

        private void FormMusteriEkle_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = banka.MusteriListele();
        }

        private void txtTckn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

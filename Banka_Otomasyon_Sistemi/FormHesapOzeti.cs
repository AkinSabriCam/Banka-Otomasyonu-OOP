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
    public partial class FormHesapOzeti : Form
    {
        public Banka banka;
        public FormHesapOzeti()
        {
            InitializeComponent();
        }

        private void FormHesapOzeti_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGörüntüleHO_Click(object sender, EventArgs e)
        {
            
            int baslangic = dtpBaslangic.Value.Day;
            int bitis = dtpBitis.Value.Day;
            txtListeHO.Text = "Ad Soyad                     Gönderen/Gönderilen                   Tutar                         Tarih                               İşlem Türü"+Environment.NewLine+banka.HesapOzetGoruntule(txtHesapNoHO.Text,baslangic,bitis);

        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}

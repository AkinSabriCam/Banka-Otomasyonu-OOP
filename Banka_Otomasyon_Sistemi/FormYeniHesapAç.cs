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
    public partial class FormYeniHesapAç : Form
    {
        public Banka banka;
        public FormYeniHesapAç()
        {
            InitializeComponent();
        }

        private void FormYeniHesapAç_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesap h = new Hesap();

            h.HesapNoAta();
            while (banka.HesapNoSorgula(h.HesapNo) == h.HesapNo.ToString())
                h.HesapNoAta(); 
                
            h.Bakiye = Convert.ToInt32(txtBakiye.Text);
            banka.HesapEkle(txtMusteriNoYH.Text, h);
        }
    }
}

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
    public partial class FormBankaGelirGiderRaporu : Form
    {
        public Banka banka;

        public FormBankaGelirGiderRaporu()
        {
            InitializeComponent();
        }

        private void FormBankaGelirGiderRaporu_Load(object sender, EventArgs e)
        {
            this.Left = 1;
            this.Top = 1;
            //this.WindowState = FormWindowState.Normal;
            banka.HesapBakiyeleri();
            txtGelirGider.Text = "Banka Hesaplarındaki Toplam Para : " + banka.HesaplardakiPara+" TL"+ Environment.NewLine + "Banka Toplam Geliri : " + banka.Gelir + " TL"  + Environment.NewLine +
                "Banka Toplam Gideri : " + banka.Gider + " TL"+Environment.NewLine+"Gelir-Gider Farkı : "+(banka.Gelir-banka.Gider) + " TL" + Environment.NewLine + "Banka Genel Toplam Para : " + banka.Kasa + " TL" ;
        }

        private void txtGelirGider_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BurgerRestoran_161023
{
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
        }

        private void TumSiparisler_Load(object sender, EventArgs e)
        {
            lstSiparisler.Items.Clear();
            foreach (Siparis siparis in Form1.siparisler)
            {
                lstSiparisler.Items.Add(siparis);
            }

            decimal ciro = 0;
            foreach (Siparis siparis1 in lstSiparisler.Items)
            {
                ciro += siparis1.ToplamFiyat;
            }

            lblCiro.Text = ciro.ToString();
            lblSiparisAdedi.Text = lstSiparisler.Items.Count.ToString();

            decimal ekstraMalzemeGeliri = 0;

            foreach (Siparis siparis2 in lstSiparisler.Items)
            {
                foreach (EkstraMalzeme ekstraMalzeme in siparis2.EkstraMalzemeler) 
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.Fiyat * siparis2.MenuAdedi;
                }
            }

            lblEkstraMalGeliri.Text = ekstraMalzemeGeliri.ToString();

            decimal toplamSatilanUrunSayisi = 0;

            foreach (Siparis siparis3 in lstSiparisler.Items) 
            {
                toplamSatilanUrunSayisi += siparis3.MenuAdedi + (siparis3.EkstraMalzemeler.Count * siparis3.MenuAdedi);
            }

            lblSatilanUrunAdedi.Text = toplamSatilanUrunSayisi.ToString();
        }
    }
}

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
    public partial class SiparisIslemleri : Form
    {


        public SiparisIslemleri()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);

        }

        private void SiparisIslemleri_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in Form1.menuListesi)
            {
                cbMenuListesi.Items.Add(menu);

            }
            flpEkstraMalzemeler.FlowDirection = FlowDirection.TopDown;
            foreach (EkstraMalzeme ekstraMalzeme in Form1.ekstraMalzemeListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstraMalzeme.Ad;
                chk.Tag = ekstraMalzeme;

                flpEkstraMalzemeler.Controls.Add(chk);
            }

            foreach (Siparis siparis in Form1.siparisler)
            {
                lstSiparisler.Items.Add(siparis);
            }
        }

        private void flpEkstraMalzemeler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            decimal ekstraMalzemeFiyat = 0;
            try
            {
                if (cbMenuListesi.SelectedIndex != -1)
                {
                    siparis.Menu = (Menu)cbMenuListesi.SelectedItem;
                }

                
                foreach (CheckBox chk in flpEkstraMalzemeler.Controls)
                {
                    if (chk.Checked)
                    {
                        EkstraMalzeme ekstraMalzeme = (EkstraMalzeme)chk.Tag;
                        siparis.EkstraMalzemeler.Add(ekstraMalzeme);
                        ekstraMalzemeFiyat += ekstraMalzeme.Fiyat;
                    }





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            siparis.Boy = rbOrta.Checked ? "Orta" : rbKucuk.Checked ? "Kucuk" : rbBuyuk.Checked ? "Buyuk" : "Boy seçilmedi";
            siparis.MenuAdedi = nudAdet.Value;

            siparis.ToplamFiyat += (siparis.Menu.Fiyat * siparis.MenuAdedi) + (siparis.MenuAdedi * ekstraMalzemeFiyat);

            lstSiparisler.Items.Add(siparis);

            Form1.KontrolleriTemizle(this);

            decimal toplamFiyat = 0;

            foreach (Siparis sprs1 in lstSiparisler.Items)
            {
                toplamFiyat += sprs1.ToplamFiyat;
            }

            lblToplam.Text = toplamFiyat.ToString();
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Siparişleri onaylamak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (Siparis siparis in lstSiparisler.Items)
                {
                    Form1.siparisler.Add(siparis);
                }

                lstSiparisler.Items.Clear();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Form1.KontrolleriTemizle(this);
            lstSiparisler.Items.Clear();
        }



        //public void MenuListesineEkle(Menu menu) 
        //{
        //    menuListesi.Add(menu);
        //}

        //public void EkstraMalzemeListesineEkle(EkstraMalzeme ekstraMalzeme)
        //{
        //    ekstraMalzemeListesi.Add(ekstraMalzeme);
        //}


    }
}

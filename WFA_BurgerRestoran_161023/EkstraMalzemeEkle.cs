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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
        }

        private void EkstraMalzemeEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Menüyü eklemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();

                ekstraMalzeme.Ad = txtEkstraMalzemeAdi.Text;
                ekstraMalzeme.Fiyat = nudExtraMalzemeFiyati.Value;

                Form1.ekstraMalzemeListesi.Add(ekstraMalzeme);

                Form1.KontrolleriTemizle(this);
            }

                

        }
    }
}

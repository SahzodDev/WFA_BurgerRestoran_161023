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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
        }
        
        

        private void MenuEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Menüyü eklemek istediğinize emin misiniz?","Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                Menu menu = new Menu();

                menu.Ad = txtMenuAdi.Text;
                menu.Fiyat = nudMenuFiyati.Value;

                Form1.menuListesi.Add(menu);

                Form1.KontrolleriTemizle(this);
            }
            


        }
    }
}

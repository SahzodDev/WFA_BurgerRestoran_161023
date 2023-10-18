namespace WFA_BurgerRestoran_161023
{
    public partial class Form1 : Form
    {
        public static List<Menu> menuListesi = new List<Menu>()
        {
            new Menu()
            {
                Ad = "Big King Menu",
                Fiyat = 150
            },
            new Menu() 
            {
                Ad = "Quarter Pounder Menu",
                Fiyat = 195
            }
        };
        public static List<EkstraMalzeme> ekstraMalzemeListesi = new List<EkstraMalzeme>() {
        new EkstraMalzeme()
        {
            Ad = "Ketçap",
            Fiyat = 15
        },
        new EkstraMalzeme() 
        {
            Ad = "Mayonez",
            Fiyat = 15
        }
        };
        public static List<Siparis> siparisler = new List<Siparis>();
        public Form1()
        {
            InitializeComponent();

        }
        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisIslemleri siparisIslemleri = new SiparisIslemleri();
            siparisIslemleri.MdiParent = this;
            this.Width = siparisIslemleri.Width + 40;
            this.Height = siparisIslemleri.Height + 60;
            siparisIslemleri.Show();
        }

        private void sipariþÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public void FormlariKapat()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void ürünÝþlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisIslemleri siparisIslemleri = new SiparisIslemleri();
            siparisIslemleri.MdiParent = this;
            this.Width = siparisIslemleri.Width + 40;
            this.Height = siparisIslemleri.Height + 60;
            siparisIslemleri.Show();
        }

        private void tümSipariþlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            TumSiparisler tumSiparisler = new TumSiparisler();
            tumSiparisler.MdiParent = this;
            this.Width = tumSiparisler.Width + 40;
            this.Height = tumSiparisler.Height + 60;
            tumSiparisler.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MenuEkle menuEkle = new MenuEkle();
            menuEkle.MdiParent = this;
            this.Width = menuEkle.Width + 40;
            this.Height = menuEkle.Height + 60;
            menuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            EkstraMalzemeEkle ekstraMalzeme = new EkstraMalzemeEkle();
            ekstraMalzeme.MdiParent = this;
            this.Width = ekstraMalzeme.Width + 40;
            this.Height = ekstraMalzeme.Height + 60;
            ekstraMalzeme.Show();
        }

        public static void KontrolleriTemizle(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = string.Empty;
                }
                if (control is CheckBox chk)
                {
                    chk.Checked = false;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Value = 0;
                }
                if (control is RadioButton rb)
                {
                    rb.Checked = false;
                }
                if (control is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }

                KontrolleriTemizle(control);
            }
        }
    }
}
namespace WFA_BurgerRestoran_161023
{
    partial class SiparisIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbSiparisIslemleri = new GroupBox();
            btnSiparisEkle = new Button();
            nudAdet = new NumericUpDown();
            label2 = new Label();
            gbBoySecimi = new GroupBox();
            rbBuyuk = new RadioButton();
            rbOrta = new RadioButton();
            rbKucuk = new RadioButton();
            cbMenuListesi = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            lstSiparisler = new ListBox();
            label3 = new Label();
            lblToplam = new Label();
            btnSiparisOnayla = new Button();
            btnTemizle = new Button();
            gbSiparisIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            gbBoySecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbSiparisIslemleri
            // 
            gbSiparisIslemleri.BackColor = SystemColors.ControlLight;
            gbSiparisIslemleri.Controls.Add(btnSiparisEkle);
            gbSiparisIslemleri.Controls.Add(nudAdet);
            gbSiparisIslemleri.Controls.Add(label2);
            gbSiparisIslemleri.Controls.Add(gbBoySecimi);
            gbSiparisIslemleri.Controls.Add(cbMenuListesi);
            gbSiparisIslemleri.Controls.Add(label1);
            gbSiparisIslemleri.Controls.Add(pictureBox1);
            gbSiparisIslemleri.Controls.Add(flpEkstraMalzemeler);
            gbSiparisIslemleri.Location = new Point(12, 12);
            gbSiparisIslemleri.Name = "gbSiparisIslemleri";
            gbSiparisIslemleri.Size = new Size(229, 575);
            gbSiparisIslemleri.TabIndex = 0;
            gbSiparisIslemleri.TabStop = false;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(6, 527);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(206, 42);
            btnSiparisEkle.TabIndex = 1;
            btnSiparisEkle.Text = "Siparişi Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(53, 461);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(153, 23);
            nudAdet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 464);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Adet";
            // 
            // gbBoySecimi
            // 
            gbBoySecimi.Controls.Add(rbBuyuk);
            gbBoySecimi.Controls.Add(rbOrta);
            gbBoySecimi.Controls.Add(rbKucuk);
            gbBoySecimi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gbBoySecimi.Location = new Point(6, 344);
            gbBoySecimi.Name = "gbBoySecimi";
            gbBoySecimi.Size = new Size(217, 100);
            gbBoySecimi.TabIndex = 4;
            gbBoySecimi.TabStop = false;
            gbBoySecimi.Text = "Boyu Seçiniz";
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(140, 26);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(66, 24);
            rbBuyuk.TabIndex = 3;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(78, 26);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(56, 24);
            rbOrta.TabIndex = 2;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(6, 26);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(66, 24);
            rbKucuk.TabIndex = 1;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // cbMenuListesi
            // 
            cbMenuListesi.FormattingEnabled = true;
            cbMenuListesi.Location = new Point(6, 155);
            cbMenuListesi.Name = "cbMenuListesi";
            cbMenuListesi.Size = new Size(206, 23);
            cbMenuListesi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 132);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu Seçiniz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1200x627_hamburger_nerenin_yemegi_hamburger_hangi_ulkenin_yemegidir_1632722854093;
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Location = new Point(12, 184);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(200, 152);
            flpEkstraMalzemeler.TabIndex = 5;
            flpEkstraMalzemeler.Paint += flpEkstraMalzemeler_Paint;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(281, 24);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(854, 454);
            lstSiparisler.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(281, 524);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Toplam";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Red;
            lblToplam.Location = new Point(368, 524);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(53, 28);
            lblToplam.TabIndex = 3;
            lblToplam.Text = "0.00";
            // 
            // btnSiparisOnayla
            // 
            btnSiparisOnayla.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisOnayla.Location = new Point(934, 506);
            btnSiparisOnayla.Name = "btnSiparisOnayla";
            btnSiparisOnayla.Size = new Size(201, 75);
            btnSiparisOnayla.TabIndex = 4;
            btnSiparisOnayla.Text = "Siparişi Onayla";
            btnSiparisOnayla.UseVisualStyleBackColor = true;
            btnSiparisOnayla.Click += btnSiparisOnayla_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTemizle.Location = new Point(712, 506);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(201, 75);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Listeyi Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // SiparisIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1163, 599);
            Controls.Add(btnTemizle);
            Controls.Add(btnSiparisOnayla);
            Controls.Add(lblToplam);
            Controls.Add(label3);
            Controls.Add(lstSiparisler);
            Controls.Add(gbSiparisIslemleri);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisIslemleri";
            StartPosition = FormStartPosition.Manual;
            Text = "SiparisIslemleri";
            Load += SiparisIslemleri_Load;
            gbSiparisIslemleri.ResumeLayout(false);
            gbSiparisIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            gbBoySecimi.ResumeLayout(false);
            gbBoySecimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbSiparisIslemleri;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cbMenuListesi;
        private GroupBox gbBoySecimi;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private RadioButton rbBuyuk;
        private Button btnSiparisEkle;
        private NumericUpDown nudAdet;
        private Label label2;
        private ListBox lstSiparisler;
        private Label label3;
        private Label lblToplam;
        private Button btnSiparisOnayla;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Button btnTemizle;
    }
}
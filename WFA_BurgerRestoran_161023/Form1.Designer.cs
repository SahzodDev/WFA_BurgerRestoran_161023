namespace WFA_BurgerRestoran_161023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            siparişİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            tümSiparişlerToolStripMenuItem = new ToolStripMenuItem();
            ürünİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            menüEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişİşlemleriToolStripMenuItem, ürünİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(839, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, tümSiparişlerToolStripMenuItem });
            siparişİşlemleriToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            siparişİşlemleriToolStripMenuItem.Size = new Size(125, 24);
            siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            siparişİşlemleriToolStripMenuItem.Click += siparişİşlemleriToolStripMenuItem_Click;
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(173, 24);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // tümSiparişlerToolStripMenuItem
            // 
            tümSiparişlerToolStripMenuItem.Name = "tümSiparişlerToolStripMenuItem";
            tümSiparişlerToolStripMenuItem.Size = new Size(173, 24);
            tümSiparişlerToolStripMenuItem.Text = "Tüm Siparişler";
            tümSiparişlerToolStripMenuItem.Click += tümSiparişlerToolStripMenuItem_Click;
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menüEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            ürünİşlemleriToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            ürünİşlemleriToolStripMenuItem.Size = new Size(112, 24);
            ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            ürünİşlemleriToolStripMenuItem.Click += ürünİşlemleriToolStripMenuItem_Click;
            // 
            // menüEkleToolStripMenuItem
            // 
            menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            menüEkleToolStripMenuItem.Size = new Size(213, 24);
            menüEkleToolStripMenuItem.Text = "Menü Ekle";
            menüEkleToolStripMenuItem.Click += menüEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(213, 24);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 594);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KD-15 Burger Restoran";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem tümSiparişlerToolStripMenuItem;
        private ToolStripMenuItem menüEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}
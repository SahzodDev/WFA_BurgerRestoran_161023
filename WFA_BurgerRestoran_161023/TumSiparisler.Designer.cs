namespace WFA_BurgerRestoran_161023
{
    partial class TumSiparisler
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
            label1 = new Label();
            lstSiparisler = new ListBox();
            groupBox1 = new GroupBox();
            lblCiro = new Label();
            groupBox2 = new GroupBox();
            lblSiparisAdedi = new Label();
            groupBox3 = new GroupBox();
            lblEkstraMalGeliri = new Label();
            groupBox4 = new GroupBox();
            lblSatilanUrunAdedi = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 0;
            label1.Text = "Tüm Siparişler";
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(12, 97);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(327, 439);
            lstSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiro);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(345, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(66, 44);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(62, 25);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "₺ 0.00";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSiparisAdedi);
            groupBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(345, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toplam Sipariş";
            // 
            // lblSiparisAdedi
            // 
            lblSiparisAdedi.AutoSize = true;
            lblSiparisAdedi.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblSiparisAdedi.ForeColor = Color.Red;
            lblSiparisAdedi.Location = new Point(66, 44);
            lblSiparisAdedi.Name = "lblSiparisAdedi";
            lblSiparisAdedi.Size = new Size(22, 25);
            lblSiparisAdedi.TabIndex = 0;
            lblSiparisAdedi.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEkstraMalGeliri);
            groupBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(345, 309);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalGeliri
            // 
            lblEkstraMalGeliri.AutoSize = true;
            lblEkstraMalGeliri.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalGeliri.ForeColor = Color.Red;
            lblEkstraMalGeliri.Location = new Point(66, 44);
            lblEkstraMalGeliri.Name = "lblEkstraMalGeliri";
            lblEkstraMalGeliri.Size = new Size(62, 25);
            lblEkstraMalGeliri.TabIndex = 0;
            lblEkstraMalGeliri.Text = "₺ 0.00";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSatilanUrunAdedi);
            groupBox4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(345, 415);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 100);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            lblSatilanUrunAdedi.AutoSize = true;
            lblSatilanUrunAdedi.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanUrunAdedi.ForeColor = Color.Red;
            lblSatilanUrunAdedi.Location = new Point(66, 44);
            lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            lblSatilanUrunAdedi.Size = new Size(22, 25);
            lblSatilanUrunAdedi.TabIndex = 0;
            lblSatilanUrunAdedi.Text = "0";
            // 
            // TumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 667);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstSiparisler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TumSiparisler";
            StartPosition = FormStartPosition.Manual;
            Text = "TumSiparisler";
            Load += TumSiparisler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSiparisler;
        private GroupBox groupBox1;
        private Label lblCiro;
        private GroupBox groupBox2;
        private Label lblSiparisAdedi;
        private GroupBox groupBox3;
        private Label lblEkstraMalGeliri;
        private GroupBox groupBox4;
        private Label lblSatilanUrunAdedi;
    }
}
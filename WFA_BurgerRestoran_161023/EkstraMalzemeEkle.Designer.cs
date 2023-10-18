namespace WFA_BurgerRestoran_161023
{
    partial class EkstraMalzemeEkle
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
            btnEkle = new Button();
            groupBox1 = new GroupBox();
            nudExtraMalzemeFiyati = new NumericUpDown();
            txtEkstraMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudExtraMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(197, 310);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 53);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudExtraMalzemeFiyati);
            groupBox1.Controls.Add(txtEkstraMalzemeAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(59, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 176);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Malzeme Ekle";
            // 
            // nudExtraMalzemeFiyati
            // 
            nudExtraMalzemeFiyati.Location = new Point(82, 110);
            nudExtraMalzemeFiyati.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudExtraMalzemeFiyati.Name = "nudExtraMalzemeFiyati";
            nudExtraMalzemeFiyati.Size = new Size(174, 31);
            nudExtraMalzemeFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(82, 55);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(174, 31);
            txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 116);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 466);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            StartPosition = FormStartPosition.Manual;
            Text = "EkstraMalzemeEkle";
            Load += EkstraMalzemeEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudExtraMalzemeFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private GroupBox groupBox1;
        private NumericUpDown nudExtraMalzemeFiyati;
        private TextBox txtEkstraMalzemeAdi;
        private Label label2;
        private Label label1;
    }
}
namespace WFA_BurgerRestoran_161023
{
    partial class MenuEkle
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
            groupBox1 = new GroupBox();
            nudMenuFiyati = new NumericUpDown();
            txtMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnEkle = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudMenuFiyati);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü Ekle";
            // 
            // nudMenuFiyati
            // 
            nudMenuFiyati.Location = new Point(82, 110);
            nudMenuFiyati.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMenuFiyati.Name = "nudMenuFiyati";
            nudMenuFiyati.Size = new Size(174, 31);
            nudMenuFiyati.TabIndex = 3;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(82, 55);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(174, 31);
            txtMenuAdi.TabIndex = 2;
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
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(165, 244);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 53);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 344);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            StartPosition = FormStartPosition.Manual;
            Text = "MenuEkle";
            Load += MenuEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown nudMenuFiyati;
        private TextBox txtMenuAdi;
        private Button btnEkle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}